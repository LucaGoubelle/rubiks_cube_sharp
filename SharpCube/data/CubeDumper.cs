namespace SharpCube.data;

public class CubeDumper
{
    public string Dump(Cube cube)
    {
        string content = "{\n";
        content += "\"back\": "+this.DumpFace(cube.Back)+",\n";
        content += "\"up\": "+this.DumpFace(cube.Up)+",\n";
        content += "\"front\": "+this.DumpFace(cube.Front)+",\n";
        content += "\"left\": "+this.DumpFace(cube.Left)+",\n";
        content += "\"right\": "+this.DumpFace(cube.Right)+",\n";
        content += "\"down\": "+this.DumpFace(cube.Down);
        content += "\n}\n";
        return content;
    }

    private string DumpFace(List<List<string>> face)
    {
        string content = "[\n";
        foreach(List<string> row in face)
        {
            content += "\t[";
            foreach(string elem in row)
                content += "\""+elem+"\",";
            content = content.Remove(content.Length-1);
            content += "],\n";
        }
        content = content.Remove(content.Length-1);
        content = content.Remove(content.Length-1);
        content += "\n]";
        return content;   
    }
}