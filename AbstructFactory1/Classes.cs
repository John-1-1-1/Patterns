namespace Lab_2;

#region Victorian

public class VictorianChair: IChair {
    public void PrintInfo() => Console.WriteLine("VictorianChair");
}

public class VictorianSofa: ISofa {
    public void PrintInfo() => Console.WriteLine("VictorianSofa");
}

public class VictorianTable : ITable {
    public override void PrintInfo() => Console.WriteLine("VictorianTable");
}

class VictorianFactory: IAbstractFactory {
    public IChair CreateChair() => new VictorianChair();
    public ISofa CreateSofa() => new VictorianSofa();
    public ITable CreateTable() => new VictorianTable();
}

#endregion

#region Modern

public class ModernChair: IChair {
    public void PrintInfo() => Console.WriteLine("ModernChair");
}

public class ModernSofa: ISofa {
    public void PrintInfo() => Console.WriteLine("ModernSofa");
}

public class ModernTable : ITable {
    public override void PrintInfo() => Console.WriteLine("ModernTable");
}

class ModernFactory: IAbstractFactory {
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
    public ITable CreateTable() => new ModernTable();
}

#endregion

#region ArDeco

public class ArDecoChair: IChair {
    public void PrintInfo() => Console.WriteLine("ArDecoChair");
}

public class ArDecoSofa: ISofa {
    public void PrintInfo() => Console.WriteLine("ArDecoSofa");
}

public class ArDecoTable : ITable {
    public override void PrintInfo() => Console.WriteLine("ArDecoTable");
}

class ArDecoFactory: IAbstractFactory {
    public IChair CreateChair() => new ArDecoChair();
    public ISofa CreateSofa() => new ArDecoSofa();
    public ITable CreateTable() => new ArDecoTable();
}

#endregion

public class Client {
    private IAbstractFactory _factory;
    public Client(IAbstractFactory factory) => _factory = factory;
    
    public IAbstractFactory Factory {
        get => _factory;
        set => _factory = value;
    }
    
}