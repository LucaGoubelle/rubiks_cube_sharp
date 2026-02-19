namespace SharpCube.moves;

using SharpCube.data;

public class AxisMoves
{
    public Cube MoveY(Cube cube)
    {
        cube.Up = RotateHelpers.Rotate(cube.Up);
        cube.Down = RotateHelpers.RotateAsync(cube.Down);

        List<List<string>> newFront = RotateHelpers.CopyFace(cube.Right);
        List<List<string>> newBack = RotateHelpers.CopyFace(cube.Left);
        List<List<string>> newRight = RotateHelpers.CopyFace(cube.Back);
        List<List<string>> newLeft = RotateHelpers.CopyFace(cube.Front);

        cube.Front = RotateHelpers.Transfert(cube.Front, newFront);
        cube.Right = RotateHelpers.Transfert(cube.Right, newRight);
        cube.Back = RotateHelpers.Transfert(cube.Back, newBack);
        cube.Left = RotateHelpers.Transfert(cube.Left, newLeft);

        return cube;
    }

    public Cube MoveYPrime(Cube cube)
    {
        for(int i=0;i<3;i++)
            cube = this.MoveY(cube);
        return cube;
    }

    public Cube MoveY2(Cube cube)
    {
        for(int i=0;i<2;i++)
            cube = this.MoveY(cube);
        return cube;
    }

    public Cube MoveX(Cube cube)
    {
        cube.Right = RotateHelpers.Rotate(cube.Right);
        cube.Left = RotateHelpers.RotateAsync(cube.Left);

        List<List<string>> newFront = RotateHelpers.CopyFace(cube.Down);
        List<List<string>> newUp = RotateHelpers.CopyFace(cube.Front);
        List<List<string>> newBack = RotateHelpers.RotateTwice(RotateHelpers.CopyFace(cube.Up));
        List<List<string>> newDown = RotateHelpers.RotateTwice(RotateHelpers.CopyFace(cube.Back));

        cube.Front = RotateHelpers.Transfert(cube.Front, newFront);
        cube.Up = RotateHelpers.Transfert(cube.Up, newUp);
        cube.Back = RotateHelpers.Transfert(cube.Back, newBack);
        cube.Down = RotateHelpers.Transfert(cube.Down, newDown);

        return cube;
    }

    public Cube MoveXPrime(Cube cube)
    {
        for(int i=0;i<3;i++)
            cube = this.MoveX(cube);
        return cube;
    }

    public Cube MoveX2(Cube cube)
    {
        for(int i=0;i<2;i++)
            cube = this.MoveX(cube);
        return cube;
    }

    public Cube MoveZ(Cube cube)
    {
        cube.Front = RotateHelpers.Rotate(cube.Front);
        cube.Back = RotateHelpers.RotateAsync(cube.Back);

        List<List<string>> newUp = RotateHelpers.Rotate(RotateHelpers.CopyFace(cube.Left));
        List<List<string>> newRight = RotateHelpers.Rotate(RotateHelpers.CopyFace(cube.Up));
        List<List<string>> newLeft = RotateHelpers.Rotate(RotateHelpers.CopyFace(cube.Down));
        List<List<string>> newDown = RotateHelpers.Rotate(RotateHelpers.CopyFace(cube.Right));

        cube.Up = RotateHelpers.Transfert(cube.Up, newUp);
        cube.Right = RotateHelpers.Transfert(cube.Right, newRight);
        cube.Left = RotateHelpers.Transfert(cube.Left, newLeft);
        cube.Down = RotateHelpers.Transfert(cube.Down, newDown);

        return cube;
    }

    public Cube MoveZPrime(Cube cube)
    {
        for(int i=0;i<3;i++)
            cube = this.MoveZ(cube);
        return cube;
    }

    public Cube MoveZ2(Cube cube)
    {
        for(int i=0;i<2;i++)
            cube = this.MoveZ(cube);
        return cube;
    }
    
}
