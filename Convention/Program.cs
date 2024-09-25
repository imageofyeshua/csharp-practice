using System.Runtime.CompilerServices;
using Convention;

public class Program
{
  static void Main(string[] args)
  {
    // variable initialization
    var age = 48;
    var langs = new string[] { "C#", "Ruby", "C++", "Javascript", };
    var numbs = new List<int> { 10, 20, 30, 40, };

    var dict = new Dictionary<string, string>
    {
      { "ko", "한국어"},
      { "en", "영어"},
      { "es", "스페인어"},
      { "de", "독일어"},
    };

    var dict2 = new Dictionary<string, string>
    {
      ["ko"] = "한국어",
      ["en"] = "영어",
      ["es"] = "스페인어",
      ["de"] = "독일어",
    };

    // object initialization
    var person = new Person("Hong", "GilDong");
    person.Birthday = new DateTime(1995, 11, 24);
    person.PhoneNumber = "012-345-6789";

    Console.WriteLine("{0} : {1} : {2}", person.Name, person.Birthday, person.PhoneNumber);

    var nums = new List<int> { 1, 2, 3, 4, 5 };
    nums.ForEach(n => Console.Write("[{0}] ", n));

    Console.WriteLine();

    // readonly features
    var obj = new MySample();
    obj.MyList.Add(6);
    obj.MyList.RemoveAt(0);
    obj.MyList[0] = 10;
    foreach (var n in obj.MyList)
    {
      Console.WriteLine(n);
    }

    // obj.MyList = new List<int>();  << build error because of readonly property

    // var median = Median(1.0, 2.0, 3.0);
  }
}

