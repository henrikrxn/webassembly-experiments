using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;

Console.WriteLine("Hello, Browser!");

public partial class MyBrowserClass
{
    [JSExport]
    internal static string BrowserHello()
    {
        var text = $"Hello, World! from {GetHRef()} on {RuntimeInformation.OSArchitecture}";
        Console.WriteLine(text);
        return text;
    }

    [JSImport("window.location.href", "main.js")]
    internal static partial string GetHRef();
}
