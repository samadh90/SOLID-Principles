using InterfaceSegregationLibrary.DVDs;

namespace InterfaceSegregationUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}