using OpenTK;
using OpenTK.Graphics;

namespace Renderer.GL4x
{
    internal static class FinalizerThreadContextGL
    {
        static FinalizerThreadContextGL()
        {
            _window = new NativeWindow();
            _context = new GraphicsContext(new GraphicsMode(32, 24, 8), _window.WindowInfo, 3, 2, GraphicsContextFlags.ForwardCompatible | GraphicsContextFlags.Debug);
        }

        public static void Initialize()
        {
        }

        public delegate void DisposeCallback(bool disposing);

        public static void RunFinalizer(DisposeCallback callback)
        {
            try
            {
                if (!_context.IsDisposed)
                {
                    _context.MakeCurrent(_window.WindowInfo);
                    try
                    {
                        callback(false);
                    }
                    finally
                    {
                        _context.MakeCurrent(null);
                    }
                }
            }
            catch
            {
            }
        }

        private static NativeWindow _window;
        private static GraphicsContext _context;
    }
}