namespace ComputerWorld.wit.Exports.example.calculator;

public class OperationsExportsImpl : IOperationsExports
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }
}