using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car() 
        { 
        }

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Charger";
        public int Seatcount { get; set; } = 4;
        public string CompanyName { get; set; } = "Chevy";
        public string Motto { get; set; } = "Built Chevy Heavy";

        public bool HasChangedGears { get; set; }



        public void Drive()
    {

          Console.WriteLine($"{GetType().Name} now driving forward...");

    }

    public void Reverse()
    {
            if (HasChangedGears == true) 
            {
                Console.WriteLine($"{GetType().Name} now reversing . . .");
                HasChangedGears = false;


            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        Console.WriteLine($"{GetType().Name} now driving forward...");

    }

    public void Park()
    {
        Console.WriteLine();

    }

    public void ChangeGears(bool isChanged)
    {
        HasChangedGears = isChanged;

    }


}
}
