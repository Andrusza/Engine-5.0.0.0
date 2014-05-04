#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System.Drawing;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
 
    public class Blending
    {
        public Blending()
        {
            Enabled = false;
            SourceRGBFactor = BlendingFactorSrc.One;
            SourceAlphaFactor = BlendingFactorSrc.One;
            DestinationRGBFactor = BlendingFactorDest.Zero;
            DestinationAlphaFactor = BlendingFactorDest.Zero;
            RGBEquation = BlendEquationMode.FuncAdd;
            AlphaEquation = BlendEquationMode.FuncAdd;
            Color = Color.FromArgb(0, 0, 0, 0);
        }

        public bool Enabled { get; set; }
        public BlendingFactorSrc SourceRGBFactor { get; set; }
        public BlendingFactorSrc SourceAlphaFactor { get; set; }
        public BlendingFactorDest DestinationRGBFactor { get; set; }
        public BlendingFactorDest DestinationAlphaFactor { get; set; }
        public BlendEquationMode RGBEquation { get; set; }
        public BlendEquationMode AlphaEquation { get; set; }
        public Color Color { get; set; }
    }
}
