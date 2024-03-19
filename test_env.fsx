open System
open System.IO
open System.Text

let GITHUB_ENV = Environment.GetEnvironmentVariable("GITHUB_ENV")
File.AppendAllLines(GITHUB_ENV, [ "SCRIPT_OUTPUT=lol" ])

printfn "env : %s" GITHUB_ENV
printfn $"vals : {File.ReadAllText(GITHUB_ENV)}" 
