#region License
//
// (C) Copyright 2010 Patrick Cozzi, Deron Ohlarik, and Kevin Ring
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System;
using OpenTK.Input;

namespace OpenGlobe.Renderer
{
    public class KeyboardGL4x : Keyboard
    {
        public KeyboardGL4x(KeyboardDevice keyboard)
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
