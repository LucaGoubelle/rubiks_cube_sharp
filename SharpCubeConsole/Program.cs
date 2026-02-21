// See https://aka.ms/new-console-template for more information
using SharpCube.data;
using SharpCube.display;
using SharpCube.moves;

CubeBuilder builder = new CubeBuilder();
CubePrinter printer = new CubePrinter();
CubeMover mover = new CubeMover();

Cube cube = builder.Build(3);
printer.PrintCube(cube);
cube = mover.SimpleMove(cube, "L2");
printer.PrintCube(cube);
