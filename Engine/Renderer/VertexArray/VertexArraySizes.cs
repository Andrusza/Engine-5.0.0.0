#region License
//
// (C) Copyright 2010 Patrick Cozzi and Kevin Ring
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System;
using OpenGlobe.Core;
using Engine.Core;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
    internal static class VertexArraySizes
    {
        public static int SizeOf(DrawElementsType type)
        {
            switch (type)
            {
                case DrawElementsType.UnsignedShort:
                    return sizeof(ushort);
                case DrawElementsType.UnsignedInt:
                    return sizeof(uint);
                case DrawElementsType.UnsignedByte:
                    return sizeof(sbyte);
            }

            throw new ArgumentException("type");
        }

        public static int SizeOf(VertexAttribIPointerType type)
        {
            switch (type)
            {
                case VertexAttribIPointerType.Byte:
                case VertexAttribIPointerType.UnsignedByte:
                    return sizeof(byte);
                case VertexAttribIPointerType.Short:
                    return sizeof(short);
                case VertexAttribIPointerType.UnsignedShort:
                    return sizeof(ushort);
                case VertexAttribIPointerType.Int:
                    return sizeof(int);
                case VertexAttribIPointerType.UnsignedInt:
                    return sizeof(uint);
              
            }

            throw new ArgumentException("type");
        }
    }
}