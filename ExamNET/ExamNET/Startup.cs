using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamNET.Startup))]
namespace ExamNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
