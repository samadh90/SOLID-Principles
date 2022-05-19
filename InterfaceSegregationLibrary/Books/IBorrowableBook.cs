using InterfaceSegregationLibrary.GeneralInterface;

namespace InterfaceSegregationLibrary.Books
{
    public interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
