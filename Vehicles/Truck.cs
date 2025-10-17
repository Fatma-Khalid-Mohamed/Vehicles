using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicles
{   
    //child(type) of vehicles
    internal class Truck : Vehicles
    {
        string TruckColor;

        public Truck()
        {
            RentelPrice = 1000;
        }
    }
}
