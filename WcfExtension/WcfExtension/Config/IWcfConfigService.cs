/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2011 5173.com                                                                                   *
* This project may be copied only under the terms of the Apache License 2.0.                                    *
* Please visit the project Home Page http://wcfextension.codeplex.com/ for more detail.                         *
*                                                                                                               *
****************************************************************************************************************/

namespace WcfExtension
{
    using System.ServiceModel;

    [ServiceContract(Namespace = "WcfExtension")]
    public interface IWcfConfigService
    {
        [OperationContract]
        WcfService GetWcfService(string serviceType, string serviceContractVersion, string machineIP);

        [OperationContract]
        WcfClientEndpoint GetWcfClientEndpoint(string serviceContractType, string serviceContractVersion, string machineIP);

        [OperationContract]
        WcfClientSetting GetClientSetting(string serviceContractType, string machineIP);

        [OperationContract]
        WcfServerSetting GetServerSetting(string serviceType, string machineIP);
    }
}
