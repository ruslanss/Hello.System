@echo off
cls
".nuget\NuGet.exe" "Install" "FAKE" "-OutputDirectory" "packages" "-ExcludeVersion"
"packages\FAKE\tools\Fake.exe" build.fsx
"packages\Paket.1.4.18\tools\paket" "install"
"packages\FAKE\tools\Fake.exe" build.fsx