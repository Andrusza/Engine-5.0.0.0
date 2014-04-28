using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderer.GL4x
{
    internal class GraphicsWindowGL : GraphicsWindow
    {
        public GraphicsWindowGL(int width, int height, string title, GameWindowFlags windowType)
        {
            if (width < 0)
            {
                throw new ArgumentOutOfRangeException("width", "Width must be greater than or equal to zero.");
            }

            if (height < 0)
            {
                throw new ArgumentOutOfRangeException("height", "Height must be greater than or equal to zero.");
            }

            if (windowType == GameWindowFlags.Fullscreen)
            {
                width = DisplayDevice.Default.Width;
                height = DisplayDevice.Default.Height;
            }

            _gameWindow = new GameWindow
                        (
                              width,
                              height,
                              new GraphicsMode(24, 24, 8),
                              title,
                              windowType,
                              DisplayDevice.Default,
                              4,
                              4,
                              GraphicsContextFlags.ForwardCompatible | GraphicsContextFlags.Debug
                         );

            FinalizerThreadContextGL.Initialize();
            _gameWindow.MakeCurrent();

            _gameWindow.Resize += new EventHandler<EventArgs>(this.OnResize);
            _gameWindow.UpdateFrame += new EventHandler<FrameEventArgs>(this.OnUpdateFrame);
            _gameWindow.RenderFrame += new EventHandler<FrameEventArgs>(this.OnRenderFrame);
        }

        protected override void ReleaseManagedResources()
        {
            _gameWindow.Dispose();
        }

        private void OnResize<T>(object sender, T e)
        {
            OnResize();
        }

        private void OnUpdateFrame<T>(object sender, T e)
        {
            OnUpdateFrame();
        }

        private void OnRenderFrame<T>(object sender, T e)
        {
            OnPreRenderFrame();
            OnRenderFrame();
            OnPostRenderFrame();
            _gameWindow.SwapBuffers();
        }

        public override void Run(double updateRate)
        {
            _gameWindow.Run(updateRate);
        }

        public override int Width
        {
            get { return _gameWindow.Width; }
        }

        public override int Height
        {
            get { return _gameWindow.Height; }
        }

        private GameWindow _gameWindow;
    }
}