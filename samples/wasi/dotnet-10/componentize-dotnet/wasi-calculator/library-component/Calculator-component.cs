namespace ComputerWorld.wit.exports.example.calculator;

public class OperationsImpl : IOperations
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