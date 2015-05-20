@echo off
cls
"packages\Paket.1.4.18\tools\paket" "install"
"packages\FAKE\tools\Fake.exe" build.fsx
pause