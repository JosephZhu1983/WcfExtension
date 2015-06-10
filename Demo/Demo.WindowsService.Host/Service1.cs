using System;
using System.ServiceProcess;

namespace Demo.WindowsService.Host
{
    using System.Diagnostics;
    using Demo.Services.Implementation;
    using WcfExtension;

    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();

            if (!EventLog.SourceExists("MyEventSource"))
            {
                EventLog.CreateEventSource("MyEventSource", "MyNewLog");
            }
            eventLog1.Source = "MyEventSource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Ready to start Service...");
            try
            {
                ServerManager.StartService(typeof(DemoService));
                eventLog1.WriteEntry("Service is Started...");
            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry("Error:" + ex.Message);
            }
            finally
            {
                eventLog1.WriteEntry("OnStart");
            }
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In OnStop");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue");
        }
    }
}
