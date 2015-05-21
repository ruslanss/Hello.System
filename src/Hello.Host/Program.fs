// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
//
open Suave
open Suave.Http.Successful
open Suave.Web
open Greetings 

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    startWebServer defaultConfig (OK Greeter.hello)

    0 // return an integer exit code
