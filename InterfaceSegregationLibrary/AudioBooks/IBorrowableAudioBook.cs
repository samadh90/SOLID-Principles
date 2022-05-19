using InterfaceSegregationLibrary.GeneralInterface;

namespace InterfaceSegregationLibrary.AudioBooks
{
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable
    {
    }
}
