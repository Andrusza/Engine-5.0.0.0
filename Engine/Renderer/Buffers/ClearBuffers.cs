using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer.Buffers
{
    [Flags]
    public enum ClearBuffers
    {
        ColorBuffer = 1,
        DepthBuffer = 2,
        ColorAndDepthBuffer = 3,
        StencilBuffer = 4,
        All = 7,
    }
}
