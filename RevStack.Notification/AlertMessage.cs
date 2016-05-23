using System;

namespace RevStack.Notification
{
    public class AlertMessage<TKey> : NotifyAlert<TKey>,IAlertMessage<TKey>
    {
        public string Day { get; set; }
        public string Company { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyLogoUrl { get; set; }
        public string CssHightlightColor { get; set; }
        public string CssLinkColor { get; set; }
    }
}
