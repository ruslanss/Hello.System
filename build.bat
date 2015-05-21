@echo off
cls
".paket\paket" outdated
".paket\paket" update -f
"packages\FAKE\tools\Fake.exe" build.fsx