@echo off
cls
".paket\paket" outdated
".paket\paket" update
"packages\FAKE\tools\Fake.exe" build.fsx