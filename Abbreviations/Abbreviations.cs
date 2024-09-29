public class Abbreviations
{
    private Dictionary<string, string> _dictKorean = new Dictionary<string, string>();
    private Dictionary<string, string> _dictEnglish = new Dictionary<string, string>();

    // constructor
    public Abbreviations()
    {
        var lines = File.ReadAllLines("abbreviations.txt");
        _dictKorean = lines.Select(line => line.Split(new[] {':','='}))
                     .ToDictionary(x => x[0], x => x[2]);
        _dictEnglish = lines.Select(line => line.Split(new[] {':','='}))
                     .ToDictionary(x => x[0], x => x[1]);
    }

    // add element
    public void AddKorean(string abbr, string korean)
    {
        _dictKorean[abbr] = korean;
    }
    public void AddEnglish(string abbr, string english)
    {
        _dictEnglish[abbr] = english;
    }

    // indexer: abbreviation as a key
    public string this[string abbr]
    {
        get
        {
            return _dictKorean.ContainsKey(abbr) ? _dictKorean[abbr] : null;
        }
    }

    public string ToAbbreviation(string korean)
    {
        return _dictKorean.FirstOrDefault(x => x.Value == korean).Key;
    }

    public IEnumerable<KeyValuePair<string, string>> FindAllKorean(string substring)
    {
        foreach (var item in _dictKorean)
        {
            if (item.Value.Contains(substring))
                yield return item;
        }
    }
}