using System;
using FunctionsMethods.Models;

namespace FunctionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulb bombilla = new Bulb();

            ShowBulbData(bombilla);
            bombilla.PressSwitch();
            ShowBulbData(bombilla);
            bombilla.PressSwitch();
            ShowBulbData(bombilla);

        }
        public static  void ShowBulbData(Bulb bombilla)
        {
            Console.WriteLine("Estado de Bombilla: " + bombilla.StateBulb());
            Console.WriteLine("Watts de Bombilla: " + bombilla.WattsBulb());
            Console.WriteLine("Voltage de Bombilla: " + bombilla.VoltageBulb());
            Console.WriteLine("Color de Bombilla: " + bombilla.ColorBulb());
        }
    }
}
