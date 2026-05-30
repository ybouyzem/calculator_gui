# WinForms Calculator

A Windows Forms calculator application built with C# and .NET 8.

## Requirements

- Windows 10 or 11
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (optional, for editing)

## How to Build and Run

### Option 1 - Double-click the batch file (easiest)
1. Double-click `BUILD_AND_RUN.bat`
2. It will build the project and offer to run it

### Option 2 - Command line
```
cd Calculator
dotnet run
```

### Option 3 - Visual Studio
1. Open `Calculator.sln` in Visual Studio 2022
2. Press F5 to build and run

## Project Structure

```
Calculator/
├── Calculator.sln              <- Solution file (open in Visual Studio)
├── BUILD_AND_RUN.bat           <- One-click build script
└── Calculator/
    ├── Calculator.csproj       <- Project configuration
    ├── Program.cs              <- App entry point
    ├── Form1.cs                <- Calculator logic (event handlers)
    └── Form1.Designer.cs       <- UI layout (all controls defined here)
```

## Features

| Button | Function |
|--------|----------|
| 0–9    | Enter digits |
| + - * / | Basic arithmetic operators |
| =      | Compute result |
| C      | Clear everything |
| ⌫      | Delete last digit |
| +/-    | Toggle positive/negative |
| %      | Percentage of first number |
| √      | Square root |
| .      | Decimal point |

## Controls Used (WinForms Toolbox Elements)

- **TextBox** — display screen (read-only, right-aligned)
- **Button** — all calculator keys (digit, operator, utility)
- **Label** — title bar label
- **Form** — main application window

## Notes

- Operator chaining works: `5 + 3 * 2` evaluates left to right (like a basic calculator, not math precedence)
- Division by zero shows "Error" instead of crashing
- Square root of negative shows "Error"
