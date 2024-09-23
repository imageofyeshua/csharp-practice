using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

public class Program
{
  static void Main(string[] args)
  {
    var list = new List<string> {
      "Seoul", "Busan", "Gimcheon", "Daegu", "Incheon"
    };

    var exists = list.Exists(s => s[0] == 'A');

    Console.WriteLine("City that contains A exists : {0}", exists);

    var name = list.Find(s => s.Length == 7);
    Console.WriteLine("City that has 7 letters : {0}", name);

    var index = list.FindIndex(s => s == "Gimcheon");
    Console.WriteLine("Index of Gimcheon: {0}", index);

    var names = list.FindAll(s => s.Length > 5);
    foreach (var city in names)
    {
      Console.WriteLine(city);
    }

    var removedCount = list.RemoveAll(s => s.Contains("on"));
    Console.WriteLine("{0} removed", removedCount);

    Console.WriteLine("List of Cities");
    list.ForEach(s => Console.WriteLine(s));

    var lowerList = list.ConvertAll(s => s.ToLower());
    lowerList.ForEach(s => Console.WriteLine(s));
  }
}