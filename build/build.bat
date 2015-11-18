if "%running%"=="" goto :EOF


echo building...

%msbuildPath%\MSBuild.exe %repositoryPath%\%solutionPath% /p:Configuration=Release;VisualStudioVersion=11.0 >> log.txt

if ERRORLEVEL 1 set buildFlag=false
echo building complete