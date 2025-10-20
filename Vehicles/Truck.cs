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
      
        private string truckColor ;
        public string TruckColor
        {
            get
            {
                return truckColor;
            }
            set
            {
                truckColor = value;
            }
        }
        public Truck()
        {
            RentelPrice = 1000;
        }
    }
}
