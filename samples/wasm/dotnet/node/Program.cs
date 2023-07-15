using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;

Console.WriteLine($"Hello, Console! on {RuntimeInformation.OSArchitecture}");

return 0;

public partial class MyClass
{
    [JSExport]
    internal static string Greeting()
    {
        var text = $"Hello, World! Greetings from node version: {GetNodeVersion()} on {RuntimeInformation.OSArchitecture}";
        return text;
    }

    [JSImport("node.process.version", "main.mjs")]
    internal static partial string GetNodeVersion();
}
