#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using OpenTK.Graphics.OpenGL4;
namespace OpenGlobe.Renderer
{
    public class StencilTestFace
    {
        public StencilTestFace()
        {
            StencilFailOperation = StencilOp.Keep;
            DepthFailStencilPassOperation = StencilOp.Keep;
            DepthPassStencilPassOperation = StencilOp.Keep;
            Function = StencilFunction.Always;
            ReferenceValue = 0;
            Mask = ~0;
        }

        public StencilOp StencilFailOperation { get; set; }
        public StencilOp DepthFailStencilPassOperation { get; set; }
        public StencilOp DepthPassStencilPassOperation { get; set; }
        
        public StencilFunction Function { get; set; }
        public int ReferenceValue { get; set; }
        public int Mask { get; set; }
    }
}
