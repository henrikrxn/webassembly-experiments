# Pre-requisites

* emscripten

# How to build

Giver import (og for mange export)

```powershell
PS> emcc .\calculator.c -s SIDE_MODULE=1 -o calculator-in-c.wasm
```

Giver for mange export, mne ingen import

emcc .\calculator.c --no-entry -o calculator-in-c.wasm

Giver færrest exports og mindste størrelse

 emcc .\calculator.c --no-entry -v -O3 -o calculator-in-c-js.js -s STANDALONE_WASM

 Giver allermindste størrelse, men nye navne til exports

 emcc .\calculator.c --no-entry -v -O3 -o calculator-in-c-js.js