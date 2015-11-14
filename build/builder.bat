@echo off

set running=true


call settings.bat

call clean.bat

echo.


call clone.bat

if %cloneFlag%==false goto :mail


call build.bat

if %buildFlag%==false goto :mail


call find.bat


:mail

call mail.bat


pause