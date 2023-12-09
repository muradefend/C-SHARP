using abstraktfactory.Entities.Classes;
using abstraktfactory.Entities.Interfaces;
using abstraktfactory.Fabrics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraktfactory.Fabrics.Classes
{
    public class TruckFactory : ILogisticsFactory
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
