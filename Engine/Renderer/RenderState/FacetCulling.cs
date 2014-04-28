﻿#region License

//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//

#endregion License

using System.Drawing;
using Core.Mesh;

namespace Engine.Renderer
{
    public enum CullFace
    {
        Front,
        Back,
        FrontAndBack
    }

    public class FacetCulling
    {
        public FacetCulling()
        {
            Enabled = true;
            Face = CullFace.Back;
            FrontFaceWindingOrder = WindingOrder.Counterclockwise;
        }

        public bool Enabled { get; set; }
        public CullFace Face { get; set; }
        public WindingOrder FrontFaceWindingOrder { get; set; }
    }
}