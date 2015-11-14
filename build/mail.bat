if "%running%"=="" goto :EOF


if %cloneFlag%==false set message=Cloning failed
 goto :mail
if %buildFlag%==false set message=Build failed

	
:mail

%programPath%\mailsend1.18.exe -to %receiver% -from %sender% -ssl -port 465 -auth -smtp %smtp% -sub "%message%" +cc +bc -v -user %user% -pass %pass% -attach %attach%