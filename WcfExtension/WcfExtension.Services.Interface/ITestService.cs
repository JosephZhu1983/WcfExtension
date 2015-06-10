using System.ServiceModel;
using System.Collections.Generic;

namespace WcfExtension.Services.Interface
{
    [ServiceContract(Namespace = "WcfExtension.Services.Interface")]
    public interface ITestService
    {
        [OperationContract]
        int Add(int x, int y);

        [OperationContract]
        [ServiceKnownType(typeof(TestContract))]
        ITestContract TestData(ITestContract tc);

        [OperationContract]
        List<string> AddList(List<string> args);

        [OperationContract]
        User GetUser(string name, int age);

        [OperationContract(IsOneWay = true)]
        void Hello();
    }
}
