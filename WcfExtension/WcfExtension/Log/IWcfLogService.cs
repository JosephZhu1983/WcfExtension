/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2011 5173.com                                                                                   *
* This project may be copied only under the terms of the Apache License 2.0.                                    *
* Please visit the project Home Page http://wcfextension.codeplex.com/ for more detail.                         *
*                                                                                                               *
****************************************************************************************************************/

namespace WcfExtension
{
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract(Namespace = "WcfExtension")]
    public interface IWcfLogService
    {
        [OperationContract]
        string Health();

        [OperationContract(Name = "LogList", IsOneWay = true)]
        void Log(List<AbstractLogInfo> logInfo);

        [OperationContract(Name = "LogOne", IsOneWay = true)]
        void Log(AbstractLogInfo logInfo);
    }
}
