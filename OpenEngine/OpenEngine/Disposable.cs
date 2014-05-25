using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEngine
{
    public abstract class Disposable : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
        }

        ~Disposable()
        {
            Dispose(false);
        }

        protected abstract void ReleaseManagedResources();
       
        private void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                ReleaseManagedResources();
            }
        }
    }
}