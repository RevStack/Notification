using System;
using System.Collections.Generic;
using RevStack.Identity;

namespace RevStack.Notification
{
    public class NotifyTaskList<TKey> : INotifyTaskList<TKey>
    {
        protected readonly IIdentityEmailService _service;
        public NotifyTaskList(IIdentityEmailService service)
        {
            _service = service;
        }

        public virtual List<INotifyTask<TKey>> Tasks
        {
            get
            {
                var list = new List<INotifyTask<TKey>>();
                return list;
            }
        }
    }
}
