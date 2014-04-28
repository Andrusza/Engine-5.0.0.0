using System;

namespace Engine.Core
{
    public abstract class Disposable : IDisposable
    {
        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Disposable()
        {
            Dispose(false);
        }

        protected abstract void ReleaseManagedResources();

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                ReleaseManagedResources();
            }

            _disposed = true;
        }
    }
}