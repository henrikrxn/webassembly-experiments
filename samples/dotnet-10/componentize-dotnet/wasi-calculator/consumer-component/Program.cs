using HostappWorld.wit.imports.example.calculator;

var x = 456;
var y = 123;
var added = OperationsInterop.Add(x, y);
Console.WriteLine($"{x} + {y} = {added}");

var subtracted = OperationsInterop.Subtract(x, y);
Console.WriteLine($"{x} - {y} = {subtracted}");
