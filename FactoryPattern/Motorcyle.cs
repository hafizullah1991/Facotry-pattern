using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcyle : IVehicle
    {
       

        public void Drive()
        {
            Console.WriteLine("The motorcyle is revving up!");
            Console.WriteLine("vrooooooo");
        }
    }
   
}
