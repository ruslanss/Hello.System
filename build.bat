@echo off
cls
@echo INSTALLED PACKAGES:
".paket\paket" show-installed-packages
@echo CHECKING FOR OUTDATED PACKAGES:
".paket\paket" outdated
@echo STARTING UPDATE
".paket\paket" update
@echo BUILDING PROJECT
"packages\FAKE\tools\Fake.exe" build.fsx