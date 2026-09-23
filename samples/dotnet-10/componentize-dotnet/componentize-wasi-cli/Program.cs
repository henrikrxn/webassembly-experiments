using System;
using System.Runtime.InteropServices;

Console.WriteLine("Hello world from componentize-dotnet!");

Console.WriteLine($"OS Description       : {RuntimeInformation.OSDescription}");
Console.WriteLine($"OS Architecture      : {RuntimeInformation.OSArchitecture}");
Console.WriteLine($"Framework Description: {RuntimeInformation.FrameworkDescription}");
Console.WriteLine($"Runtime Identifier   : {RuntimeInformation.RuntimeIdentifier}");
