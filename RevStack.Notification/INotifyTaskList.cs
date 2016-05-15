using System;
using System.Collections.Generic;

namespace RevStack.Notification
{
    public interface INotifyTaskList<TKey>
    {
        List<INotifyTask<TKey>> Tasks { get; }
    }
}
