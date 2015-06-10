
namespace QuickStart.Services.Interface
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "QuickStart.Services.Interface")]
    public interface IQsService
    {
        [OperationContract]
        string SayHelloWorld(string name);
    }
}
