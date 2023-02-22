namespace FactoryMethod;

public interface ILogistics
{
    public void CreateTransport();
    public ITransport? Transport { get; }
}

public class SeaLogistics: ILogistics
{
    public ITransport? Transport { get; private set; }
    public void CreateTransport() => Transport = new Ship();
}

public class RoadLogistics: ILogistics
{
    public ITransport? Transport { get; private set; }
    public void CreateTransport() => Transport = new Truck();
}

public interface ITransport
{
    public void Deliver();
}

public class Ship : ITransport
{
    public void Deliver() => Console.WriteLine("Ship::Deliver");
}

public class Truck : ITransport
{
    public void Deliver() => Console.WriteLine("Truck::Deliver");
}