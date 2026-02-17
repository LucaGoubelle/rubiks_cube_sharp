// See https://aka.ms/new-console-template for more information
using SharpCube;

CubeBuilder builder = new CubeBuilder();
CubePrinter printer = new CubePrinter();
Cube cube = builder.Build(3);
printer.PrintCube(cube);
