using System;
using RevStack.Pattern;

namespace RevStack.Notification
{
    public interface INotify<TKey> : IEntity<TKey>
    {
        string Key { get; set; }
        string Value { get; set; }
        DateTime Date { get; set; }
        string TrackingUrl { get; set; }
        string TrackingLabel { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Name { get; set; }
        bool IsAuthenticated { get; set; }
    }
}
