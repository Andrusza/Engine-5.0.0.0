using OpenEngine.Input;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEngine.GL
{
    internal class GraphicsWindowGL : GraphicsWindow
    {
        public GraphicsWindowGL(int width, int height, string title, GameWindowFlags gameWindowFlags)
        {
            if (width < 0)
            {
                throw new ArgumentOutOfRangeException("width", "Width must be greater than or equal to zero.");
            }

            if (height < 0)
            {
                throw new ArgumentOutOfRangeException("height", "Height must be greater than or equal to zero.");
            }

            if (gameWindowFlags == GameWindowFlags.Fullscreen)
            {
                width = DisplayDevice.Default.Width;
                height = DisplayDevice.Default.Height;
            }

            _gameWindow = new GameWindow(width, height, new GraphicsMode(24, 24, 8), title, gameWindowFlags,
                DisplayDevice.Default, 4, 4, GraphicsContextFlags.ForwardCompatible | GraphicsContextFlags.Debug);

            //FinalizerThreadContextGL.Initialize();
            _gameWindow.MakeCurrent();

            _gameWindow.Resize += new EventHandler<EventArgs>(this.OnResize);
            _gameWindow.UpdateFrame += new EventHandler<FrameEventArgs>(this.OnUpdateFrame);
            _gameWindow.RenderFrame += new EventHandler<FrameEventArgs>(this.OnRenderFrame);

            _context = new ContextGL(_gameWindow, width, height);

            _mouse = new MouseGL(_gameWindow.Mouse);
            _keyboard = new KeyboardGL(_gameWindow.Keyboard);
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

        #region GraphicsWindow Members

        public override void Run(double updateRate)
        {
            _gameWindow.Run(updateRate);
        }

        public override Context Context
        {
            get { return _context; }
        }

        public override int Width
        {
            get { return _gameWindow.Width; }
        }

        public override int Height
        {
            get { return _gameWindow.Height; }
        }

        public override Mouse Mouse
        {
            get { return _mouse; }
        }

        public override Keyboard Keyboard
        {
            get { return _keyboard; }
        }

        #endregion GraphicsWindow Members

        #region Disposable Members

        protected override void ReleaseManagedResources()
        {
            _gameWindow.Dispose();
        }

        #endregion Disposable Members

        private GameWindow _gameWindow;
        private ContextGL _context;
        private MouseGL _mouse;
        private KeyboardGL _keyboard;
    }
}