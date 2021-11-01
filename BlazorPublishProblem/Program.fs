open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Microsoft.JSInterop
open Microsoft.JSInterop.WebAssembly
open System



let runtime = 
    let args = [| "Web"; "WebGL2" |]
    let builder = WebAssemblyHostBuilder.CreateDefault(args)

    let host = builder.Build()
    host.Services.GetService(typeof<IJSRuntime>) :?> WebAssemblyJSRuntime

    
[<EntryPoint; STAThread>]
let main _argv =
    runtime.InvokeVoid("console.log", "hi there from F#")
    0