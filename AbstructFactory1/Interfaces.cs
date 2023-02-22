namespace Lab_2;

public interface IChair {
    public void PrintInfo();
}

public interface ISofa {
    public void PrintInfo();
}


public abstract class ITable {
    public abstract void PrintInfo();
}

public interface IAbstractFactory {
    public IChair CreateChair();
    public ISofa CreateSofa();
    public ITable CreateTable();
}