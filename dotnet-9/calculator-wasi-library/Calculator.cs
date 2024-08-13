using System.Runtime.InteropServices;

namespace CalculatorWasiLibrary;

public unsafe class Calculator
{
    [UnmanagedCallersOnly(EntryPoint = "helloWorld")]
    public static void HelloWorld()
    {
        System.Console.WriteLine("Hello World!");
    }

    [UnmanagedCallersOnly(EntryPoint = "add")]
    public static int Add(int x, int y)
    {
        return x + y;
    }

    [UnmanagedCallersOnly(EntryPoint = "subtract")]
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
}
