using OpenEngine.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;

namespace OpenEngine.GL
{
    public class KeyboardGL : OpenEngine.Input.Keyboard
    {
        public KeyboardGL(KeyboardDevice keyboard)
        {
            _keyboard = keyboard;

            _keyboard.KeyDown += OpenTKKeyDown;
            _keyboard.KeyUp += OpenTKKeyUp;
        }

        private void OpenTKKeyUp(object sender, OpenTK.Input.KeyboardKeyEventArgs e)
        {
            OnKeyUp(e.Key);
        }

        private void OpenTKKeyDown(object sender, OpenTK.Input.KeyboardKeyEventArgs e)
        {
            OnKeyDown(e.Key);
        }


        private KeyboardDevice _keyboard;
    }
}
