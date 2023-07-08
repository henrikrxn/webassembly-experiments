using Wasmtime;

using var engine = new Engine();
using var module = Module.FromTextFile(engine, "add.wat");
using var store = new Store(engine);

var instance = new Instance(store, module, Array.Empty<object>());

var add = instance.GetFunction<int, int, int>("add");

if (add is null)
{
    Console.WriteLine("Failed to load function add");
    Environment.Exit(1);
}

Console.WriteLine($"add(27, 6) = {add(27, 6)}");
