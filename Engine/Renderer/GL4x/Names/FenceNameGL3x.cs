#region License
//
// (C) Copyright 2010 Patrick Cozzi, Deron Ohlarik, and Kevin Ring
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer.GL4x
{
    internal sealed class FenceNameGL4x : IDisposable
    {
        public FenceNameGL4x()
        {
            _value = GL.FenceSync(SyncCondition.SyncGpuCommandsComplete, 0);
        }

        ~FenceNameGL4x()
        {
            FinalizerThreadContextGL4x.RunFinalizer(Dispose);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IntPtr Value
        {
            get { return _value.Value; }
        }

        private void Dispose(bool disposing)
        {
            if (_value != null)
            {
                GL.DeleteSync(_value.Value);
                _value = null;
            }
        }

        private Nullable<IntPtr> _value;
    }
}
