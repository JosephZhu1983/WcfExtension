/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2011 5173.com                                                                                   *
* This project may be copied only under the terms of the Apache License 2.0.                                    *
* Please visit the project Home Page http://wcfextension.codeplex.com/ for more detail.                         *
*                                                                                                               *
****************************************************************************************************************/

namespace WcfExtension
{
    using System;
    using System.Runtime.Remoting.Messaging;
    using System.Runtime.Remoting.Proxies;

    internal class LogServiceRealProxy : RealProxy
    {
        public LogServiceRealProxy() : base(typeof(IWcfLogService)) { }

        public override IMessage Invoke(IMessage msg)
        {
            using (var client = WcfServiceClientFactory.CreateServiceClient<IWcfLogService>())
            {
                var channel = client.Channel;
                IMethodCallMessage methodCall = (IMethodCallMessage)msg;
                IMethodReturnMessage methodReturn = null;
                object[] copiedArgs = Array.CreateInstance(typeof(object), methodCall.Args.Length) as object[];
                methodCall.Args.CopyTo(copiedArgs, 0);
                try
                {
                    object returnValue = methodCall.MethodBase.Invoke(channel, copiedArgs);
                    methodReturn = new ReturnMessage(returnValue,
                                                    copiedArgs,
                                                    copiedArgs.Length,
                                                    methodCall.LogicalCallContext,
                                                    methodCall);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                    {
                        LocalLogService.Log(ex.InnerException.ToString());
                        methodReturn = new ReturnMessage(ex.InnerException, methodCall);
                    }
                    else
                    {
                        LocalLogService.Log(ex.ToString());
                        methodReturn = new ReturnMessage(ex, methodCall);
                    }
                }
                return methodReturn;
            }
        }
    }
}
