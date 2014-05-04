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
    public class UniformBlockArrayMember : UniformBlockMember
    {
        internal UniformBlockArrayMember( string name, ActiveUniformType type, int offsetInBytes, int length, int elementStrideInBytes) : base(name, type, offsetInBytes)
        {
            _length = length;
            _elementStrideInBytes = elementStrideInBytes;
        }

        public int Length
        {
            get { return _length; }
        }

        public int ElementStrideInBytes
        {
            get { return _elementStrideInBytes; }
        }

        private int _length;
        private int _elementStrideInBytes;
    }
}
