using abstraktfactory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraktfactory.Fabrics.Interfaces
{
    public interface ILogisticsFactory
    {
        ITransport CreateTransport();
    }
}
