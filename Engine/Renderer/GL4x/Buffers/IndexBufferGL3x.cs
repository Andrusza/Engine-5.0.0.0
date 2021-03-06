﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using Engine.Core;
using OpenGlobe.Core;
using OpenTK.Graphics.OpenGL4;
using System;

namespace OpenGlobe.Renderer.GL4x
{
    internal class IndexBufferGL4x : IndexBuffer
    {
        public IndexBufferGL4x(BufferUsageHint usageHint, int sizeInBytes)
        {
            _bufferObject = new BufferGL4x(BufferTarget.ElementArrayBuffer, usageHint, sizeInBytes);
        }

        internal void Bind()
        {
            _bufferObject.Bind();
        }

        internal static void UnBind()
        {
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
        }

        internal int Count
        {
            get { return _count; }
        }
        
        #region IndexBuffer Members

        public override void CopyFromSystemMemory<T>(
            T[] bufferInSystemMemory,
            int destinationOffsetInBytes,
            int lengthInBytes)
        {
            if (typeof(T) == typeof(ushort))
            {
                _dataType = DrawElementsType.UnsignedShort;
            }
            else if (typeof(T) == typeof(uint))
            {
                _dataType = DrawElementsType.UnsignedInt;
            }
            else
            {
                throw new ArgumentException(
                    "bufferInSystemMemory must be an array of ushort or uint.", 
                    "bufferInSystemMemory");
            }

            _count = _bufferObject.SizeInBytes / SizeInBytes<T>.Value;
            _bufferObject.CopyFromSystemMemory(bufferInSystemMemory, destinationOffsetInBytes, lengthInBytes);
        }

        public override T[] CopyToSystemMemory<T>(int offsetInBytes, int sizeInBytes)
        {
            return _bufferObject.CopyToSystemMemory<T>(offsetInBytes, sizeInBytes);
        }

        public override int SizeInBytes
        {
            get { return _bufferObject.SizeInBytes; }
        }

        public override BufferUsageHint UsageHint
        {
            get { return _bufferObject.UsageHint; }
        }

        public override DrawElementsType Datatype
        {
            get { return _dataType; }
        }

        #endregion

        #region Disposable Members

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _bufferObject.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        BufferGL4x _bufferObject;
        DrawElementsType _dataType;
        int _count;
    }
}
