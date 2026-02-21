namespace SharpCube.moves;

using SharpCube.data;

public class STDMoves
{
    public Cube MoveU(Cube cube)
    {
        int size = cube.Up.Count;
        cube.Up = RotateHelpers.Rotate(cube.Up);

        List<List<string>> newFront = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newLeft = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newRight = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newBack = RotateHelpers.GenEmptyFace(size);

        for(int i = 0; i < size; i++)
        {
            newFront[0][i] = cube.Right[0][i];
            newRight[0][i] = cube.Back[0][i];
            newLeft[0][i] = cube.Front[0][i];
            newBack[0][i] = cube.Left[0][i];
        }

        cube.Front = RotateHelpers.Transfert(cube.Front, newFront);
        cube.Left = RotateHelpers.Transfert(cube.Left, newLeft);
        cube.Right = RotateHelpers.Transfert(cube.Right, newRight);
        cube.Back = RotateHelpers.Transfert(cube.Back, newBack);

        return cube;
    }

    public Cube MoveUPrime(Cube cube)
    {
        for(int i=0; i<3;i++)
            cube = MoveU(cube);
        return cube;
    }

    public Cube MoveU2(Cube cube)
    {
        for(int i=0; i<2;i++)
            cube = MoveU(cube);
        return cube;
    }
    
    public Cube MoveD(Cube cube)
    {
        int size = cube.Down.Count;
        cube.Down = RotateHelpers.Rotate(cube.Down);

        List<List<string>> newFront = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newLeft = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newRight = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newBack = RotateHelpers.GenEmptyFace(size);

        for(int i = 0; i < size; i++)
        {
            newFront[size-1][i] = cube.Left[size-1][i];
            newLeft[size-1][i] = cube.Back[size-1][i];
            newRight[size-1][i] = cube.Front[size-1][i];
            newBack[size-1][i] = cube.Right[size-1][i];
        }

        cube.Front = RotateHelpers.Transfert(cube.Front, newFront);
        cube.Left = RotateHelpers.Transfert(cube.Left, newLeft);
        cube.Right = RotateHelpers.Transfert(cube.Right, newRight);
        cube.Back = RotateHelpers.Transfert(cube.Back, newBack);

        return cube;
    }

    public Cube MoveDPrime(Cube cube)
    {
        for(int i=0;i<3;i++)
            cube = this.MoveD(cube);
        return cube;
    }

    public Cube MoveD2(Cube cube)
    {
        for(int i=0;i<2;i++)
            cube = this.MoveD(cube);
        return cube;
    }

    public Cube MoveL(Cube cube)
    {
        int size = cube.Left.Count;
        cube.Left = RotateHelpers.Rotate(cube.Left);

        List<List<string>> newUp = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newFront = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newDown = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newBack = RotateHelpers.GenEmptyFace(size);

        for(int i = 0; i < size; i++)
        {
            newFront[i][0] = cube.Up[i][0];
            newDown[i][0] = cube.Front[i][0];
            newBack[i][0] = cube.Down[i][0];
            newUp[i][size-1] = cube.Back[i][size-1];
        }

        cube.Front = RotateHelpers.Transfert(cube.Front, newFront);
        cube.Up = RotateHelpers.Transfert(cube.Up, RotateHelpers.RotateTwice(newUp));
        cube.Down = RotateHelpers.Transfert(cube.Down, newDown);
        cube.Back = RotateHelpers.Transfert(cube.Back, RotateHelpers.RotateTwice(newBack));

        return cube;
    }

    public Cube MoveLPrime(Cube cube)
    {
        for(int i=0;i<3;i++)
            cube = this.MoveL(cube);
        return cube;
    }

    public Cube MoveL2(Cube cube)
    {
        for(int i=0;i<2;i++)
            cube = this.MoveL(cube);
        return cube;
    }

    public Cube MoveR(Cube cube)
    {
        int size = cube.Right.Count;
        cube.Right = RotateHelpers.Rotate(cube.Right);

        List<List<string>> newFront = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newUp = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newBack = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newDown = RotateHelpers.GenEmptyFace(size);

        for(int i = 0; i < size; i++)
        {
            newFront[i][size-1] = cube.Down[i][size-1];
            newUp[i][size-1] = cube.Front[i][size-1];
            newBack[i][size-1] = cube.Up[i][size-1];
            newDown[i][0] = cube.Back[i][0];
        }

        cube.Front = RotateHelpers.Transfert(cube.Front, newFront);
        cube.Up = RotateHelpers.Transfert(cube.Up, newUp);
        cube.Back = RotateHelpers.Transfert(cube.Back, RotateHelpers.RotateTwice(newBack));
        cube.Down = RotateHelpers.Transfert(cube.Down, RotateHelpers.RotateTwice(newDown));

        return cube;
    }

    public Cube MoveRPrime(Cube cube)
    {
        for(int i=0;i<3;i++)
            cube = this.MoveR(cube);
        return cube;
    }

    public Cube MoveR2(Cube cube)
    {
        for(int i=0;i<2;i++)
            cube = this.MoveR(cube);
        return cube;
    }

    public Cube MoveF(Cube cube)
    {
        int size = cube.Front.Count;
        cube.Front = RotateHelpers.Rotate(cube.Front);

        List<List<string>> newUp = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newLeft = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newRight = RotateHelpers.GenEmptyFace(size);
        List<List<string>> newDown = RotateHelpers.GenEmptyFace(size);

        for(int i = 0; i < size; i++)
        {
            newUp[i][size-1] = cube.Left[i][size-1];
            newLeft[0][i] = cube.Down[0][i];
            newRight[size-1][i] = cube.Up[size-1][i];
            newDown[i][0] = cube.Right[i][0];
        }

        cube.Up = RotateHelpers.Transfert(cube.Up, RotateHelpers.Rotate(newUp));
        cube.Left = RotateHelpers.Transfert(cube.Left, RotateHelpers.Rotate(newLeft));
        cube.Right = RotateHelpers.Transfert(cube.Right, RotateHelpers.Rotate(newRight));
        cube.Down = RotateHelpers.Transfert(cube.Down, RotateHelpers.Rotate(newDown));

        return cube;
    }

    public Cube MoveFPrime(Cube cube)
    {
        for(int i=0;i<3;i++)
            cube = this.MoveF(cube);
        return cube;
    }

    public Cube MoveF2(Cube cube)
    {
        for(int i=0;i<2;i++)
            cube = this.MoveF(cube);
        return cube;
    }
    
}