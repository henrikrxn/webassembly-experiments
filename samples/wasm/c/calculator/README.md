# Pre-requisites

* emscripten

# How to build

```powershell
PS> emcc .\calculator.c -s SIDE_MODULE=1 -o calculator-in-c.wasm
```