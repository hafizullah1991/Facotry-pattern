using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Threewheeler : IVehicle
    {
     
        public void Drive()
        {
            Console.WriteLine("Threewheeler is too big !");
        }
    }
}
