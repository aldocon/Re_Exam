using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Re_Exam_2nd.Startup))]
namespace Re_Exam_2nd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
