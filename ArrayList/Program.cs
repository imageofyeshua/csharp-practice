using ArrayList;

public class Program
{
  public static void Main(string[] args)
  {
    var books = new List<Book>
    {
      new Book { Title = "Pilgrims Progress", Price = 500, Pages = 756},
      new Book { Title = "War and Peace", Price = 600, Pages = 456},
      new Book { Title = "Revival", Price = 800, Pages = 359},
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

    var number = new List<int> { 9, 5, 4, 3, 0, 2, 1, 7, 5, 3, 8, 9 };
    var average = number.Average();
    Console.WriteLine("Average: {0,6:#,0.00}", average);
  }
}