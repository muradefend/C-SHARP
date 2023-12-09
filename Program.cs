using abstraktfactory.Entities.Interfaces;
using abstraktfactory.Fabrics.Classes;
using abstraktfactory.Fabrics.Interfaces;

ILogisticsFactory shipFactory = new ShipFactory();
ITransport ship = shipFactory.CreateTransport();
ship.Deliver();

ILogisticsFactory truckFactory = new TruckFactory();
ITransport truck = truckFactory.CreateTransport();
truck.Deliver();