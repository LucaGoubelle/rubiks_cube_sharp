namespace SharpCube.data;

public class DSVSaveHandler
{
    private string DumpFace(List<List<string>> face)
    {
        string content = "";
        int size = face.Count;
        for(int i=0;i<size;i++){
            for(int j=0;j<size;j++)
            {
                content += face[i][j];
                content += (j==size-1) ? "" : ",";
            }
            content += (i==size-1) ? "" : ";";
        }
        content += "\n";
        return content;
    }

    public string Dump(Cube cube, string filepath)
    {
        //todo: implement this
        string content = "";
        content += this.DumpFace(cube.Back);
        content += this.DumpFace(cube.Up);
        content += this.DumpFace(cube.Front);
        content += this.DumpFace(cube.Left);
        content += this.DumpFace(cube.Right);
        content += this.DumpFace(cube.Down);
        File.WriteAllText(filepath, content);
        return "success !";
    }

    private List<List<string>> LoadFace(string line)
    {
        List<List<string>> face = new List<List<string>>();
        string[] rows = line.Split(';');
        foreach(string row in rows)
        {
            string[] cols = row.Split(',');
            face.Add(new List<string>(cols));
        }
        return face;
    }

    public Cube Load(string filepath)
    {
        string raw = File.ReadAllText(filepath);
        string[] lines = raw.Split('\n');
        return new Cube(
            this.LoadFace(lines[0]),
            this.LoadFace(lines[1]),
            this.LoadFace(lines[2]),
            this.LoadFace(lines[3]),
            this.LoadFace(lines[4]),
            this.LoadFace(lines[5])
        );
    }

}