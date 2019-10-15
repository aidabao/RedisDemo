using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedisDemo.Startup))]
namespace RedisDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
