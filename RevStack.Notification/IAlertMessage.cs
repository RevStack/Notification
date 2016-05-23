using System;
using System.Collections.Generic;


namespace RevStack.Notification
{
    public interface IAlertMessage<TKey> : INotify<TKey>,IMessage
    {

    }
}
