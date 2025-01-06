using Microsoft.Extensions.DependencyInjection;
using Progetto_UI.Web.SignalR;
using Progetto_UI.Services.Shared;

namespace Progetto_UI.Web
{
    public class Container
    {
        public static void RegisterTypes(IServiceCollection container)
        {
            // Registration of all the database services you have
            container.AddScoped<SharedService>();

            // Registration of SignalR events
            container.AddScoped<IPublishDomainEvents, SignalrPublishDomainEvents>();
        }
    }
}
