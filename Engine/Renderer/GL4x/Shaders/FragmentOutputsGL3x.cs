#region License
//
// (C) Copyright 2010 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System.Collections.Generic;
using OpenTK.Graphics.OpenGL4;
using OpenGlobe.Renderer;

namespace OpenGlobe.Renderer.GL4x
{
    internal class FragmentOutputsGL4x : FragmentOutputs
    {
        public FragmentOutputsGL4x(ShaderProgramNameGL4x program)
        {
            _program = program;
        }

        #region FragmentOutputs Members

        public override int this[string index]
        {
            get 
            {
                int i = GL.GetFragDataLocation(_program.Value, index);

                if (i == -1)
                {
                    throw new KeyNotFoundException(index);
                }

                return i;
            }
        }

        #endregion

        private ShaderProgramNameGL4x _program;
    }
}
