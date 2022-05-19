using InterfaceSegregationLibrary.GeneralInterface;

namespace InterfaceSegregationLibrary.Books
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
