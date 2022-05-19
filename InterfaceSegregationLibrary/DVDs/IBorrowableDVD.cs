using InterfaceSegregationLibrary.GeneralInterface;

namespace InterfaceSegregationLibrary.DVDs
{
    public interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}
