using Dictionary;

public class Program
{
    public static void Main(string[] args)
    {
        var flowerDict = new Dictionary<string, int>
        {
            ["sunflower"] = 400,
            ["pansy"] = 200,
            ["tulip"] = 480,
            ["rose"] = 800,
            ["dahlia"] = 300,
            ["cactus"] = 500,
        };

        var employeeDict = new Dictionary<int, Employee>
    {
      { 100, new Employee(100, "James Choi")},
      { 112, new Employee(112, "Jason Lee")},
      { 125, new Employee(125, "Daniel Park")},
    };

        // add new record
        flowerDict["violet"] = 600;
        employeeDict[126] = new Employee(126, "Eunice Lee");

        // can use Add method but can cause ArgumentException error
        flowerDict.Add("oregano", 880);
        employeeDict.Add(127, new Employee(127, "Peter Kim"));

        int price = flowerDict["sunflower"];
        Console.WriteLine("Sunflower Price is {0}", price);
        var employee = employeeDict[125];
        Console.WriteLine("Employee 125 Name : {0}", employee.Name);

        var flowerKey = "pansy";
        if (flowerDict.ContainsKey(flowerKey))
        {
            var pansyPrice = flowerDict[flowerKey];
            Console.WriteLine("Pansy Price is {0}", pansyPrice);
        }

        var result = flowerDict.Remove("pansy");
        Console.WriteLine("Pansy Removed? {0}", result);

        // foreach (KeyValuePair<string, int> item in flowerDict)
        foreach (var item in flowerDict)
            Console.WriteLine("{0} = {1}", item.Key, item.Value);

        var average = flowerDict.Average(x => x.Value);
        Console.WriteLine("The Average Price of flowers is {0, 5:#,0.00}", average);
        var sum = flowerDict.Sum(x => x.Value);
        Console.WriteLine("The Sum of flower prices is {0, 5:#,0.00}", sum);

        var items = flowerDict.Where(x => x.Key.Contains("rose"));
        foreach (var item in items)
            Console.Write("{0} : {1}", item.Key, item.Value);

        Console.WriteLine();

        foreach (var k in flowerDict.Keys)
            Console.WriteLine(k);

        var employees = new List<Employee>();

        employees.Add(new Employee(100, "James Lee"));
        employees.Add(new Employee(101, "Paul Choi"));
        employees.Add(new Employee(102, "John Park"));

        // List to Dictionary Conversion

        var employeeDict2 = employees.ToDictionary(emp => emp.Code);
        foreach (var item in employeeDict2)
            Console.WriteLine("{0} : {1}", item.Key, item.Value.Name);

        var newDict = flowerDict.Where(x => x.Value > 500)
                                .ToDictionary(flower => flower.Key, flower => flower.Value);

        foreach (var item in newDict.Keys)
            Console.WriteLine("[{0}]", item);

        var holidayDict = new Dictionary<MonthDay, string>
        {
            { new MonthDay(6, 6), "Memorials Day"},
            { new MonthDay(8, 15), "Independence Day"},
            { new MonthDay(10, 1), "Hangul Day"},
        };

        var md = new MonthDay(8, 15);
        var s = holidayDict[md];
        Console.WriteLine("[{0}]", s);

        var lines = File.ReadAllLines("revelation_ch_01.txt");
        var we = new WordsExtractor(lines);
        foreach (var word in we.Extract())
        {
            Console.WriteLine("[{0}]", word);
        }

        // multiple key

        var multiDict = new Dictionary<string, List<string>>()
        {
            {"PC", new List<string> { "Personal Computer", "Program Counter", } },
            {"CD", new List<string> { "Compact Disc", "Cash Dispenser", } },
        };

        var key = "EC";
        var value = "E-Commerce";
        if (multiDict.ContainsKey(key))
        {
            multiDict[key].Add(value);
        }
        else
        {
            multiDict[key] = new List<string> { value };
        }

        Console.WriteLine("### Dictionary Contents ###");

        foreach (var item in multiDict)
        {
            foreach(var term in item.Value)
            {
                Console.WriteLine("{0} : {1}", item.Key, term);
            }
        }
    }
}