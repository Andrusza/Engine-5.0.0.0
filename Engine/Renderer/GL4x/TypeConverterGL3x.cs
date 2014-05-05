#region License

//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//

#endregion License

using OpenTK.Graphics.OpenGL4;
using Renderer.Buffers;
using System;

namespace OpenGlobe.Renderer.GL4x
{
    internal static class TypeConverterGL4x
    {
        public static ClearBufferMask To(ClearBuffers mask)
        {
            ClearBufferMask clearMask = 0;

            if ((mask & ClearBuffers.ColorBuffer) != 0)
            {
                clearMask |= ClearBufferMask.ColorBufferBit;
            }

            if ((mask & ClearBuffers.DepthBuffer) != 0)
            {
                clearMask |= ClearBufferMask.DepthBufferBit;
            }

            if ((mask & ClearBuffers.StencilBuffer) != 0)
            {
                clearMask |= ClearBufferMask.StencilBufferBit;
            }

            return clearMask;
        }

        public static PixelInternalFormat To(TextureFormat format)
        {
            switch (format)
            {
                case TextureFormat.RedGreenBlue8:
                    return PixelInternalFormat.Rgb8;

                case TextureFormat.RedGreenBlue16:
                    return PixelInternalFormat.Rgb16;

                case TextureFormat.RedGreenBlueAlpha8:
                    return PixelInternalFormat.Rgba8;

                case TextureFormat.RedGreenBlue10A2:
                    return PixelInternalFormat.Rgb10A2;

                case TextureFormat.RedGreenBlueAlpha16:
                    return PixelInternalFormat.Rgba16;

                case TextureFormat.Depth16:
                    return PixelInternalFormat.DepthComponent16;

                case TextureFormat.Depth24:
                    return PixelInternalFormat.DepthComponent24;

                case TextureFormat.Red8:
                    return PixelInternalFormat.R8;

                case TextureFormat.Red16:
                    return PixelInternalFormat.R16;

                case TextureFormat.RedGreen8:
                    return PixelInternalFormat.Rg8;

                case TextureFormat.RedGreen16:
                    return PixelInternalFormat.Rg16;

                case TextureFormat.Red16f:
                    return PixelInternalFormat.R16f;

                case TextureFormat.Red32f:
                    return PixelInternalFormat.R32f;

                case TextureFormat.RedGreen16f:
                    return PixelInternalFormat.Rg16f;

                case TextureFormat.RedGreen32f:
                    return PixelInternalFormat.Rg32f;

                case TextureFormat.Red8i:
                    return PixelInternalFormat.R8i;

                case TextureFormat.Red8ui:
                    return PixelInternalFormat.R8ui;

                case TextureFormat.Red16i:
                    return PixelInternalFormat.R16i;

                case TextureFormat.Red16ui:
                    return PixelInternalFormat.R16ui;

                case TextureFormat.Red32i:
                    return PixelInternalFormat.R32i;

                case TextureFormat.Red32ui:
                    return PixelInternalFormat.R32ui;

                case TextureFormat.RedGreen8i:
                    return PixelInternalFormat.Rg8i;

                case TextureFormat.RedGreen8ui:
                    return PixelInternalFormat.Rg8ui;

                case TextureFormat.RedGreen16i:
                    return PixelInternalFormat.Rg16i;

                case TextureFormat.RedGreen16ui:
                    return PixelInternalFormat.Rg16ui;

                case TextureFormat.RedGreen32i:
                    return PixelInternalFormat.Rg32i;

                case TextureFormat.RedGreen32ui:
                    return PixelInternalFormat.Rg32ui;

                case TextureFormat.RedGreenBlueAlpha32f:
                    return PixelInternalFormat.Rgba32f;

                case TextureFormat.RedGreenBlue32f:
                    return PixelInternalFormat.Rgb32f;

                case TextureFormat.RedGreenBlueAlpha16f:
                    return PixelInternalFormat.Rgba16f;

                case TextureFormat.RedGreenBlue16f:
                    return PixelInternalFormat.Rgb16f;

                case TextureFormat.Depth24Stencil8:
                    return PixelInternalFormat.Depth24Stencil8;

                case TextureFormat.Red11fGreen11fBlue10f:
                    return PixelInternalFormat.R11fG11fB10f;

                case TextureFormat.RedGreenBlue9E5:
                    return PixelInternalFormat.Rgb9E5;

                case TextureFormat.SRedGreenBlue8:
                    return PixelInternalFormat.Srgb8;

                case TextureFormat.SRedGreenBlue8Alpha8:
                    return PixelInternalFormat.Srgb8Alpha8;

                case TextureFormat.Depth32f:
                    return PixelInternalFormat.DepthComponent32f;

                case TextureFormat.Depth32fStencil8:
                    return PixelInternalFormat.Depth32fStencil8;

                case TextureFormat.RedGreenBlueAlpha32ui:
                    return PixelInternalFormat.Rgba32ui;

                case TextureFormat.RedGreenBlue32ui:
                    return PixelInternalFormat.Rgb32ui;

                case TextureFormat.RedGreenBlueAlpha16ui:
                    return PixelInternalFormat.Rgba16ui;

                case TextureFormat.RedGreenBlue16ui:
                    return PixelInternalFormat.Rgb16ui;

                case TextureFormat.RedGreenBlueAlpha8ui:
                    return PixelInternalFormat.Rgba8ui;

                case TextureFormat.RedGreenBlue8ui:
                    return PixelInternalFormat.Rgb8ui;

                case TextureFormat.RedGreenBlueAlpha32i:
                    return PixelInternalFormat.Rgba32i;

                case TextureFormat.RedGreenBlue32i:
                    return PixelInternalFormat.Rgb32i;

                case TextureFormat.RedGreenBlueAlpha16i:
                    return PixelInternalFormat.Rgba16i;

                case TextureFormat.RedGreenBlue16i:
                    return PixelInternalFormat.Rgb16i;

                case TextureFormat.RedGreenBlueAlpha8i:
                    return PixelInternalFormat.Rgba8i;

                case TextureFormat.RedGreenBlue8i:
                    return PixelInternalFormat.Rgb8i;
            }

            throw new ArgumentException("format");
        }

        public static PixelType To(ImageDatatype type)
        {
            switch (type)
            {
                case ImageDatatype.Byte:
                    return PixelType.Byte;

                case ImageDatatype.UnsignedByte:
                    return PixelType.UnsignedByte;

                case ImageDatatype.Short:
                    return PixelType.Short;

                case ImageDatatype.UnsignedShort:
                    return PixelType.UnsignedShort;

                case ImageDatatype.Int:
                    return PixelType.Int;

                case ImageDatatype.UnsignedInt:
                    return PixelType.UnsignedInt;

                case ImageDatatype.Float:
                    return PixelType.Float;

                case ImageDatatype.HalfFloat:
                    return PixelType.HalfFloat;

                case ImageDatatype.UnsignedByte332:
                    return PixelType.UnsignedByte332;

                case ImageDatatype.UnsignedShort4444:
                    return PixelType.UnsignedShort4444;

                case ImageDatatype.UnsignedShort5551:
                    return PixelType.UnsignedShort5551;

                case ImageDatatype.UnsignedInt8888:
                    return PixelType.UnsignedInt8888;

                case ImageDatatype.UnsignedInt1010102:
                    return PixelType.UnsignedInt1010102;

                case ImageDatatype.UnsignedByte233Reversed:
                    return PixelType.UnsignedByte233Reversed;

                case ImageDatatype.UnsignedShort565:
                    return PixelType.UnsignedShort565;

                case ImageDatatype.UnsignedShort565Reversed:
                    return PixelType.UnsignedShort565Reversed;

                case ImageDatatype.UnsignedShort4444Reversed:
                    return PixelType.UnsignedShort4444Reversed;

                case ImageDatatype.UnsignedShort1555Reversed:
                    return PixelType.UnsignedShort1555Reversed;

                case ImageDatatype.UnsignedInt8888Reversed:
                    return PixelType.UnsignedInt8888Reversed;

                case ImageDatatype.UnsignedInt2101010Reversed:
                    return PixelType.UnsignedInt2101010Reversed;

                case ImageDatatype.UnsignedInt248:
                    return PixelType.UnsignedInt248;

                case ImageDatatype.UnsignedInt10F11F11FReversed:
                    return PixelType.UnsignedInt10F11F11FRev;

                case ImageDatatype.UnsignedInt5999Reversed:
                    return PixelType.UnsignedInt5999Rev;

                case ImageDatatype.Float32UnsignedInt248Reversed:
                    return PixelType.Float32UnsignedInt248Rev;
            }

            throw new ArgumentException("type");
        }

        public static PixelFormat TextureToPixelFormat(TextureFormat textureFormat)
        {
            // TODO:  Not tested exhaustively
            switch (textureFormat)
            {
                case TextureFormat.RedGreenBlue8:
                case TextureFormat.RedGreenBlue16:
                    return PixelFormat.Rgb;

                case TextureFormat.RedGreenBlueAlpha8:
                case TextureFormat.RedGreenBlue10A2:
                case TextureFormat.RedGreenBlueAlpha16:
                    return PixelFormat.Rgba;

                case TextureFormat.Depth16:
                case TextureFormat.Depth24:
                    return PixelFormat.DepthComponent;

                case TextureFormat.Red8:
                case TextureFormat.Red16:
                    return PixelFormat.Red;

                case TextureFormat.RedGreen8:
                case TextureFormat.RedGreen16:
                    return PixelFormat.Rg;

                case TextureFormat.Red16f:
                case TextureFormat.Red32f:
                    return PixelFormat.Red;

                case TextureFormat.RedGreen16f:
                case TextureFormat.RedGreen32f:
                    return PixelFormat.Rg;

                case TextureFormat.Red8i:
                case TextureFormat.Red8ui:
                case TextureFormat.Red16i:
                case TextureFormat.Red16ui:
                case TextureFormat.Red32i:
                case TextureFormat.Red32ui:
                    return PixelFormat.RedInteger;

                case TextureFormat.RedGreen8i:
                case TextureFormat.RedGreen8ui:
                case TextureFormat.RedGreen16i:
                case TextureFormat.RedGreen16ui:
                case TextureFormat.RedGreen32i:
                case TextureFormat.RedGreen32ui:
                    return PixelFormat.RgInteger;

                case TextureFormat.RedGreenBlueAlpha32f:
                    return PixelFormat.Rgba;

                case TextureFormat.RedGreenBlue32f:
                    return PixelFormat.Rgb;

                case TextureFormat.RedGreenBlueAlpha16f:
                    return PixelFormat.Rgba;

                case TextureFormat.RedGreenBlue16f:
                    return PixelFormat.Rgb;

                case TextureFormat.Depth24Stencil8:
                    return PixelFormat.DepthStencil;

                case TextureFormat.Red11fGreen11fBlue10f:
                case TextureFormat.RedGreenBlue9E5:
                    return PixelFormat.Rgb;

                case TextureFormat.SRedGreenBlue8:
                    return PixelFormat.RgbInteger;

                case TextureFormat.SRedGreenBlue8Alpha8:
                    return PixelFormat.RgbaInteger;

                case TextureFormat.Depth32f:
                    return PixelFormat.DepthComponent;

                case TextureFormat.Depth32fStencil8:
                    return PixelFormat.DepthStencil;

                case TextureFormat.RedGreenBlueAlpha32ui:
                    return PixelFormat.RgbaInteger;

                case TextureFormat.RedGreenBlue32ui:
                    return PixelFormat.RgbInteger;

                case TextureFormat.RedGreenBlueAlpha16ui:
                    return PixelFormat.RgbaInteger;

                case TextureFormat.RedGreenBlue16ui:
                    return PixelFormat.RgbInteger;

                case TextureFormat.RedGreenBlueAlpha8ui:
                    return PixelFormat.RgbaInteger;

                case TextureFormat.RedGreenBlue8ui:
                    return PixelFormat.RgbInteger;

                case TextureFormat.RedGreenBlueAlpha32i:
                    return PixelFormat.RgbaInteger;

                case TextureFormat.RedGreenBlue32i:
                    return PixelFormat.RgbInteger;

                case TextureFormat.RedGreenBlueAlpha16i:
                    return PixelFormat.RgbaInteger;

                case TextureFormat.RedGreenBlue16i:
                    return PixelFormat.RgbInteger;

                case TextureFormat.RedGreenBlueAlpha8i:
                    return PixelFormat.RgbaInteger;

                case TextureFormat.RedGreenBlue8i:
                    return PixelFormat.RgbInteger;
            }

            throw new ArgumentException("textureFormat");
        }

        public static PixelType TextureToPixelType(TextureFormat textureFormat)
        {
            // TODO:  Not tested exhaustively
            switch (textureFormat)
            {
                case TextureFormat.RedGreenBlue8:
                    return PixelType.UnsignedByte;

                case TextureFormat.RedGreenBlue16:
                    return PixelType.UnsignedShort;

                case TextureFormat.RedGreenBlueAlpha8:
                    return PixelType.UnsignedByte;

                case TextureFormat.RedGreenBlue10A2:
                    return PixelType.UnsignedInt1010102;

                case TextureFormat.RedGreenBlueAlpha16:
                    return PixelType.UnsignedShort;

                case TextureFormat.Depth16:
                    return PixelType.HalfFloat;

                case TextureFormat.Depth24:
                    return PixelType.Float;

                case TextureFormat.Red8:
                    return PixelType.UnsignedByte;

                case TextureFormat.Red16:
                    return PixelType.UnsignedShort;

                case TextureFormat.RedGreen8:
                    return PixelType.UnsignedByte;

                case TextureFormat.RedGreen16:
                    return PixelType.UnsignedShort;

                case TextureFormat.Red16f:
                    return PixelType.HalfFloat;

                case TextureFormat.Red32f:
                    return PixelType.Float;

                case TextureFormat.RedGreen16f:
                    return PixelType.HalfFloat;

                case TextureFormat.RedGreen32f:
                    return PixelType.Float;

                case TextureFormat.Red8i:
                    return PixelType.Byte;

                case TextureFormat.Red8ui:
                    return PixelType.UnsignedByte;

                case TextureFormat.Red16i:
                    return PixelType.Short;

                case TextureFormat.Red16ui:
                    return PixelType.UnsignedShort;

                case TextureFormat.Red32i:
                    return PixelType.Int;

                case TextureFormat.Red32ui:
                    return PixelType.UnsignedInt;

                case TextureFormat.RedGreen8i:
                    return PixelType.Byte;

                case TextureFormat.RedGreen8ui:
                    return PixelType.UnsignedByte;

                case TextureFormat.RedGreen16i:
                    return PixelType.Short;

                case TextureFormat.RedGreen16ui:
                    return PixelType.UnsignedShort;

                case TextureFormat.RedGreen32i:
                    return PixelType.Int;

                case TextureFormat.RedGreen32ui:
                    return PixelType.UnsignedInt;

                case TextureFormat.RedGreenBlueAlpha32f:
                    return PixelType.Float;

                case TextureFormat.RedGreenBlue32f:
                    return PixelType.Float;

                case TextureFormat.RedGreenBlueAlpha16f:
                    return PixelType.HalfFloat;

                case TextureFormat.RedGreenBlue16f:
                    return PixelType.HalfFloat;

                case TextureFormat.Depth24Stencil8:
                    return PixelType.UnsignedInt248;

                case TextureFormat.Red11fGreen11fBlue10f:
                    return PixelType.Float;

                case TextureFormat.RedGreenBlue9E5:
                    return PixelType.Float;

                case TextureFormat.SRedGreenBlue8:
                case TextureFormat.SRedGreenBlue8Alpha8:
                    return PixelType.Byte;

                case TextureFormat.Depth32f:
                case TextureFormat.Depth32fStencil8:
                    return PixelType.Float;

                case TextureFormat.RedGreenBlueAlpha32ui:
                case TextureFormat.RedGreenBlue32ui:
                    return PixelType.UnsignedInt;

                case TextureFormat.RedGreenBlueAlpha16ui:
                case TextureFormat.RedGreenBlue16ui:
                    return PixelType.UnsignedShort;

                case TextureFormat.RedGreenBlueAlpha8ui:
                case TextureFormat.RedGreenBlue8ui:
                    return PixelType.UnsignedByte;

                case TextureFormat.RedGreenBlueAlpha32i:
                case TextureFormat.RedGreenBlue32i:
                    return PixelType.UnsignedInt;

                case TextureFormat.RedGreenBlueAlpha16i:
                case TextureFormat.RedGreenBlue16i:
                    return PixelType.UnsignedShort;

                case TextureFormat.RedGreenBlueAlpha8i:
                case TextureFormat.RedGreenBlue8i:
                    return PixelType.UnsignedByte;
            }

            throw new ArgumentException("textureFormat");
        }
    }
}