#region License

//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//

#endregion License

using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
    public enum ProgramPointSize
    {
        Enabled,
        Disabled
    }

    public class RenderState
    {
        public RenderState()
        {
            PrimitiveRestart = new PrimitiveRestart();
            FacetCulling = new FacetCulling();
            ProgramPointSize = ProgramPointSize.Disabled;
            PolygonMode = PolygonMode.Fill;
            ScissorTest = new ScissorTest();
            StencilTest = new StencilTest();
            DepthTest = new DepthTest();
            DepthRange = new DepthRange();
            Blending = new Blending();
            ColorMask = new ColorMask(true, true, true, true);
            DepthMask = true;
        }

        public PrimitiveRestart PrimitiveRestart { get; set; }

        public FacetCulling FacetCulling { get; set; }

        public ProgramPointSize ProgramPointSize { get; set; }

        public PolygonMode PolygonMode { get; set; }

        public ScissorTest ScissorTest { get; set; }

        public StencilTest StencilTest { get; set; }

        public DepthTest DepthTest { get; set; }

        public DepthRange DepthRange { get; set; }

        public Blending Blending { get; set; }

        public ColorMask ColorMask { get; set; }

        public bool DepthMask { get; set; }
    }
}