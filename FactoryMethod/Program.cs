

using FactoryMethod;

ILogistics logistics = new RoadLogistics();
logistics.CreateTransport();
logistics.Transport?.Deliver();

logistics = new SeaLogistics();
logistics.CreateTransport();
logistics.Transport?.Deliver();