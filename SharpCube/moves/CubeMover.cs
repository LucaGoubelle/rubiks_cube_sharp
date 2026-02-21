namespace SharpCube.moves;

using SharpCube.data;

public class CubeMover
{
    private STDMoves stdMoves;
    private AxisMoves axisMoves;

    public CubeMover()
    {
        this.stdMoves = new STDMoves();
        this.axisMoves = new AxisMoves();
    }

    public Cube SimpleMove(Cube cube, string mv)
    {
        switch (mv)
        {
            case "U":
                cube = this.stdMoves.MoveU(cube);
                break;
            case "U'":
                cube = this.stdMoves.MoveUPrime(cube);
                break;
            case "U2":
                cube = this.stdMoves.MoveU2(cube);
                break;
            case "D":
                cube = this.stdMoves.MoveD(cube);
                break;
            case "D'":
                cube = this.stdMoves.MoveDPrime(cube);
                break;
            case "D2":
                cube = this.stdMoves.MoveD2(cube);
                break;
            case "L":
                cube = this.stdMoves.MoveL(cube);
                break;
            case "L'":
                cube = this.stdMoves.MoveLPrime(cube);
                break;
            case "L2":
                cube = this.stdMoves.MoveL2(cube);
                break;
            case "y":
                cube = this.axisMoves.MoveY(cube);
                break;
            case "y'":
                cube = this.axisMoves.MoveYPrime(cube);
                break;
            case "y2":
                cube = this.axisMoves.MoveY2(cube);
                break;
            case "x":
                cube = this.axisMoves.MoveX(cube);
                break;
            case "x'":
                cube = this.axisMoves.MoveXPrime(cube);
                break;
            case "x2":
                cube = this.axisMoves.MoveX2(cube);
                break;
            case "z":
                cube = this.axisMoves.MoveZ(cube);
                break;
            case "z'":
                cube = this.axisMoves.MoveZPrime(cube);
                break;
            case "z2":
                cube = this.axisMoves.MoveZ2(cube);
                break;
            default:
                break;
        }
        return cube;
    }

    public Cube MultiMoves(Cube cube, string mvs)
    {
        string[] mvArr = mvs.Split(' ');
        foreach(string mv in mvArr)
            cube = this.SimpleMove(cube, mv);
        return cube;
    }
    
}