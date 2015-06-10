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
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [BsonIgnoreExtraElementsAttribute]
    public class ServerInvokeInfo : InvokeInfo, IServerInfo
    {
        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ServiceName { get; set; }

        [DataMember]
        public List<string> Parameters { get; set; }

        [DataMember]
        public List<string> Results { get; set; }
    }
}
