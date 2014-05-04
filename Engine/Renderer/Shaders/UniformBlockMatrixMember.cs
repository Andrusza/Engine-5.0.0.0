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
    public class UniformBlockMatrixMember : UniformBlockMember
    {
        internal UniformBlockMatrixMember( string name, ActiveUniformType type, int offsetInBytes, int strideInBytes, bool rowMajor) : base(name, type, offsetInBytes)
        {
            _strideInBytes = strideInBytes;
            _rowMajor = rowMajor;
        }

        public int StrideInBytes
        {
            get { return _strideInBytes; }
        }

        public bool RowMajor
        {
            get { return _rowMajor; }
        }

        private int _strideInBytes;
        private bool _rowMajor;
    }
}
