# What is this folder?

Experimenting with a C version of a very simple wasm file for a calculator "library" (`add` and `subtract`). Using emscripten to build.

See `..\wit` folder for the IDL.

## Pre-requisites

* emscripten

## How to set-up emscripten in a prompt

When using `Emscripten` via the `emsdk` then the path needs to be set-up in each
prompt you open before `emcc` etc. can be used.

```powershell
PS> cd <emsdk root directory>
PS> .\emsdk_env.ps1
```

## How to build

Results in import (and too many exports)

```powershell
PS> emcc .\calculator.c -s SIDE_MODULE=1 -o calculator-in-c.wasm
```

Too many exports, but no import:

```powershell
emcc .\calculator.c --no-entry -o calculator-in-c.wasm
```

Fewer exports and smaller size:

```powershell
emcc .\calculator.c --no-entry -v -O3 -o calculator-in-c-js.js -s STANDALONE_WASM=1
```

Smallest size, but new names for exports:

```powershell
emcc .\calculator.c --no-entry -v -O3 -o calculator-in-c.wasm -s STANDALONE_WASM=1
```

See https://v8.dev/blog/emscripten-standalone-wasm

```powershell
emcc .\calculator.c --no-entry -v -Oz -o calculator-in-c.wasm -sSTANDALONE_WASM=1 -sFILESYSTEM=0 -sSTRICT -sSUPPORT_ERRNO=0 -sVERBOSE=1
```

`--no-entry` to tell the compiler that there is no main (shouldn't that be obvious from -s STANDALONE_WASM=1 ?)
`-s SUPPORT_ERRNO=0` to get rid of the unneeded export `__errno_location`
`-s STANDALONE_WASM=1` for running outside of browser, see https://v8.dev/blog/emscripten-standalone-wasm
`-s FILESYSTEM=0` for disabling bundling of filesystem support code, see https://emscripten.org/docs/optimizing/Optimizing-Code.html
`-s STRICT` ??
`-s SUPPORT_LONGJMP=0` ??
`-s DECLARE_ASM_MODULE_EXPORTS=0` ??
`-s VERBOSE=1` ??
`--closure 1` reduces size of support JavaScript code, see https://emscripten.org/docs/optimizing/Optimizing-Code.html