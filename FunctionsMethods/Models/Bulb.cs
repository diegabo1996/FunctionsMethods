using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsMethods.Models
{
    public class Bulb
    {
        private string Color { get; set; }
        private byte Watts { get; set; }
        private byte Voltage { get; set; }
        private bool State { get; set; }

        //Method
        private void TurnOn()
        {
            State = true;
            Color = "Amarillo";
            Voltage = 220;
            Watts = 100;
        }
        //Method
        private void TurnOff()
        {
            State = false;
            Color = "Ninguno";
            Voltage = 0;
            Watts = 0;
        }
        //Method
        public void PressSwitch()
        {
            if (State == true)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
        //Function
        public bool StateBulb()
        {
            return State;
        }
        public byte WattsBulb()
        { 
            return Watts; 
        }
        public byte VoltageBulb()
        { 
            return Voltage; 
        }
        public string ColorBulb()
        {
            return Color;
        }
    }
}
