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

}