using Wasmtime;

using var engine = new Engine();
using var module = Module.FromTextFile(engine, "add.wat");
using var store = new Store(engine);

var instance = new Instance(store, module, Array.Empty<object>());