# Calculator in WebAssembly Text Format (WAT)

Tools used:

- WebAssembly Binary Toolkit (wabt) 1.0.33
- Wasmtime runtime 11.0.1

## Compiling WAT to a WASM file

wat2wasm is part of the WebAssembly Binary Toolkit

```powershell
PS> wat2wasm calculator.wat -o wat-calculator.wasm
```

## Executing using wasmtime

```powershell
PS> wasmtime .\wat-calculator.wasm --invoke add 31 11
PS> wasmtime .\wat-calculator.wasm --invoke subtract 31 11
```
