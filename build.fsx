// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------

#r @"packages/FAKE/tools/FakeLib.dll"

open Fake
open Fake.FscHelper

let SiteDir         = "./site/"
let BuildDir        = "./build/"
let WebServerFiles  = [SiteDir + "900.webserver.fsx"]
let WebServerExe    = BuildDir + "webserver.exe"

Target "Clean" <| fun _ ->
  CleanDirs [BuildDir]

Target WebServerExe <| fun _ ->
  WebServerFiles
  |> Fsc (fun p ->
    { p with  Output      = WebServerExe
              FscTarget   = Exe
              OtherParams = ["-O"; "-g"; "--standalone"]
    })

Target "Build" DoNothing

Target "All" DoNothing

"Clean"
  ==> WebServerExe
  ==> "Build"
  ==> "All"

RunTargetOrDefault "All"
