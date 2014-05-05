#region License

//
// (C) Copyright 2010 Patrick Cozzi and Kevin Ring
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//

#endregion License

using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer.GL4x
{
    internal class TextureSamplerGL4x : TextureSampler
    {
        public TextureSamplerGL4x(TextureMinFilter minificationFilter, TextureMagFilter magnificationFilter, TextureWrapMode wrapS, TextureWrapMode wrapT, float maximumAnistropy)
            : base(minificationFilter, magnificationFilter, wrapS, wrapT, maximumAnistropy)
        {
            _name = new SamplerNameGL4x();

            int glMinificationFilter = (int)minificationFilter;
            int glMagnificationFilter = (int)magnificationFilter;
            int glWrapS = (int)wrapS;
            int glWrapT = (int)wrapT;

            GL.SamplerParameterI(_name.Value, SamplerParameterName.TextureMinFilter, ref glMinificationFilter);
            GL.SamplerParameterI(_name.Value, SamplerParameterName.TextureMagFilter, ref glMagnificationFilter);
            GL.SamplerParameterI(_name.Value, SamplerParameterName.TextureWrapS, ref glWrapS);
            GL.SamplerParameterI(_name.Value, SamplerParameterName.TextureWrapT, ref glWrapT);

            if (Device.Extensions.AnisotropicFiltering)
            {
                GL.SamplerParameter(_name.Value, SamplerParameterName.TextureMaxAnisotropyExt, maximumAnistropy);
            }
            else
            {
                if (maximumAnistropy != 1)
                {
                    throw new InsufficientVideoCardException("Anisotropic filtering is not supported.  The extension GL_EXT_texture_filter_anisotropic was not found.");
                }
            }
        }

        internal void Bind(int textureUnitIndex)
        {
            GL.BindSampler(textureUnitIndex, _name.Value);
        }

        internal static void UnBind(int textureUnitIndex)
        {
            GL.BindSampler(textureUnitIndex, 0);
        }

        #region Disposable Members

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _name.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion Disposable Members

        private readonly SamplerNameGL4x _name;
    }
}