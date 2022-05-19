using DependencyInversionLibrary;

namespace DependencyInversionUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "John";
            owner.LastName = "Wick";
            owner.EmailAddress = "john@wick.org";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;
            

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}