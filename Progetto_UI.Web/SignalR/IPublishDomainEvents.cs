using System.Threading.Tasks;

namespace Progetto_UI.Web.SignalR
{
    public interface IPublishDomainEvents
    {
        Task Publish(object evnt);
    }
}
