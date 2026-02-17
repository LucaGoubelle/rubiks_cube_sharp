namespace SharpCube;

public class CubePrinter
{
    private Dictionary<string, string> hmap;

    public CubePrinter()
    {
        this.hmap = new Dictionary<string, string>();
        this.hmap["green"] = "\x1b[42m \x1b[0m";
        this.hmap["red"] = "\x1b[41m \x1b[0m";
        this.hmap["yellow"] = "\x1b[43m \x1b[0m";
        this.hmap["blue"] = "\x1b[44m \x1b[0m";
        this.hmap["orange"] = "\x1b[45m \x1b[0m";
        this.hmap["white"] = "\x1b[47m \x1b[0m";
    }

    public void PrintCube(Cube cube)
    {
        string content = "";
        foreach(List<string> row in cube.Up)
            content += this.genRowUpDown(row);
        for(int i=0;i<cube.Front.Count;i++)
            content += this.genRowLFRB(cube.Left[i], cube.Front[i], cube.Right[i], cube.Back[i]);
        foreach(List<string> row in cube.Down)
            content += this.genRowUpDown(row);
        Console.WriteLine(content);  
    }

    private string genRowUpDown(List<string> row)
    {
        string content = "";
        for(int i = 0; i < row.Count; i++)
            content += " ";
        foreach(string elem in row)
            content += this.hmap[elem];
        content += "\n";
        return content;
    }

    private string genRowLFRB(List<string> rowL, List<string> rowF, List<string> rowR, List<string> rowB)
    {
        string content = "";
        foreach(string elem in rowL)
            content += this.hmap[elem];
        foreach(string elem in rowF)
            content += this.hmap[elem];
        foreach(string elem in rowR)
            content += this.hmap[elem];
        foreach(string elem in rowB)
            content += this.hmap[elem];
        content += "\n";
        return content;
    }

}