// See https://aka.ms/new-console-template for more information
using SharpCube.data;
using SharpCube.display;

CubeBuilder builder = new CubeBuilder();
CubePrinter printer = new CubePrinter();
DSVSaveHandler dsvSave = new DSVSaveHandler();

Cube cube = builder.Build(3);
printer.PrintCube(cube);
dsvSave.Dump(cube, "../res/test.dsv");
cube = dsvSave.Load("../res/test.dsv");
printer.PrintCube(cube);
