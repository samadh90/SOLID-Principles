using InterfaceSegregationLibrary.GeneralInterface;

namespace InterfaceSegregationLibrary.AudioBooks
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeMinutes { get; set; }
    }
}
