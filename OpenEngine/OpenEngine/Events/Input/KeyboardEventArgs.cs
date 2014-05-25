using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;

namespace OpenEngine.Events.Input
{
    public class KeyboardKeyEventArgs : EventArgs
    {
        public KeyboardKeyEventArgs(ButtonState keyboardEvent, Key key)
        {
            _keyboardEvent = keyboardEvent;
            _key = key;
        }

        public ButtonState KeyboardEvent
        {
            get { return _keyboardEvent; }
        }

        public Key Key
        {
            get { return _key; }
        }

        private ButtonState _keyboardEvent;
        private Key _key;
    }
}
