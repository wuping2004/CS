ECHO The current version is %MyVersionNumber% >> "%TEMP%\StartupLog.txt" 2>&1
PowerShell -ExecutionPolicy Unrestricted .\startup.ps1 >> "%TEMP%\StartupLog.txt" 2>&1

EXIT /B 1