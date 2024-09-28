namespace Dictionary
{
    public class WordsExtractor
    {
        private string[] _lines;

        public WordsExtractor(string[] lines)
        {
            _lines = lines;
        }        

        public IEnumerable<string> Extract() 
        {
            var hash = new HashSet<string>(); // HashSet object creation
            foreach (var line in _lines)
            {
                var words = GetWords(line);
                foreach (var word in words)
                {
                    if (word.Length >= 7)
                        hash.Add(word.ToLower()); // register the word to HashSet
                }
            }
            return hash.OrderBy(s => s);
        }

        private char[] _separators = @" !?"",.".ToCharArray();

        private IEnumerable<string> GetWords(string line) {
            var items = line.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                var index = item.IndexOf("'");
                var word = index <= 0 ? item : item.Substring(0, index);

                if (word.ToLower().All(c => 'a' <= c && c <= 'z'))
                    yield return word;
            }
        }
    }
}