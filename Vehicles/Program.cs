using System;
using System.Collections.Generic;

namespace vehicles
{
    internal class Program
    {
       static List<Vehicles> ListOfVehicles = new List<Vehicles>();

        //1. Adding new vehicles.
        static void AddNewVehicle(Vehicles NewVehicle)
        {
            ListOfVehicles.Add(NewVehicle);
            Console.WriteLine("Vehicle Added Successfully");
        }



        //2. Viewing all vehicles.
        static void ShowingAllVehicles()
        {
            for (int i = 0; i < ListOfVehicles.Count; i++)
            {
                Console.WriteLine($"Vehicle Numer ({i}) \n" + ListOfVehicles[i]);
            }
        }



        //3.[a] Searching by brand
        static void SearchingVehicleByBrand(string b)
        {
            int flag = 0;
            for (int i = 0; i < ListOfVehicles.Count; i++)
            {
                if (ListOfVehicles[i].Brand == b)
                {
                    flag = 1;
                    Console.WriteLine(ListOfVehicles[i]);
                }
            }
            if(flag==0)
            {
                Console.WriteLine("Brand Doesn't exist");
            }
        }


        //3.[b] Searching by type
        static void SearchingVehicleByType(Vehicles VehicleType)
        {
            int flag=0;
            for (int i = 0; i < ListOfVehicles.Count; i++)
            {
                if (ListOfVehicles[i] == VehicleType)
                {
                    flag = 1;
                    Console.WriteLine(ListOfVehicles[i]);
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Vehicle Type Doesn't exist");
            }
        }



        //4. Removing a vehicle by Id.
        static void RemovingVehicleById(int id)
        {
            int flag = 0;
            for (int i = 0; i < ListOfVehicles.Count; i++)
            {
                if (ListOfVehicles[i].Id == id)
                {
                    flag = 1;
                    ListOfVehicles.Remove(ListOfVehicles[i]);
                    Console.WriteLine("Vehicle Removed Successfully");
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Vehicle Doesn't exist");
            }
        }



        private static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Brand = "toyota";
            Motorcycle m1 = new Motorcycle();
            m1.Id = 3;
            Truck t1 = new Truck();
            AddNewVehicle(c1);
            AddNewVehicle(m1);
            AddNewVehicle(t1);

            ShowingAllVehicles();

            SearchingVehicleByBrand("toyota");
            SearchingVehicleByType(t1);
            RemovingVehicleById(3);
        }
    }
}