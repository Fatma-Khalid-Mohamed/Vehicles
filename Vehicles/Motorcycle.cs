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
        private string motorcycleColor;
        public string MotorcycleColor
        {
            get
            {
                return motorcycleColor;
            }
            set
            {
                motorcycleColor = value;
            }
        }

        public Motorcycle()
        {
            RentelPrice = 200;
        }
    }
}
