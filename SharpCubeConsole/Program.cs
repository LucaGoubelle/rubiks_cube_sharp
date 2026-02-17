// See https://aka.ms/new-console-template for more information
using SharpCube.data;
using SharpCube.display;

CubeBuilder builder = new CubeBuilder();
CubePrinter printer = new CubePrinter();
Cube cube = builder.Build(3);
printer.PrintCube(cube);
