@echo off
cls
"packages\Paket.1.4.18\tools\paket" "update"
"packages\FAKE\tools\Fake.exe" build.fsx
pause