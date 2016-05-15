using System;
using System.Web;
using System.Threading.Tasks;
using RevStack.Identity;
using RevStack.Mvc;

namespace RevStack.Notification
{
    public class NotifyTask<TKey> : INotifyTask<TKey>
    {
        protected readonly IIdentityEmailService _service;
        public NotifyTask(IIdentityEmailService service)
        {
            _service = service;
        }
        public NotifyTask() { }

        private NotifyTaskType _taskType;
        private string _identifier;
        public NotifyTaskType TaskType
        {
            get
            {
                return _taskType;
            }

            set
            {
                _taskType = value;
            }
        }
        public string Identifier
        {
            get
            {
                return _identifier;
            }

            set
            {
                _identifier = value;
            }
        }

        public virtual Task<bool> RunAsync(INotify<TKey> entity)
        {
            throw new NotImplementedException();
        }

        protected string BaseUrl
        {
            get
            {
                var context = new HttpContextWrapper(HttpContext.Current);
                HttpRequestBase request = context.Request;
                var uri = new UriUtility(request);
                return uri.Host;
            }
        }
    }
}
