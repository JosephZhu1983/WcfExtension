/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2011 5173.com                                                                                   *
* This project may be copied only under the terms of the Apache License 2.0.                                    *
* Please visit the project Home Page http://wcfextension.codeplex.com/ for more detail.                         *
*                                                                                                               *
****************************************************************************************************************/

namespace WcfExtension
{
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Serialization;

    [CollectionDataContract(Namespace = "WcfExtension", ItemName = "Context")]
    public class ClientApplicationContext : ApplicationContext
    {
        public string ServerMachineName
        {
            get
            {
                return base["ServerMachineName"];
            }
            set
            {
                base["ServerMachineName"] = value;
            }
        }

        public string ServerVersion
        {
            get
            {
                return base["ServerVersion"];
            }
            set
            {
                base["ServerVersion"] = value;
            }
        }

        public static ClientApplicationContext Current
        {
            get
            {
                return CallContext.GetData(CallContextKey) as ClientApplicationContext;
            }
            set
            {
                CallContext.SetData(CallContextKey, value);
            }
        }
    }
}
