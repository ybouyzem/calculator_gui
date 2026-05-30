@echo off
echo ========================================
echo  Building Calculator - WinForms App
echo ========================================
echo.

REM Check if dotnet is available
where dotnet >nul 2>&1
if %errorlevel% neq 0 (
    echo ERROR: .NET SDK not found.
    echo Please download it from: https://dotnet.microsoft.com/download
    pause
    exit /b 1
)

echo .NET SDK found. Building project...
echo.

cd /d "%~dp0Calculator"
dotnet build -c Release

if %errorlevel% neq 0 (
    echo.
    echo BUILD FAILED. Check errors above.
    pause
    exit /b 1
)

echo.
echo ========================================
echo  Build successful!
echo  Executable is in:
echo  Calculator\bin\Release\net8.0-windows\
echo ========================================
echo.

REM Ask user if they want to run it
set /p run="Run the calculator now? (y/n): "
if /i "%run%"=="y" (
    start "" "Calculator\bin\Release\net8.0-windows\Calculator.exe"
)

pause
