namespace SharpCube.data;

public class CubeBuilder
{
    private List<List<string>> BuildFace(int size, string elem)
    {
        List<List<string>> face = new List<List<string>>();
        for(int i = 0; i < size; i++)
        {
            List<string> row = new List<string>();
            for(int j=0; j < size; j++)
            {
                row.Add(elem);   
            }
            face.Add(row);
        }
        return face;
    }

    public Cube Build(int size)
    {
        return new Cube(
            this.BuildFace(size, "green"),
            this.BuildFace(size, "yellow"),
            this.BuildFace(size, "blue"),
            this.BuildFace(size, "orange"),
            this.BuildFace(size, "red"),
            this.BuildFace(size, "white")
        );
    }

}
