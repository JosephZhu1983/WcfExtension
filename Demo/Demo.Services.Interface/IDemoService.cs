
namespace Demo.Services.Interface
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "Demo.Services.Interface")]
    public interface IDemoService
    {
        [OperationContract(IsOneWay = true)]
        void SayHelloOneWay();

        [OperationContract(Name = "SayHello")]
        string SayHelloString();

        [OperationContract]
        [ServiceKnownType(typeof(People))]
        string SayHelloPeople(People p);
    }
}
