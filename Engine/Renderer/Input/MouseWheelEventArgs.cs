using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Renderer
{
    public class MouseWheelEventArgs : EventArgs
    {
        public MouseWheelEventArgs(int direction)
        {
            _direction = direction;
        }

        private int _direction;

        public int Direction
        {
            get { return _direction; }
        }
    }
}
