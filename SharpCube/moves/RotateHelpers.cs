namespace SharpCube.moves;

public class RotateHelpers
{
    public static List<List<string>> GenEmptyFace(int size)
    {
        List<List<string>> face = new List<List<string>>();
        for(int i = 0; i < size; i++)
        {
            List<string> row = new List<string>();
            for(int j=0;j<size;j++)
                row.Add("");
            face.Add(row);
        }
        return face;
    }

    public static List<List<string>> CopyFace(List<List<string>> face)
    {
        List<List<string>> newFace = new List<List<string>>();
        for(int i = 0; i < face.Count; i++)
        {
            List<string> row = new List<string>();
            for(int j=0;j<face[i].Count;j++)
                row.Add(face[i][j]);
            face.Add(row);
        }
        return newFace;
    }

    public static List<List<string>> Rotate(List<List<string>> face)
    {
        int size = face.Count;
        List<List<string>> newFace = GenEmptyFace(size);
        for(int i = 0; i < size; i++)
        {
            int cnt = size - 1;
            for(int j = 0; j < size; j++)
            {
                newFace[i][j] = face[cnt][i];
                cnt--;
            }

        }
        return newFace;
    }

    public static List<List<string>> RotateAsync(List<List<string>> face)
    {
        for(int i=0;i<3;i++)
            face = Rotate(face);
        return face;
    }

    public static List<List<string>> RotateTwice(List<List<string>> face)
    {
        for(int i=0;i<2;i++)
            face = Rotate(face);
        return face;
    }

    public static List<List<string>> Transfert(List<List<string>> face, List<List<string>> newFace)
    {
        int size = face.Count;
        for(int i=0;i<size;i++)
            for(int j=0;j<size;j++)
                face[i][j] = (newFace[i][j]!="") ? newFace[i][j] : face[i][j];
        return face;
    }
    
}