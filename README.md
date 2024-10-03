# Щиголь Андрій Андрійович ІМ-23

# How to test

To start game with one command use this in powershell:

git clone https://github.com/1Laggy1/Game_of_Life.git; winget install Microsoft.DotNet.SDK.8; cd Game_of_Life\bin\Debug\net8.0\; ./GameOfLife.exe

For testing:

git clone https://github.com/1Laggy1/Game_of_Life.git; cd Game_of_Life; winget install Microsoft.DotNet.SDK.8; dotnet restore; dotnet test


# Game_of_Life

Typical game of life on C#.
Could be made with much easier code if I know details of the rules of this game earlier.

# How to play

Download source code, go to bin/net8.0/Debug place input.exe file and write there your input in this format:

[generations] [xValue(colums)] [yValue(rows)]



...+...

..+.+..

...+...

