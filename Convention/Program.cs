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
    var person = new Person
    {
      Name = "홍길동",
      Birthday = new DateTime(1995, 11, 24),
      PhoneNumber = "012-345-6789",
    };

    Console.WriteLine("{0} : {1} : {2}", person.Name, person.Birthday, person.PhoneNumber);
  }
}