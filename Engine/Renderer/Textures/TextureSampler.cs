#region License
//
// (C) Copyright 2010 Patrick Cozzi and Kevin Ring
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using Engine.Core;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
    public abstract class TextureSampler : Disposable
    {
        protected TextureSampler( TextureMinFilter minificationFilter, TextureMagFilter magnificationFilter, TextureWrapMode wrapS, TextureWrapMode wrapT, float maximumAnistropy) 
        {
            _minificationFilter = minificationFilter;
            _magnificationFilter = magnificationFilter;
            _wrapS = wrapS;
            _wrapT = wrapT;
            _maximumAnistropy = maximumAnistropy;
        }

        public TextureMinFilter MinificationFilter
        {
            get { return _minificationFilter;  }
        }

        public TextureMagFilter MagnificationFilter
        {
            get { return _magnificationFilter; }
        }

        public TextureWrapMode WrapS
        {
            get { return _wrapS; }
        }

        public TextureWrapMode WrapT
        {
            get { return _wrapT; }
        }

        public float MaximumAnisotropic
        {
            get { return _maximumAnistropy; }
        }

        private readonly TextureMinFilter _minificationFilter;
        private readonly TextureMagFilter _magnificationFilter;
        private readonly TextureWrapMode _wrapS;
        private readonly TextureWrapMode _wrapT;
        private readonly float _maximumAnistropy;
    }
}
