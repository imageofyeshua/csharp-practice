using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        var date = new DateTime(2024, 9, 29, 7, 39, 20);
        Console.WriteLine(date);

        var today = DateTime.Today;
        Console.WriteLine("Today : {0}", today);
        var now = DateTime.Now;
        Console.WriteLine("Now : {0}", now);

        // DateTime internal properties
        int year = now.Year;
        int month = now.Month;
        int day = now.Day;
        int hour = now.Hour;
        int minute = now.Minute;
        int second = now.Second;
        int millisecond = now.Millisecond;

        DayOfWeek dayOfWeek = today.DayOfWeek;
        Console.WriteLine(dayOfWeek);

        var isLeapYear = DateTime.IsLeapYear(2020);
        if (isLeapYear)
            Console.WriteLine("2020 is leap year.");
        else
            Console.WriteLine("2020 is not leap year.");

        DateTime dt3;
        if (DateTime.TryParse("2024/9/29", out dt3));
            Console.WriteLine(dt3);
        DateTime dt4;
        if (DateTime.TryParse("2029/10/1 10:41:38", out dt4));
            Console.WriteLine(dt4);
        
        Console.WriteLine("*** DateTime to String Format ***");
        
        var s1 = date.ToString("d");
        Console.WriteLine(s1);
        var s2 = date.ToString("D");
        Console.WriteLine(s2);
        var s3 = date.ToString("yyyy-MM-dd");
        Console.WriteLine(s3);
        var s4 = date.ToString("yyyy년 M월 d일(ddd)");
        Console.WriteLine(s4);
        var s5 = date.ToString("yyyy년 MM월 dd일 HH시mm분ss초");
        Console.WriteLine(s5);
        var s6 = date.ToString("f");
        Console.WriteLine(s6);
        var s7 = date.ToString("F");
        Console.WriteLine(s7);
        var s8 = date.ToString("t");
        Console.WriteLine(s8);
        var s9 = date.ToString("T");
        Console.WriteLine(s9);
        var s10 = date.ToString("tt hh:mm");
        Console.WriteLine(s10);
        var s11 = date.ToString("HH시mm분ss초");
        Console.WriteLine(s11);

        var s12 = string.Format("{0}년{1,2}월{2,2}일", today.Year, today.Month, today.Day);
        Console.WriteLine(s12);

        // korean dangun calendar
        var culture = new CultureInfo("ko-KR");
        culture.DateTimeFormat.Calendar = new KoreanCalendar();
        var str = date.ToString("ggyyyy년M월d일", culture);
        Console.WriteLine(str);
        var str1 = date.ToString("gg", culture);
        Console.WriteLine(str1);
        var str2 = date.ToString("ddd", culture);
        Console.WriteLine(str2);

        var era = culture.DateTimeFormat.Calendar.GetEra(date);
        var eraName = culture.DateTimeFormat.GetEraName(era);
        Console.WriteLine(eraName);
    }
}