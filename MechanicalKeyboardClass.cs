using KeyboardClass;
using MechanicalKeyboardClass;
using System;

namespace MechanicalKeyboardClass
{
    public class MechanicalKeyboard : Keyboard
    {
        public string Switches { get; set; }

        public int KeyAmount { get; set; }

        public string RGBBacklight { get; set; }

    }
}