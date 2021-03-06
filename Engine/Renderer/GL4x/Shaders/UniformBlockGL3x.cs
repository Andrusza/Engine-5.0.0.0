﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System.Diagnostics;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer.GL4x
{
    internal class UniformBlockGL4x : UniformBlock
    {
        internal UniformBlockGL4x(string name, int sizeInBytes, int bindHandle)
            : base(name, sizeInBytes)
        {
            _bindHandle = bindHandle;
        }

        #region UniformBlock Members

        public override void Bind(UniformBuffer uniformBuffer)
        {
            BufferNameGL4x bufferHandle = ((UniformBufferGL4x)uniformBuffer).Handle;
            GL.BindBufferBase(BufferRangeTarget.UniformBuffer, _bindHandle, bufferHandle.Value);
        }

        #endregion

        private int _bindHandle;
    }
}
