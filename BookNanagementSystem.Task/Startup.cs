using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.Storage;

[assembly: OwinStartup(typeof(BookNanagementSystem.Task.Startup))]

namespace BookNanagementSystem.Task
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888

            GlobalConfiguration.Configuration.UseSqlServerStorage("Default");

            app.UseHangfireDashboard("/Hangfire");

            app.UseHangfireServer();
        }
    }
}
