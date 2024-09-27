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

    int nums = 12345;
    var s1 = nums.ToString();
    Console.WriteLine(s1);
    var s2 = nums.ToString("#");
    Console.WriteLine(s2);
    var s3 = nums.ToString("0000000");
    Console.WriteLine(s3);
    var s4 = nums.ToString("#,0");
    Console.WriteLine(s4);

    decimal distance = 9876.123m;
    var s5 = distance.ToString();
    Console.WriteLine(s5);
    var s6 = distance.ToString("#");
    Console.WriteLine(s6);
    var s7 = distance.ToString("#,0.0");
    Console.WriteLine(s7);
    var s8 = distance.ToString("#,0.0000");
    Console.WriteLine(s8);

    var s9 = string.Format("{0,10}", nums);
    Console.WriteLine(s9);
    var s10 = string.Format("{0,10:#,0}", nums);
    Console.WriteLine(s10);
    var s11 = string.Format("{0,10}", distance);
    Console.WriteLine(s11);
    var s12 = string.Format("{0,10:0.00}", distance);
    Console.WriteLine(s12);

    var s13 = $"{nums:#,0}";
    Console.WriteLine(s13);
    var s14 = $"{nums:0000000}";
    Console.WriteLine(s14);
    var s15 = $"{nums,8}";
    Console.WriteLine(s15);
    var s16 = $"{nums,8:#,0}";
    Console.WriteLine(s16);

    var article = 12;
    var clause = 5;
    var header = String.Format("제{0,2}조{1,2}항", article, clause);
    Console.WriteLine(header);
  }
}