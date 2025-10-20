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
       private string carColor;

        public string CarColor
        {
            get
            {
                return carColor;
            }
            set
            {
                carColor = value;
            }
        }
        public Car()
        {
            RentelPrice = 500;
        }
        
    }
}
