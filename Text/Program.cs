using System.Globalization;
using System.Text;

public class Program
{
  public static void Main(string[] args)
  {
    var str1 = "Father";
    var str2 = "FATHER";

    if (String.Compare(str1, str2, ignoreCase: true) == 0)
      Console.WriteLine("Same Words");
    else
      Console.WriteLine("Different Words");

    var str3 = "HTML5";
    var str4 = "html5";
    var cultureInfo = new CultureInfo("ko-KR");
    var output = String.Compare(str3, str4, cultureInfo, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0;
    Console.WriteLine("It's the Same? {0}", output);

    var words = "Our Father in heaven, sanctified be Thy Name.";
    var contains = words.Contains('F');
    Console.WriteLine("Words Contains F? {0}", contains);

    var isExists = words.Any(c => Char.IsLower(c));

    var target = "23431245";
    var isAllDigits = target.All(c => Char.IsDigit(c));

    var index = words.IndexOf("Father");
    Console.WriteLine("Index of Father is {0}", index);

    var languages = new[] { "C#", "Java", "Ruby", "C++" };
    var separator = ", ";
    var result = String.Join(separator, languages);
    Console.WriteLine(result);

    var wordsArray = words.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
    foreach (var item in wordsArray)
      Console.WriteLine(item);

    // StringBuilder Example
    var sb = new StringBuilder(200);
    foreach (var word in wordsArray)
    {
      sb.Append(word);
      sb.Append(" ");
    }
    sb.Append("Thy kingdom come");

    var sbText = sb.ToString();
    Console.WriteLine(sbText);

    var str5 = "Reading Bible";
    foreach (var c in str5)
      Console.Write("[{0}]", c);
    Console.WriteLine();

    var chars = new char[] { 'A', 'b', 'b', 'a', 'F', 'a', 't', 'h', 'e', 'r' };
    var heavenlyFather = new string(chars);
    Console.WriteLine(heavenlyFather);

    var writer = "ScriptureWriter\t=\tPaul";
    var apostle = writer.SkipWhile(c => c != '=')
                     .Skip(1)
                     .Where(c => !char.IsWhiteSpace(c))
                     .ToArray();
    var paul = new string(apostle);
    Console.WriteLine(paul);
  }
}