#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System.Collections;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL4;
using OpenGlobe.Renderer;

namespace OpenGlobe.Renderer.GL4x
{
    internal class TextureUnitsGL4x : TextureUnits, ICleanableObserver
    {
        public TextureUnitsGL4x()
        {
            //
            // Device.NumberOfTextureUnits is not initialized yet.
            //
            int numberOfTextureUnits;
            GL.GetInteger(GetPName.MaxCombinedTextureImageUnits, out numberOfTextureUnits);

            _textureUnits = new TextureUnit[numberOfTextureUnits];
            for (int i = 0; i < numberOfTextureUnits; ++i)
            {
                TextureUnitGL4x textureUnit = new TextureUnitGL4x(i, this);
                _textureUnits[i] = textureUnit;
            }
            _dirtyTextureUnits = new List<ICleanable>();
            _lastTextureUnit = (TextureUnitGL4x)_textureUnits[numberOfTextureUnits - 1];
        }

        #region TextureUnits Members

        public override TextureUnit this[int index]
        {
            get { return _textureUnits[index]; }
        }

        public override int Count
        {
            get { return _textureUnits.Length; }
        }

        public override IEnumerator GetEnumerator()
        {
            return _textureUnits.GetEnumerator();
        }

        #endregion

        internal void Clean()
        {
            for (int i = 0; i < _dirtyTextureUnits.Count; ++i)
            {
                _dirtyTextureUnits[i].Clean();
            }
            _dirtyTextureUnits.Clear();
            _lastTextureUnit.CleanLastTextureUnit();
        }

        #region ICleanableObserver Members

        public void NotifyDirty(ICleanable value)
        {
            _dirtyTextureUnits.Add(value);
        }

        #endregion

        private TextureUnit[] _textureUnits;
        private IList<ICleanable> _dirtyTextureUnits;
        private TextureUnitGL4x _lastTextureUnit;
    }
}
