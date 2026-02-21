namespace SharpCube.moves;

using SharpCube.data;
using SharpCube.exceptions;

public class CubeScrambler
{
    private CubeMover Mover;

    public CubeScrambler()
    {
        this.Mover = new CubeMover();
    }

    public Cube Scramble(Cube cube)
    {
        try
        {
            string[] scrambles = new string[]
            {
                "U' R2 F U F2 R U2 F' R U2 F R' F R F U2 F U' F2 R2 F2 U2 F' U2 R",
                "U F U2 R2 F R' F2 R2 F2 U R2 F' R2 U R2 F U2 F2 U2 F2 R' F' U2 F2 U2",
                "F' R2 F2 R2 U' F R U2 F R2 F R' U2 R' U F' U2 F2 U' F' R2 U' F2 U2 R2",
                "U R' F R2 F2 R' F' R2 U F' R2 U R' F2 U' R2 U' R' U' F2 R F' R2 U R'",
                "U' F' U' F' R2 F2 U' R2 U F' U2 F2 U' F U R U2 F' R F' U R' F' R' U'"
            };
            Random rnd = new Random();
            int randint = rnd.Next(scrambles.Length);
            string scrambling = scrambles[randint];
            cube = this.Mover.MultiMoves(cube, scrambling);
            return cube;
        } catch(Exception exc)
        {
            Console.WriteLine(exc.Message);
            throw new CubeScramblerException("ERR: Something failed in CubeScrambler::Scramble(Cube cube);");
        }
    }
}