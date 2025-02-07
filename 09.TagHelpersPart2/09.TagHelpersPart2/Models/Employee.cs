namespace _09.TagHelpersPart2.Models
{
    public class Employee
    {
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public Countries Country { get; set; }
        public string Gender { get; set; }

        public string Description { get; set; }
    }

    public enum Countries
    {
        Pakistan,
        India,
        Australia,
        England
    }
}
