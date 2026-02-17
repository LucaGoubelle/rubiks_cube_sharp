namespace SharpCube.moves;

using SharpCube.data;

public class CubeMover
{
    private STDMoves stdMoves;

    public CubeMover()
    {
        this.stdMoves = new STDMoves();
    }

    public Cube SimpleMove(Cube cube, string mv)
    {
        switch (mv)
        {
            case "U":
                return this.stdMoves.MoveU(cube);
            case "U'":
                return this.stdMoves.MoveUPrime(cube);
            case "U2":
                return this.stdMoves.MoveU2(cube);
            default:
                return cube;
        }       
    }

    public Cube MultiMoves(Cube cube, string mvs)
    {
        string[] mvArr = mvs.Split(' ');
        foreach(string mv in mvArr)
            cube = this.SimpleMove(cube, mv);
        return cube;
    }
    
}