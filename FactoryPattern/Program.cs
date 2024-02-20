using System;
using FactoryPattern;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the number of tires you want to create:");
        if (int.TryParse(Console.ReadLine(), out int wheelCount))
        {
            IVehicle vehicle = VehicleFactory.GetVehicle(wheelCount);
            if (vehicle != null)
            {
                vehicle.Drive();
            }
            else
            {
                Console.WriteLine("Invalid number of tires specified.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}