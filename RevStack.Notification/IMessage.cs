using System;

namespace RevStack.Notification
{
    public interface IMessage
    {
        string Day { get; set; }
        DateTime Date { get; set; }
        string Company { get; set; }
        string CompanyAddress { get; set; }
        string CompanyPhone { get; set; }
        string CompanyLogoUrl { get; set; }
        string CssHightlightColor { get; set; }
        string CssLinkColor { get; set; }
    }
}
