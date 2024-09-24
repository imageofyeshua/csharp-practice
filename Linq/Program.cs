using System.Configuration.Assemblies;
using CSharpPhrase.Extensions;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Linq Exercise");

    var names = new List<string> {
      "Paul", "John", "Peter", "James", "Thomas", "Matthew", "Luke", "Mark",
    };

    IEnumerable<string> query = names.Where(s => s.Length <= 4)
                                     .Select(s => s.ToUpper());
    foreach (string s in query)
      Console.WriteLine(s);

    var query2 = names.Select(s => s.Length);
    foreach (var n in query2)
      Console.Write("{0} ", n);
    Console.WriteLine();

    string[] books = {
      "Matthew", "Mark", "Luke", "John", "Romans", "Revelation", 
    };

    var query3 = books.Where(s => s.Length <= 4);
    foreach (var item in query3)
      Console.WriteLine(item);
    Console.WriteLine("-------------");

    books[0] = "Ruth";
    foreach (var item in query3)
      Console.WriteLine(item);
    Console.WriteLine("-------------");

    var query4 = books.Where(s => s.Length <= 4)
                      .ToArray();
    foreach (var item in query4)
      Console.WriteLine(item);
    Console.WriteLine("-------------");

    books[0] = "Jona";
    foreach (var item in query4)
      Console.WriteLine(item);

    var count = books.Count(s => s.Length > 5);
    Console.WriteLine("{0} words longer than 5 letters", count);

    var word = "heavenly";
    var result = word.Reverse();
    Console.WriteLine("Reversed Word: {0}", result);

    Console.WriteLine("### Exercise ###");

    var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

    var query5 = numbers.Where(n => n % 8 == 0 | n % 9 == 0);
    foreach(var item in query5)
      Console.Write("{0} ", item);
    
    Console.WriteLine("----------------------");

    foreach(var item in numbers)
      Console.Write("{0} ", item / 2.0);
  }
}