using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicles
{
    //child(type) of vehicles
    internal class Car : Vehicles
    {
        string CarColor;
        public Car()
        {
            RentelPrice = 500;
        }
        
    }
}
