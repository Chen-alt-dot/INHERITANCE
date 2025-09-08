using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Default
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Bluestooth Speaker----");
            Gadget gadget1 = new Gadget();
            gadget1.DisplaySpeaker();
            BluetoothSpeaker blue1 = new BluetoothSpeaker();
            blue1.DisplayBluetooth();

            Console.ReadKey();
        }
    }
}
