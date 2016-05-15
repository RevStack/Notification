using System;

namespace RevStack.Notification
{
    public class NotifyAlert<TKey> : INotify<TKey>
    {
        public TKey Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public string TrackingUrl { get; set; }
        public string TrackingLabel { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
