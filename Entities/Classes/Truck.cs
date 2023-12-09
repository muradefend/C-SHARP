using abstraktfactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraktfactory.Entities.Classes
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by land in a box.");
        }
    }
}
