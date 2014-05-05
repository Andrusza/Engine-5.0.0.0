#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Graphics;

namespace OpenGlobe.Renderer.GL4x
{
    internal class GraphicsWindowGL4x : GraphicsWindow
    {
        public GraphicsWindowGL4x(int width, int height, string title, GameWindowFlags gameWindowFlags)
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

            FinalizerThreadContextGL4x.Initialize();
            _gameWindow.MakeCurrent();
            
            _gameWindow.Resize += new EventHandler<EventArgs>(this.OnResize);
            _gameWindow.UpdateFrame += new EventHandler<FrameEventArgs>(this.OnUpdateFrame);
            _gameWindow.RenderFrame += new EventHandler<FrameEventArgs>(this.OnRenderFrame);

            _context = new ContextGL4x(_gameWindow, width, height);

            _mouse = new MouseGL4x(_gameWindow.Mouse);
            _keyboard = new KeyboardGL4x(_gameWindow.Keyboard);
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

        #endregion

        #region Disposable Members

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _gameWindow.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        private GameWindow _gameWindow;
        private ContextGL4x _context;
        private MouseGL4x _mouse;
        private KeyboardGL4x _keyboard;
    }
}
