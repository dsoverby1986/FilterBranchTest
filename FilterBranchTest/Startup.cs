using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterBranchTest.Startup))]
namespace FilterBranchTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
