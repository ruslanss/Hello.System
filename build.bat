@echo off
cls
".paket\paket" "install"
"packages\FAKE\tools\Fake.exe" build.fsx