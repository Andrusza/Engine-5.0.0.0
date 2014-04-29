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
using ImagingPixelFormat = System.Drawing.Imaging.PixelFormat;

namespace OpenGlobe.Renderer.GL3x
{
    internal class ReadPixelBufferGL3x : ReadPixelBuffer
    {
        public ReadPixelBufferGL3x(PixelBufferUsageHint usageHint, int sizeInBytes)
        {
            _bufferObject = new PixelBufferGL3x(BufferTarget.PixelPackBuffer, ToBufferUsageHint(usageHint), sizeInBytes);
            _usageHint = usageHint;
        }

        internal void Bind()
        {
            _bufferObject.Bind();
        }

        #region ReadPixelBuffer Members

        public override void CopyFromSystemMemory<T>(
            T[] bufferInSystemMemory,
            int destinationOffsetInBytes,
            int lengthInBytes)
        {
            _bufferObject.CopyFromSystemMemory(bufferInSystemMemory, destinationOffsetInBytes, lengthInBytes);
        }

        public override void CopyFromBitmap(Bitmap bitmap)
        {
            _bufferObject.CopyFromBitmap(bitmap);
        }

        public override T[] CopyToSystemMemory<T>(int offsetInBytes, int sizeInBytes)
        {
            return _bufferObject.CopyToSystemMemory<T>(offsetInBytes, sizeInBytes);
        }

        public override Bitmap CopyToBitmap(int width, int height, ImagingPixelFormat pixelFormat)
        {
            return _bufferObject.CopyToBitmap(width, height, pixelFormat);
        }

        public override int SizeInBytes
        {
            get { return _bufferObject.SizeInBytes; }
        }

        public override PixelBufferUsageHint UsageHint
        {
            get { return _usageHint; }
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

        static BufferUsageHint ToBufferUsageHint(PixelBufferUsageHint usageHint)
        {
            return _BufferUsageHints[(int)usageHint];
        }

        private PixelBufferGL3x _bufferObject;
        private PixelBufferUsageHint _usageHint;

        private static readonly BufferUsageHint[] _BufferUsageHints = new[]
        {
            BufferUsageHint.StreamRead,
            BufferUsageHint.StaticRead,
            BufferUsageHint.DynamicRead
        };
    }
}
