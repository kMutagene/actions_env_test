open System
open System.IO
open System.Text

let GITHUB_ENV = Environment.GetEnvironmentVariable("GITHUB_ENV")
File.AppendAllLines(GITHUB_ENV, [ "SCRIPT_OUTPUT=lol" ])
