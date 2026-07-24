# HelloApp - FizzBuzz Console Application

## Overview

This is a simple C# .NET Console Application developed as part of a Git and GitHub exercise.

The application:
- Prints the author's name
- Prints today's date
- Executes the FizzBuzz logic for numbers 1 through 20

## Features

### Name and Date Display
The program displays:
- Name: Kirtan Khare
- Current Date

### FizzBuzz Function
For numbers from 1 to 20:
- Prints "Fizz" for numbers divisible by 3
- Prints "Buzz" for numbers divisible by 5
- Prints "FizzBuzz" for numbers divisible by both 3 and 5
- Otherwise prints the number itself

## Prerequisites

- .NET SDK 8.0 or later
- Visual Studio 2022 or Visual Studio Code

## How to Run the Application

### Clone the Repository

```bash
git clone <repository-url>
```

### Navigate to the Project Directory

```bash
cd HelloApp
```

### Build the Project

```bash
dotnet build
```

### Run the Application

```bash
dotnet run
```

## Sample Output

```text
Name: Kirtan Khare
Today's Date: 24-07-2026

1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
17
Fizz
19
Buzz
```

## Project Structure

```text
HelloApp
│
├── Program.cs
├── HelloApp.csproj
├── .gitignore
└── README.md
```

## Git Workflow

1. Cloned the repository from GitHub.
2. Created the branch `exercise/hello`.
3. Created a .NET Console Application.
4. Implemented the FizzBuzz function.
5. Added a `.gitignore` file to exclude Visual Studio and .NET build artifacts (`bin/`, `obj/`, `.vs/`).
6. Committed and pushed changes to GitHub.
7. Opened a Pull Request from `exercise/hello` to `main`.

## Author

**Kirtan Khare**
