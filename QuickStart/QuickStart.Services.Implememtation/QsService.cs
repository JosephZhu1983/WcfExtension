
namespace QuickStart.Services.Implememtation
{
    using System.ServiceModel;
    using QuickStart.Services.Interface;

    [ServiceBehavior(Namespace = "QuickStart.Services.Implememtation")]
    public class QsService : IQsService
    {
        public string SayHelloWorld(string name)
        {
            return "Hello " + name;
        }
    }
}
