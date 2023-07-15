using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;

Console.WriteLine($"Hello, Browser from {nameof(Calculator)}");

public partial class Calculator
{
    [JSExport]
    internal static int Add(int x, int y) => x + y;

    [JSExport]
    internal static int Subtract(int x, int y) => x - y;
}
