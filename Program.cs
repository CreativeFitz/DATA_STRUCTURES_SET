using System;
using System.Collections.Generic;

namespace Chapter6_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showroom = new HashSet<string>(){
                "Focus", "Mustang", "RX-8", "Mazda 3"
            };

            foreach(string car in showroom){
                Console.WriteLine($"{car}");
            }

            showroom.Add("Mazda 3");

            Console.WriteLine("---------------------------------");

            foreach(string car in showroom){
                Console.WriteLine($"{car}");
            };

            HashSet<string> usedCars = new HashSet<string>(showroom){
                "F150", "Viper"
            };


            List<string> multipleCars = new List<string>(){
                "Viper", "Viper", "F150", "F150", "Mustang", "Camaro"
            };

            HashSet<string> movedshowroom = new HashSet<string>(multipleCars);
            movedshowroom.UnionWith(showroom);

            Console.WriteLine("--------------------------------------");

            movedshowroom.Remove("Mazda 3");

            foreach(string car in movedshowroom){
                Console.WriteLine($"{car}");
            };

            HashSet<string> clone = new HashSet<string>(movedshowroom);

            HashSet<string> junkyard = new HashSet<string>(){
                "Bronco", "Viper", "Altima", "Maxima", "Mustang"
            };

            clone.IntersectWith(junkyard);

                Console.WriteLine("-------------------------------");

            foreach(string car in movedshowroom){
                Console.WriteLine($"{car}");
            };

            junkyard.UnionWith(movedshowroom);

            foreach(string car in movedshowroom){
                Console.WriteLine($"{car}");
            };







        }
    }
}
