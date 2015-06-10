﻿/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2011 5173.com                                                                                   *
* This project may be copied only under the terms of the Apache License 2.0.                                    *
* Please visit the project Home Page http://wcfextension.codeplex.com/ for more detail.                         *
*                                                                                                               *
****************************************************************************************************************/

namespace WcfExtension
{
    using System.Collections;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    [DataContract(Namespace = "WcfExtension")]
    public class WcfService
    {
        [DataMember]
        public string ServiceType { get; set; }

        [DataMember]
        public string ServiceBehaviorXml { get; set; }

        [DataMember]
        public WcfServiceEndpoint[] Endpoints { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            this.GetType().GetProperties().ToList().ForEach(p =>
            {
                var o = p.GetValue(this, null);
                sb.AppendLine(p.Name + ": " + o);
                if (o is IList)
                {
                    var list = o as IList;
                    foreach (var item in list)
                    {
                        sb.AppendLine(" " + item.ToString());
                    }
                }
            });

            return sb.ToString();
        }
    }
}
