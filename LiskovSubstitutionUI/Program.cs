using LiskovSubstitutionLibrary;

namespace LiskovSubstitutionUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IManager accountingVP = new CEO();
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager();
            //IManaged emp = new Employee();

            emp.FirstName = "John";
            emp.LastName = "Wick";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();
        }
    }
}