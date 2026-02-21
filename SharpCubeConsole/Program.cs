// See https://aka.ms/new-console-template for more information
using SharpCube.data;
using SharpCube.display;
using SharpCube.moves;

CubeBuilder builder = new CubeBuilder();
CubePrinter printer = new CubePrinter();
// CubeMover mover = new CubeMover();
CubeScrambler scrambler = new CubeScrambler();

Cube cube = builder.Build(3);
printer.PrintCube(cube);
cube = scrambler.Scramble(cube);
printer.PrintCube(cube);
