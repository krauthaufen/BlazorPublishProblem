# Blazor WebAssembly Publish Problem

Steps to reproduce the error:

1. run `build.cmd`
2. goto `BlazorPublishProblem\BlazorPublishProblem\bin\Release\net6.0\publish` and start a webserver in `wwwroot`
3. open the served page in browser

Error will be something like: 

```
Uncaught (in promise) Error: Could not find assembly: Microsoft.AspNetCore.Components.WebAssembly
    at Object.resolve_method_fqn (dotnet.6.0.0-rc.2.21480.5.cz4thm6byj.js:1)
    at Object.bind_static_method (dotnet.6.0.0-rc.2.21480.5.cz4thm6byj.js:1)
    at qe (blazor.webassembly.js:1)
    at blazor.webassembly.js:1
    at blazor.webassembly.js:1
    at callRuntimeCallbacks (dotnet.6.0.0-rc.2.21480.5.cz4thm6byj.js:1)
    at postRun (dotnet.6.0.0-rc.2.21480.5.cz4thm6byj.js:1)
    at doRun (dotnet.6.0.0-rc.2.21480.5.cz4thm6byj.js:1)
    at run (dotnet.6.0.0-rc.2.21480.5.cz4thm6byj.js:1)
    at runCaller (dotnet.6.0.0-rc.2.21480.5.cz4thm6byj.js:1)
```