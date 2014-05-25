using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEngine.GL
{
    public class ContextGL : Context
    {
        private OpenTK.GameWindow _gameWindow;
        private int width;
        private int height;

        public ContextGL(OpenTK.GameWindow _gameWindow, int width, int height)
        {
            // TODO: Complete member initialization
            this._gameWindow = _gameWindow;
            this.width = width;
            this.height = height;
        }
    }
}
