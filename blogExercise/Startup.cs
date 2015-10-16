using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(blogExercise.Startup))]
namespace blogExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
