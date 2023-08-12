# Pre-requisites

* emscripten

## How to set-up emscripten in a prompt

When using `Emscripten` via the `emsdk` then the path needs to be set-up in each
prompt you open before `emcc` etc. can be used.

```powershell
PS> cd <emsdk root directory>
PS> .\emsdk_env.ps1
```

## How to build

Giver import (og for mange export)

```powershell
PS> emcc .\calculator.c -s SIDE_MODULE=1 -o calculator-in-c.wasm
```

Giver for mange export, mne ingen import

emcc .\calculator.c --no-entry -o calculator-in-c.wasm

Giver færrest exports og mindste størrelse

 emcc .\calculator.c --no-entry -v -O3 -o calculator-in-c-js.js -s STANDALONE_WASM=1

 Giver allermindste størrelse, men nye navne til exports

 emcc .\calculator.c --no-entry -v -O3 -o calculator-in-c.wasm  -s STANDALONE_WASM=1
 see https://v8.dev/blog/emscripten-standalone-wasm


emcc .\calculator.c --no-entry -v -Oz -o calculator-in-c.wasm -sSTANDALONE_WASM=1 -sFILESYSTEM=0 -sSTRICT -sSUPPORT_ERRNO=0 -sVERBOSE=1

`--no-entry` to tell the compiler that there is no main (shouldn't that be obvious from -s STANDALONE_WASM=1 ?)
`-s SUPPORT_ERRNO=0` to get rid of the unneeded export `__errno_location`
`-s STANDALONE_WASM=1` for running outside of browser, see https://v8.dev/blog/emscripten-standalone-wasm
`-s FILESYSTEM=0` ??
`-s STRICT` ??
`-s SUPPORT_LONGJMP=0` ??
`-s DECLARE_ASM_MODULE_EXPORTS=0` ??