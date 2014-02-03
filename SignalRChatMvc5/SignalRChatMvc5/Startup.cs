using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRChatMvc5.Startup))]
namespace SignalRChatMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
            
            ConfigureAuth(app);
        }
    }
}
