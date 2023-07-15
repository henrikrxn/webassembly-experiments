// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

import { dotnet } from './dotnet.js'

const { setModuleImports, getAssemblyExports, getConfig } = await dotnet
    .withDiagnosticTracing(true)
    .withApplicationArgumentsFromQuery()
    .create();

const config = getConfig();
const exports = await getAssemblyExports(config.mainAssemblyName);
const x = 31;
const y = 11;

const added = exports.Calculator.Add(x, y);
console.log("Added : " + added);

const subtracted = exports.Calculator.Subtract(x, y);
console.log("Subtracted : " + subtracted);

document.getElementById('out').innerHTML = `Added: ${added}, Subtracted: ${subtracted}`;
await dotnet.run();