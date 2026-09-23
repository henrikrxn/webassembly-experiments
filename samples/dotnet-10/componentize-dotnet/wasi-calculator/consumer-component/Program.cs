using HostappWorld.wit.Imports.example.calculator;

var x = 456;
var y = 123;
var added = IOperationsImports.Add(x, y);
Console.WriteLine($"{x} + {y} = {added}");

var subtracted = IOperationsImports.Subtract(x, y);
Console.WriteLine($"{x} - {y} = {subtracted}");
