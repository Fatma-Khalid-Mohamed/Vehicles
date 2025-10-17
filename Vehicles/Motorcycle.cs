using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicles
{   
    //child(type) of vehicles
    internal class Motorcycle : Vehicles
    {
        string MotorcycleColor;

        public Motorcycle()
        {
            RentelPrice = 200;
        }
    }
}
