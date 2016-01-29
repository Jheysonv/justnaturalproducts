using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JustNaturalProducts.Startup))]
namespace JustNaturalProducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
