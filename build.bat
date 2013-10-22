@echo off
echo Please enter target .Net Framework version(v2.0, v3.5, v4.0):
set /p version=
set msbuild=%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
%msbuild% EmailSender.sln /t:rebuild /p:Configuration=Release;Platform="Any CPU";TargetFrameworkVersion=%version%;OutputPath=bin\%version%\Release /fl /flp:logfile=msbuild-errors.log;errorsonly
pause