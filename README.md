# webassembly-experiments

This repository contains experiments with WebAssembly and using it across different languages and is a bit of a mess. 

For wasm and the simple wasi case with no imports needed I am looking at a "calculator" that can add and subtract two integer. A use case could be as a plugin for computations. I chose this for several reasons:

* Fairly easy to do in wat to have a minimal reference "implementation"
* Something to compare to when it comes to "metrics" (size, number of exported functions, number of imported functions, ...)
