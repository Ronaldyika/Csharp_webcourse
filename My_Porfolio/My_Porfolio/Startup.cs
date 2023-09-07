using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My_Porfolio.Startup))]
namespace My_Porfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
