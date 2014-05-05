#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
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
    internal class VertexArrayGL4x : VertexArray
    {
        public VertexArrayGL4x()
	    {
            _name = new VertexArrayNameGL4x();
            _attributes = new VertexBufferAttributesGL4x();
        }

        internal void Bind()
        {
            GL.BindVertexArray(_name.Value);
        }

        internal void Clean()
        {
            _attributes.Clean();

            if (_dirtyIndexBuffer)
            {
                if (_indexBuffer != null)
                {
                    IndexBufferGL4x bufferObjectGL = (IndexBufferGL4x)_indexBuffer;
                    bufferObjectGL.Bind();
                }
                else
                {
                    IndexBufferGL4x.UnBind();
                }

                _dirtyIndexBuffer = false;
            }
        }

        internal int MaximumArrayIndex()
        {
            return _attributes.MaximumArrayIndex;
        }

        #region VertexArray Members

        public override VertexBufferAttributes Attributes
        {
            get { return _attributes; }
        }

        public override IndexBuffer IndexBuffer
        {
            get { return _indexBuffer; }

            set
            {
                _indexBuffer = value;
                _dirtyIndexBuffer = true;
            }
        }

        #endregion

        #region Disposable Members

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DisposeBuffers)
                {
                    //
                    // Multiple components may share the same vertex buffer, so
                    // find the unique set of vertex buffers used by this vertex array.
                    //
                    HashSet<VertexBuffer> vertexBuffers = new HashSet<VertexBuffer>();

                    foreach (VertexBufferAttribute attribute in _attributes)
                    {
                        vertexBuffers.Add(attribute.VertexBuffer);
                    }

                    foreach (VertexBuffer vb in vertexBuffers)
                    {
                        vb.Dispose();
                    }

                    if (_indexBuffer != null)
                    {
                        _indexBuffer.Dispose();
                    }
                }

                _name.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        private VertexArrayNameGL4x _name;
        private VertexBufferAttributesGL4x _attributes;
        private IndexBuffer _indexBuffer;
        private bool _dirtyIndexBuffer;
    }
}
