namespace SolidPrinciple.DataAccess;
public class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();
    }

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Environment.NewLine + "-------" + Environment.NewLine, strings));
    }
}