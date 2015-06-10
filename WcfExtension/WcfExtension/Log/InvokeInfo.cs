/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2011 5173.com                                                                                   *
* This project may be copied only under the terms of the Apache License 2.0.                                    *
* Please visit the project Home Page http://wcfextension.codeplex.com/ for more detail.                         *
*                                                                                                               *
****************************************************************************************************************/

namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [KnownType(typeof(ApplicationContext))]
    [BsonIgnoreExtraElementsAttribute]
    public abstract class InvokeInfo : AbstractLogInfo
    {
        [DataMember]
        public long ExecutionTime { get; set; }

        [DataMember]
        public bool IsSuccessuful { get; set; }

        [DataMember]
        public string MethodName { get; set; }

        [DataMember]
        public ApplicationContext ApplicationContext { get; set; }
    }
}
