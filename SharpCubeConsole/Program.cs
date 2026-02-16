// See https://aka.ms/new-console-template for more information
using SharpCube;
CubeBuilder builder = new CubeBuilder();
Cube cube = builder.Build(3);
Console.WriteLine(cube.Front[0][0]);

