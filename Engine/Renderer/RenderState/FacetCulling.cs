#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System.Drawing;
using Engine.Core;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
    
    public class FacetCulling
    {
        public FacetCulling()
        {
            Enabled = true;
            Face = CullFaceMode.Back;
            FrontFaceWindingOrder = FrontFaceDirection.Ccw;
        }

        public bool Enabled { get; set; }
        public CullFaceMode Face { get; set; }
        public FrontFaceDirection FrontFaceWindingOrder { get; set; }
    }
}
