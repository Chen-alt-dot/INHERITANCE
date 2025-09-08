using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Default
{
    class Gadget
    {
        public string size;

        public Gadget()
        {
            size = "Big";
        }
        public void DisplaySpeaker()
        {
            Console.WriteLine("Size: " + size);
        }

    }
    class BluetoothSpeaker : Gadget
    {
        public string brand;

        public BluetoothSpeaker()
        {
            brand = "Panasonic";
        }
        public void DisplayBluetooth()
        {
            Console.WriteLine("Brand: " + brand);
        }
    }
}

