using OpenEngine.Events.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEngine.Input
{
    public abstract class Keyboard
    {
        public event EventHandler<KeyboardKeyEventArgs> KeyDown;
        public event EventHandler<KeyboardKeyEventArgs> KeyUp;

        protected virtual void OnKeyDown(OpenTK.Input.Key key)
        {
            EventHandler<KeyboardKeyEventArgs> handler = KeyDown;
            if (handler != null)
            {
                handler(this, new KeyboardKeyEventArgs(OpenTK.Input.ButtonState.Pressed, key));
            }
        }

        protected virtual void OnKeyUp(OpenTK.Input.Key key)
        {
            EventHandler<KeyboardKeyEventArgs> handler = KeyUp;
            if (handler != null)
            {
                handler(this, new KeyboardKeyEventArgs(OpenTK.Input.ButtonState.Released, key));
            }
        }
    }
}
