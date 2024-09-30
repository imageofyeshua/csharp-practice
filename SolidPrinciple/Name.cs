public class Names
{
    private List<string> _names = new List<string>();

    public void AddName(string name)
    {
        if (IsValidName(name))
        {
            _names.Add(name);
        }
    }

    private bool IsValidName(string name)
    {
        return name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }

    public void ReadFromTextFile()
    {
        var fileContents = File.ReadAllText(BuildFilePath());
        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        foreach (var name in namesFromFile)
        {
            AddName(name);
        }
    }

    public void WriteToTextFile()
    {
        File.WriteAllText(BuildFilePath(), Format());
    }

    public string BuildFilePath()
    {
        return "names.txt";
    }

    public string Format()
    {
        return string.Join(Environment.NewLine, _names);
    }
}