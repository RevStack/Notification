using System;
using System.Threading.Tasks;

namespace RevStack.Notification
{
    public interface INotifyTask<TKey>
    {
        NotifyTaskType TaskType { get; set; }
        string Identifier { get; set; }
        Task<bool> RunAsync(INotify<TKey> entity);
    }

    public enum NotifyTaskType
    {
        OrderConfirmation,
        OrderAlert,
        UserAlert,
        UserSignUp,
        AdminAlert,
        Alert,
        SystemAlert
    }
}
