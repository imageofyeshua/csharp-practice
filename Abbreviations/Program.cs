public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("### Abbreviation Program ###");

        var abbrs = new Abbreviations();

        abbrs.AddKorean("IOC", "국제 올림픽 위원회:사탄스포츠그룹");
        abbrs.AddKorean("NPT", "핵확산 방지 조약");

        var names = new[] { "WHO", "FIFA", "NPT", };
        foreach (var name in names)
        {
            var fullname = abbrs[name];
            if (fullname == null)
            {
                Console.WriteLine("We cannot find {0}", name);
            }
            else
            {
                Console.WriteLine("{0} = {1}", name, fullname);
            }
            Console.WriteLine();
        }

        var korean = "동남아시아 국가 연합";
        var abbreviation = abbrs.ToAbbreviation(korean);
        if (abbreviation == null)
            Console.WriteLine("We cannot find abbreviation for {0}", korean);
        else
            Console.WriteLine("The Abbreviation for {0} is {1}", korean, abbreviation);
        Console.WriteLine();

        foreach (var item in abbrs.FindAllKorean("국제"))
        {
            Console.WriteLine("{0} = {1}", item.Key, item.Value);
        }
        Console.WriteLine();
    }
}