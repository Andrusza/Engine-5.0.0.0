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
    
    public class DepthTest
    {
        public DepthTest()
        {
            Enabled = true;
            Function = DepthFunction.Less;
        }

        public bool Enabled { get; set; }
        public DepthFunction Function { get; set; }
    }
}
