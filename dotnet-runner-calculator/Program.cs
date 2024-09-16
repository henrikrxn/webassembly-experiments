using Wasmtime;

// TODO Turn this into a WASI calculator tester

// 0) Rename folder and project -> dotnet-wasi-calculator-runner
// 1) Move this to the wasi folder
// 2) Add script to copy the different WASI (wasm) files to output folder
// 3) Maybe use tree in Spectre.Console to be able to pick the WASI (wasm) file to run
// 4) Share 3) with the wasm-runner

var executingAssemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location ?? throw new NullReferenceException("Executing assembly should have a location");
var executionDirectory = Path.GetDirectoryName(executingAssemblyLocation) ?? throw new NullReferenceException("Execution directory could not be determined");
var pathToWasmFile = Path.Combine(executionDirectory, "calculator-in-go.wasm") ?? throw new NullReferenceException("Path to wasm file could not be determined");

using Engine engine = new();

using var module = Module.FromFile(engine, pathToWasmFile);

using var store = new Store(engine);
var wasiConfiguration = new WasiConfiguration()
    .WithInheritedStandardOutput();
store.SetWasiConfiguration(wasiConfiguration);

using var linker = new Linker(engine);
linker.DefineWasi();

var instance = linker.Instantiate(store, module);
// new Instance(store, module, Array.Empty<object>());

var add = instance.GetFunction<int, int, int>("add");

if (add is null)
{
    Console.WriteLine("Failed to load function add");
    Environment.Exit(1);
}

var x = 31;
var y = 11;

Console.WriteLine($"add({x}, {y}) = {add(x, y)}, should be {x + y}");

var subtract = instance.GetFunction<int, int, int>("subtract");

if (subtract is null)
{
    Console.WriteLine("Failed to load function subtract");
    Environment.Exit(1);
}

Console.WriteLine($"subtract({x}, {y}) = {subtract(x, y)}, should be {x - y}");