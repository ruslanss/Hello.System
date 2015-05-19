#r @"packages/FAKE/tools/FakeLib.dll"
open Fake

RestorePackages()

let buildDir = "./build/"
let testDir = "./test/"
let testDlls = !!"./test/*Tests.dll"

Target "Clean" (fun _ -> CleanDir buildDir)

let buildAndLog x =
    x 
    |> MSBuildRelease buildDir "Build" 
    |> Log "AppBuild-Output: "


Target "BuildApp" (fun _ -> !! "src/**/*.fsproj" |> buildAndLog)


Target "BuildTest" (fun _ -> 
    !! "src/**/*Tests.csproj" 
    |> MSBuildDebug testDir "Build" |> Log "TestBuild-Output: ")

Target "Test" (fun _ ->
    testDlls
      |> NUnit (fun p ->
          {p with
             DisableShadowCopy = true;
             OutputFile = testDir + "TestResults.xml" })
)
Target "Default" (fun _ -> trace "Hello from FAKE")


"Clean"
    ==> "BuildApp"
    ==> "BuildTest"
    ==> "Test"
    ==> "Default"

RunTargetOrDefault "Default"