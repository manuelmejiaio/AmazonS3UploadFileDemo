using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmazonS3Demo.Startup))]
namespace AmazonS3Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
