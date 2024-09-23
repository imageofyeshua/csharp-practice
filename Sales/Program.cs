class Program
{
  static void Main(string[] args)
  {
     Console.WriteLine("### Sales Program ###"); 
     var sales = new SalesCounter("sales.csv");
     var amountPerStore = sales.GetPerStoreSales();
     foreach(var obj in amountPerStore)
     {
      Console.WriteLine("{0} : {1}", obj.Key, obj.Value);
     }
  }
}