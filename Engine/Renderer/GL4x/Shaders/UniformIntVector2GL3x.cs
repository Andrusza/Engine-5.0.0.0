﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion


using Engine.Core;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer.GL4x
{
    internal class UniformIntVector2GL4x : Uniform<Vector2I>, ICleanable
    {
        internal UniformIntVector2GL4x(string name, int location, ICleanableObserver observer)
            : base(name, ActiveUniformType.IntVec2)
        {
            _location = location;
            _dirty = true;
            _observer = observer;
            _observer.NotifyDirty(this);
        }

        #region Uniform<> Members

        public override Vector2I Value
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
            GL.Uniform2(_location, _value.X, _value.Y);
            _dirty = false;
        }

        #endregion

        private int _location;
        private Vector2I _value;
        private bool _dirty;
        private readonly ICleanableObserver _observer;
    }
}
