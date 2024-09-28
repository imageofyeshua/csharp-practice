namespace Dictionary
{
    public class Employee
    {
        public int Code { get; set; }        
        public string Name { get; set; } = "No Name";

        public Employee(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}