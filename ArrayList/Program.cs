using System.Security.Cryptography.X509Certificates;
using ArrayList;

public class Program
{
  public static void Main(string[] args)
  {
    var books = new List<Book>
    {
      new Book { Title = "The Scriptures for Saints", Price = 7777777, Pages = 144000},
      new Book { Title = "Pilgrims Progress", Price = 500, Pages = 756},
      new Book { Title = "War and Peace", Price = 600, Pages = 456},
      new Book { Title = "Revival for Saints", Price = 800, Pages = 359},
      new Book { Title = "The Last Generation", Price = 54980, Pages = 666},
      new Book { Title = "The Millenium Kingdom", Price = 144000, Pages = 777},
    };

    var nums = Enumerable.Repeat(-1, 20).ToList();
    foreach (var item in nums)
    {
      Console.Write("[{0}]", item);
    }

    Console.WriteLine();

    var strings = Enumerable.Repeat("(unknown)", 10).ToArray();
    foreach (var item in strings)
    {
      Console.Write("{0}", item);
    }

    Console.WriteLine();

    var array = Enumerable.Range(1, 20).ToArray();
    foreach (var item in array)
      Console.Write("[{0}]", item);

    Console.WriteLine();

    var number = new List<int> { 9, -5, 4, 3, 0, 2, -1, 7, 5, 3, 0, 8, 9, -3, 0 };
    var average = number.Average();
    Console.WriteLine("Average: {0,6:#,0.00}", average);

    var bookPriceAverage = books.Average(x => x.Price);
    Console.WriteLine("The average of books is : {0,8:#,0.00}", bookPriceAverage);

    var bookPriceTotal = books.Sum(x => x.Price);
    Console.WriteLine("The total of books is : {0,8:#,0.00}", bookPriceTotal);

    var min = number.Where(n => n > 0)
                  .Min();
    Console.WriteLine("Minimum number is {0}", min);

    var maxPage = books.Max(x => x.Pages);
    Console.WriteLine("Max Pages is {0}", maxPage);

    var maxPageBook = books.OrderBy(n => n.Pages)
                           .Select(x => x.Title)
                           .Last();
    Console.WriteLine("Max Page Book Title is {0}", maxPageBook);

    var zeroCount = number.Count(n => n == 0);
    Console.WriteLine("The number of zeros is {0}", zeroCount);

    var bookCountsForSaints = books.Count(x => x.Title.Contains("Saints"));
    Console.WriteLine("The Book Counts containing Saints is {0}", bookCountsForSaints);

    bool exists = number.Any(n => n % 7 == 0);
    Console.WriteLine("The number that can be divided by 7 exists? {0}", exists);

    bool bookExists = books.Any(n => n.Pages >= 144000);
    Console.WriteLine("The book that has more than 144000 pages exists? {0}", bookExists);

    bool isAllPositive = number.All(n => n > 0);
    Console.WriteLine("Numbers are all positive? {0}", isAllPositive);

    var numbers1 = new List<int> { 9, -5, 4, 3, 0, 2, -1, 7, 5, 3, 0, 8, 9, -3, 0 };
    var numbers2 = new List<int> { 9, -5, 4, 3, 0, 2, -1, 7, 5, 3, 0, 8, 9, -3, 0 };
    bool equal = numbers1.SequenceEqual(numbers2);
    Console.WriteLine("Numbers1 and Numbers2 are Eqaul? {0}", equal);

    var text = "Our Father who art in heaven, Sanctified be Thy Name";
    var words = text.Split(' ');
    var word = words.FirstOrDefault(x => x.Length == 6);
    Console.WriteLine("The first 6 letters word is {0}", word);

    var numbers = new List<int> { 9, 5, 4, 3, 0, -2, -1, 7, 5, 3, 0, 8, 9, -3, 0 };
    var firstZero = numbers.Select((n, id) => new { Value = n, Index = id })
                      .FirstOrDefault(o => o.Value == 0);

    var index = firstZero == null ? -1 : firstZero.Index;
    Console.WriteLine("The index of the first zero is {0}", index);

    var idx = numbers.FindIndex(n => n < 0);
    Console.WriteLine("The first negative number index is {0}", idx);

    var idx2 = numbers.FindLastIndex(n => n == 0);
    Console.WriteLine("The last zero index is {0}", idx2);

    var results = numbers.Where(n => n > 0).Take(5);
    foreach (var item in results)
      Console.Write("[{0}]", item);

    var selected = books.TakeWhile(x => x.Price != 800);
    foreach (var book in selected)
      Console.WriteLine("{0} {1}", book.Title, book.Price);

    var selectedNumber = numbers.SkipWhile(n => n > 0).ToList();
    foreach (var num in selectedNumber)
      Console.Write("[{0}]", num);

    Console.WriteLine();

    var fruits = new List<string> {
      "Orange",
      "Persimmon",
      "Pear",
      "Grapes",
      "Apple",
      "Peach",
      "Plum",
      "Watermelon",
      "Mango",
      "Pineapple",
      "Cherry"
    };

    var fruitsLower = fruits.Select(name => name.ToLower()).ToArray();
    foreach (var fruit in fruitsLower)
      Console.Write("[{0}]", fruit);
    
    Console.WriteLine();

    var numList = new List<int> { 88, 34, 99, 12 };
    var numStrings = numList.Select(n => n.ToString("0000")).ToArray();
    foreach(var num in numStrings)
      Console.Write("[{0}]", num);

    Console.WriteLine();

    var titles = books.Select(x => x.Title);
    foreach(var it in titles)
      Console.Write("[{0}]", it);

    Console.WriteLine();
    
    var distinctNumbers = numbers.Distinct().ToList();
    foreach (var num in distinctNumbers)
      Console.Write("[{0}]", num);

    Console.WriteLine();
    
    var sortedBooks = books.OrderBy(x => x.Price);
    Console.WriteLine("### Sorted Book List by Price ###");
    foreach(var book in sortedBooks)
      Console.WriteLine("{0} : {1} : {2}", book.Title, book.Price, book.Pages);
    
    string[] files1 = Directory.GetFiles(@"C:\Users\PC\Documents\Dev\CSharpPractice\Resources\TextFiles");
    string[] files2 = Directory.GetFiles(@"C:\Users\PC\Documents\Dev\CSharpPractice\Resources\Images");
    var allfiles =files1.Concat(files2);
    allfiles.ToList().ForEach(Console.WriteLine);

    var list = new List<int> { 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 9 };
    list.RemoveAll(x => x == 5);
    foreach (var item in list)
      Console.Write("[{0}]", item);
    
    Console.WriteLine();

    Type type = typeof(Book);
    Console.WriteLine("{0}", type);
  }
}