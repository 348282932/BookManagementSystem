using Hangfire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BookNanagementSystem.Task
{
    public partial class ScheduledService : ServiceBase
    {
        public ScheduledService()
        {
            InitializeComponent();

            GlobalConfiguration.Configuration.UseSqlServerStorage("connection_string");
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
