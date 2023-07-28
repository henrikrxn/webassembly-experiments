using Wasmtime;

var executingAssemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location ?? throw new NullReferenceException("Executing assembly should have a location");
var executionDirectory = Path.GetDirectoryName(executingAssemblyLocation) ?? throw new NullReferenceException("Execution directory could not be determined");
var pathToWatFile = Path.Combine(executionDirectory, "calculator.wat") ?? throw new NullReferenceException("Path to wat file could not be determined");

using var engine = new Engine();
using var module = Module.FromTextFile(engine, pathToWatFile);
using var store = new Store(engine);

var instance = new Instance(store, module, Array.Empty<object>());

var add = instance.GetFunction<int, int, int>("add");

if (add is null)
{
    Console.WriteLine("Failed to load function add");
    Environment.Exit(1);
}

var x = 31;
var y = 11;

Console.WriteLine($"add({x}, {y}) = {add(x, y)}, should be {x+y}");

var subtract = instance.GetFunction<int, int, int>("subtract");

if (subtract is null)
{
    Console.WriteLine("Failed to load function subtract");
    Environment.Exit(1);
}

 Console.WriteLine($"subtract({x}, {y}) = {subtract(x, y)}, should be {x-y}");