#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System;
using OpenTK.Graphics.OpenGL4;
using Engine.Core;
using OpenGlobe.Renderer;

using Renderer.Buffers;
using Renderer;

namespace OpenGlobe.Renderer.GL3x
{
    internal static class TypeConverterGL3x
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
    }

        
}
