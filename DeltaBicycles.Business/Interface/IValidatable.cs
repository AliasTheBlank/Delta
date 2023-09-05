using DeltaBicycles.Business.Delegates;

namespace DeltaBicycles.Business.Interface
{
    public interface IValidatable
    {
        event Notify GotInvalidNotification;
        bool IsValid();
        string InvalidMessage { get; set; }
    }
}
