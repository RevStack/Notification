using System;
using System.Collections.Generic;
using RevStack.Identity;

namespace RevStack.Notification
{
    public class NotifyTaskList<TKey> : INotifyTaskList<TKey>
    {
        protected readonly IIdentityEmailService _service;
        protected readonly IIdentitySmsService _smsService;
        public NotifyTaskList(IIdentityEmailService service, IIdentitySmsService smsService)
        {
            _service = service;
            _smsService = smsService;
        }

        public virtual List<INotifyTask<TKey>> Tasks
        {
            get
            {
                var list = new List<INotifyTask<TKey>>();
                var item1 = new NotifyUserAlertTask<TKey>(_service, _smsService);
                var item2 = new NotifyUserSignUpTask<TKey>(_service, _smsService);
                list.Add(item1);
                list.Add(item2);
                return list;
            }
        }
    }
}
