using InterfaceSegregationLibrary.GeneralInterface;

namespace InterfaceSegregationLibrary.DVDs
{
    public interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }
        int RuntimeMinutes { get; set; }
    }
}
