#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using OpenTK.Graphics.OpenGL4;
using OpenGlobe.Renderer;

namespace OpenGlobe.Renderer.GL4x
{
    internal class UniformBoolGL4x : Uniform<bool>, ICleanable
    {
        internal UniformBoolGL4x(string name, int location, ICleanableObserver observer)
            : base(name, ActiveUniformType.Bool)
        {
            _location = location;
            _dirty = true;
            _observer = observer;
            _observer.NotifyDirty(this);
        }

        #region Uniform<> Members

        public override bool Value 
        {
            set 
            {
                if (!_dirty && (_value != value))
                {
                    _dirty = true;
                    _observer.NotifyDirty(this);
                }

                _value = value;
            }

            get { return _value; }
        }

        #endregion
        
        #region ICleanable Members

        public void Clean()
        {
            GL.Uniform1(_location, _value ? 1 : 0);
            _dirty = false;
        }

        #endregion

        private int _location;
        private bool _value;
        private bool _dirty;
        private readonly ICleanableObserver _observer;
    }
}
