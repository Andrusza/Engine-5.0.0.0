#region License

//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//

#endregion License

using OpenTK.Graphics.OpenGL4;
using System;
using ImagingPixelFormat = System.Drawing.Imaging.PixelFormat;

namespace OpenGlobe.Renderer
{
    internal static class TextureUtility
    {
        public static ImageDatatype ImagingPixelFormatToDatatype(ImagingPixelFormat pixelFormat)
        {
            if (!Supported(pixelFormat))
            {
                throw new ArgumentException("Pixel format is not supported.", "pixelFormat");
            }

            // TODO:  Not tested exhaustively
            switch (pixelFormat)
            {
                case ImagingPixelFormat.Format16bppRgb555:
                    return ImageDatatype.UnsignedShort5551;

                case ImagingPixelFormat.Format16bppRgb565:
                    return ImageDatatype.UnsignedShort565;

                case ImagingPixelFormat.Format24bppRgb:
                case ImagingPixelFormat.Format32bppRgb:
                case ImagingPixelFormat.Format32bppArgb:
                    return ImageDatatype.UnsignedByte;

                case ImagingPixelFormat.Format48bppRgb:
                case ImagingPixelFormat.Format64bppArgb:
                    return ImageDatatype.UnsignedShort;

                case ImagingPixelFormat.Format16bppArgb1555:
                    return ImageDatatype.UnsignedShort1555Reversed;
            }

            throw new ArgumentException("pixelFormat");
        }

        public static OpenTK.Graphics.OpenGL4.PixelFormat ImagingPixelFormatToImageFormat(ImagingPixelFormat pixelFormat)
        {
            if (!Supported(pixelFormat))
            {
                throw new ArgumentException("Pixel format is not supported.", "pixelFormat");
            }

            switch (pixelFormat)
            {
                case ImagingPixelFormat.Format16bppRgb555:
                case ImagingPixelFormat.Format16bppRgb565:
                case ImagingPixelFormat.Format24bppRgb:
                case ImagingPixelFormat.Format32bppRgb:
                case ImagingPixelFormat.Format48bppRgb:
                    return PixelFormat.Bgr;

                case ImagingPixelFormat.Format16bppArgb1555:
                case ImagingPixelFormat.Format32bppArgb:
                case ImagingPixelFormat.Format64bppArgb:
                    return PixelFormat.Bgra;
            }

            throw new ArgumentException("pixelFormat");
        }

        private static bool Supported(ImagingPixelFormat pixelFormat)
        {
            return
                (pixelFormat != ImagingPixelFormat.DontCare) &&
                (pixelFormat != ImagingPixelFormat.Undefined) &&
                (pixelFormat != ImagingPixelFormat.Indexed) &&
                (pixelFormat != ImagingPixelFormat.Gdi) &&
                (pixelFormat != ImagingPixelFormat.Extended) &&
                (pixelFormat != ImagingPixelFormat.Format1bppIndexed) &&
                (pixelFormat != ImagingPixelFormat.Format4bppIndexed) &&
                (pixelFormat != ImagingPixelFormat.Format8bppIndexed) &&
                (pixelFormat != ImagingPixelFormat.Alpha) &&
                (pixelFormat != ImagingPixelFormat.PAlpha) &&
                (pixelFormat != ImagingPixelFormat.Format32bppPArgb) &&
                (pixelFormat != ImagingPixelFormat.Format16bppGrayScale) &&
                (pixelFormat != ImagingPixelFormat.Format64bppPArgb) &&
                (pixelFormat != ImagingPixelFormat.Canonical);
        }

        public static bool IsPowerOfTwo(uint i)
        {
            return (i != 0) && ((i & (i - 1)) == 0);
        }

        public static int RequiredSizeInBytes(int width, int height, PixelFormat format, PixelType dataType, int rowAlignment)
        {
            int rowSize = width * NumberOfChannels(format) * SizeInBytes(dataType);

            int remainder = (rowSize % rowAlignment);
            rowSize += (rowAlignment - remainder) % rowAlignment;

            return rowSize * height;
        }

        public static int NumberOfChannels(PixelFormat format)
        {
            switch (format)
            {
                case PixelFormat.StencilIndex:
                case PixelFormat.DepthComponent:
                case PixelFormat.Red:
                case PixelFormat.Green:
                case PixelFormat.Blue:
                case PixelFormat.RedInteger:
                case PixelFormat.GreenInteger:
                case PixelFormat.BlueInteger:
                    return 1;

                case PixelFormat.Rg:
                case PixelFormat.RgInteger:
                case PixelFormat.DepthStencil:
                    return 2;

                case PixelFormat.Rgb:
                case PixelFormat.Bgr:
                case PixelFormat.RgbInteger:
                case PixelFormat.BgrInteger:
                    return 3;

                case PixelFormat.Rgba:
                case PixelFormat.Bgra:
                case PixelFormat.RgbaInteger:
                case PixelFormat.BgraInteger:
                    return 4;
            }

            throw new ArgumentException("format");
        }

        public static int SizeInBytes(PixelType dataType)
        {
            switch (dataType)
            {
                case PixelType.Byte:
                    return 1;

                case PixelType.UnsignedByte:
                    return 1;

                case PixelType.Short:
                    return 2;

                case PixelType.UnsignedShort:
                    return 2;

                case PixelType.Int:
                    return 4;

                case PixelType.UnsignedInt:
                    return 4;

                case PixelType.Float:
                    return 4;

                case PixelType.HalfFloat:
                    return 2;

                case PixelType.UnsignedByte332:
                    return 1;

                case PixelType.UnsignedShort4444:
                    return 2;

                case PixelType.UnsignedShort5551:
                    return 2;

                case PixelType.UnsignedInt8888:
                    return 4;

                case PixelType.UnsignedInt1010102:
                    return 4;

                case PixelType.UnsignedByte233Reversed:
                    return 1;

                case PixelType.UnsignedShort565:
                    return 2;

                case PixelType.UnsignedShort565Reversed:
                    return 2;

                case PixelType.UnsignedShort4444Reversed:
                    return 2;

                case PixelType.UnsignedShort1555Reversed:
                    return 2;

                case PixelType.UnsignedInt8888Reversed:
                    return 4;

                case PixelType.UnsignedInt2101010Reversed:
                    return 4;

                case PixelType.UnsignedInt248:
                    return 4;
            }

            throw new ArgumentException("dataType");
        }
    }
}