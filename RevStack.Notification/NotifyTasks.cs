using System;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using RevStack.Identity;
using RevStack.Configuration;
using RevStack.Net;

namespace RevStack.Notification
{
    public class NotifyUserAlertTask<TKey> : NotifyTask<TKey>
    {
        public NotifyUserAlertTask(IIdentityEmailService service, IIdentitySmsService smsService) : base(service, smsService)
        {
            TaskType = NotifyTaskType.UserAlert;
        }

        public async override Task<bool> RunAsync(INotify<TKey> entity)
        {
            var id = entity.Id;
            string name = entity.Name;
            if(string.IsNullOrEmpty(name))
            {
                name = entity.Email;
            }
            var url = BaseUrl + User.NotificationAction + "/?id=" + id.ToString() + "&key=" + HttpUtility.UrlEncode(entity.Key)
                + "&value=" + HttpUtility.UrlEncode(entity.Value) + "&authenticated=" + entity.IsAuthenticated + "&name=" + HttpUtility.UrlEncode(name);
            string page = Http.Get(url);
            var message = new IdentityMessage
            {
                Body = page,
                Destination = entity.Email,
                Subject = Company.Name + " " + User.NotificationLabel + " for " + name
            };

            await _service.SendAsync(message, Company.NotificationEmail, true);
            return true;
        }
    }

    public class NotifyUserSignUpTask<TKey> : NotifyTask<TKey>
    {
        public NotifyUserSignUpTask(IIdentityEmailService service, IIdentitySmsService smsService) : base(service, smsService)
        {
            TaskType = NotifyTaskType.UserSignUp;
        }

        public async override Task<bool> RunAsync(INotify<TKey> entity)
        {
            var id = entity.Id;
            string strId = "filler-xx1245267s32wEtJH";
            if(id !=null)
            {
                strId = id.ToString();
            }
            var url = BaseUrl + User.NotificationAction;
            url += "/?id=" + strId + "&key=" + HttpUtility.UrlEncode(entity.Key);
            url += "&value=" + HttpUtility.UrlEncode(entity.Value) + "&authenticated=" + entity.IsAuthenticated + "&name=" + HttpUtility.UrlEncode(entity.Name);
            string page = Http.Get(url);
            var message = new IdentityMessage
            {
                Body = page,
                Destination = entity.Email,
                Subject = Company.Name + " user registration confirmation for " + entity.Name
            };

            await _service.SendAsync(message, Company.NotificationEmail, true);
            return true;
        }
    }
}
