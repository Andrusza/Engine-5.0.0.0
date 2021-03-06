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
    internal class UniformFloatMatrix34GL4x : Uniform<Matrix34<float>>, ICleanable
    {
        internal UniformFloatMatrix34GL4x(string name, int location, ICleanableObserver observer) : base(name, ActiveUniformType.FloatMat3x4)
        {
            _location = location;
            _value = new Matrix34<float>();
            _dirty = true;
            _observer = observer;
            _observer.NotifyDirty(this);
        }

        #region Uniform<> Members

        public override Matrix34<float> Value
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
            GL.UniformMatrix3x4(_location, 1, false, _value.ReadOnlyColumnMajorValues);
            _dirty = false;
        }

        #endregion

        private int _location;
        private Matrix34<float> _value;
        private bool _dirty;
        private readonly ICleanableObserver _observer;
    }
}
