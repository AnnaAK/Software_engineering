if "%running%"=="" goto :EOF


echo cloning...

git clone -b test %repositoryURL% %repositoryPath% >> log.txt 2>&1

if ERRORLEVEL 1 (
	set cloneFlag=false
	goto :EOF
	)
echo clone complete