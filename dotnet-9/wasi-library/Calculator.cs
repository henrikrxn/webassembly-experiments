using System.Runtime.InteropServices;

namespace wasi_library;

public class Calculator
{
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
