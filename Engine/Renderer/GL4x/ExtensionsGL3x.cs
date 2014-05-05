#region License
//
// (C) Copyright 2010 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer.GL4x
{
    internal class ExtensionsGL4x : Extensions
    {
        public ExtensionsGL4x()
        {
            _anisotropicFiltering = false;
            int numberOfExtensions;
            GL.GetInteger(GetPName.NumExtensions, out numberOfExtensions);
            for (uint i = 0; i < numberOfExtensions; ++i)
            {
                if (GL.GetString(StringNameIndexed.Extensions, i) == "GL_EXT_texture_filter_anisotropic")
                {
                    _anisotropicFiltering = true;
                    break;
                }
            }
        }

        public override bool AnisotropicFiltering
        {
            get { return _anisotropicFiltering; }
        }

        private bool _anisotropicFiltering;
    }
}
