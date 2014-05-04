#region License

//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//

#endregion License

using Engine.Core;
using OpenGlobe.Core;
using OpenTK.Graphics.OpenGL4;
using System;
using System.Globalization;

namespace OpenGlobe.Renderer.GL3x
{
    internal class ShaderObjectGL3x : Disposable
    {
        public ShaderObjectGL3x(ShaderType shaderType, string source)
        {
            _shaderObject = GL.CreateShader(shaderType);
            
            GL.CompileShader(_shaderObject);
            int compileStatus;

            GL.GetShader(_shaderObject, ShaderParameter.CompileStatus, out compileStatus);

            if (compileStatus == 0)
            {
                throw new CouldNotCreateVideoCardResourceException("Could not compile shader object.  Compile Log:  \n\n" + CompileLog);
            }
        }

        ~ShaderObjectGL3x()
        {
            FinalizerThreadContextGL3x.RunFinalizer(Dispose);
        }

        public int Handle
        {
            get { return _shaderObject; }
        }

        public string CompileLog
        {
            get { return GL.GetShaderInfoLog(_shaderObject); }
        }

        #region Disposable Members

        protected override void Dispose(bool disposing)
        {
            // Always delete the shader, even in the finalizer.
            if (_shaderObject != 0)
            {
                GL.DeleteShader(_shaderObject);
                _shaderObject = 0;
            }
            base.Dispose(disposing);
        }

        #endregion Disposable Members

        private int _shaderObject;
    }
}