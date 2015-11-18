if "%running%"=="" goto :EOF
echo searching...
for /F "tokens=*" %%f in (%fileList%) do (
		if not exist "%fileLocaton%\%%f" (
			set filesFlag=false
			goto :EOF
		)
	)
echo searching copmlete