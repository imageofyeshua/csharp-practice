public class Program
{
    public static void Main(string[] args)
    {
        var names = new Names();
        var path = names.BuildFilePath();

        if (File.Exists(path))
        {
            Console.WriteLine("Names file already exists. Loading names.");
            names.ReadFromTextFile();
        }
        else
        {
            Console.WriteLine("Names file does not exists yet.");

            names.AddName("John");
            names.AddName("not a valid name");
            names.AddName("Clair");
            names.AddName("123 definitely not a valid name");

            Console.WriteLine("Saving names to a file");
            names.WriteToTextFile();
        }

        Console.WriteLine(names.Format());
        // Console.ReadKey();
    }
}