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
    [BsonIgnoreExtraElementsAttribute]
    public abstract class WcfExceptionInfo : AbstractLogInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string Type { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string StackTrace { get; set; }
    }
}
