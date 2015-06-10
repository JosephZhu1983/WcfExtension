using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo.WebApp.Client
{
    using WcfExtension;
    using Demo.Services.Interface;

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void WcfExtensionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var proxy = WcfServiceLocator.Create<IDemoService>();

                var result = proxy.SayHelloPeople(new People() { Name = "Demo GT" });

                Response.Write(result);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void OneWayButton_Click(object sender, EventArgs e)
        {
            try
            {
                var proxy = WcfServiceLocator.Create<IDemoService>();

                proxy.SayHelloOneWay();

                Response.Write("One Way, No result.");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}