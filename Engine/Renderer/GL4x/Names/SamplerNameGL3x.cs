#region License
//
// (C) Copyright 2010 Patrick Cozzi and Kevin Ring
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer.GL4x
{
    internal sealed class SamplerNameGL4x : IDisposable
    {
        public SamplerNameGL4x()
        {
            GL.GenSamplers(1, out _value);
        }

        ~SamplerNameGL4x()
        {
            FinalizerThreadContextGL4x.RunFinalizer(Dispose);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int Value
        {
            get { return _value; }
        }

        private void Dispose(bool disposing)
        {
            if (_value != 0)
            {
                GL.DeleteSamplers(1, ref _value);
                _value = 0;
            }
        }

        private int _value;
    }
}
