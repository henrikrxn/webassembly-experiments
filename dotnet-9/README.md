# No wasi-experimental support in .NET 9

As it, per this [issue](https://github.com/dotnet/runtime/pull/108877), seems there will be no `wasi-experimental` in .NET 9 RTM only projects using [componentize-dotnet](https://www.nuget.org/packages/BytecodeAlliance.Componentize.DotNet.Wasm.SDK/0.4.0-preview00007) will work / will be updated.

The PR was merged well after .NET 9 was RTM and this seems to have broken projects using componentize-dotnet as well so deleted all projects.