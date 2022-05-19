using OpenClosedLibrary;
using OpenClosedLibrary.Applicants;

namespace OpenClosedUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel {FirstName = "Jack", LastName = "Reacher"},
                new ManagerModel {FirstName = "John", LastName = "Wick"},
                new ExecutiveModel {FirstName = "Bruce", LastName = "Wayne"},
                new TechnicianModel {FirstName = "Bruce", LastName = "Wayne"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}