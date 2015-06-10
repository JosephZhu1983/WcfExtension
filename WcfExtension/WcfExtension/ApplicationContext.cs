﻿/****************************************************************************************************************
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

    [KnownType(typeof(ServerApplicationContext))]
    [KnownType(typeof(ClientApplicationContext))]
    [BsonKnownTypes(typeof(ClientApplicationContext))]
    [BsonKnownTypes(typeof(ServerApplicationContext))]
    public class ApplicationContext : Dictionary<string, string>
    {
        protected static readonly string CallContextKey = "ApplicationContext";
        internal static readonly string ContextHeaderLocalName = "__ApplicationContext";
        internal static readonly string ContextHeaderNamespace = "WcfExtension";

        public new string this[string key]
        {
            get
            {
                if (!base.ContainsKey(key))
                    return null;
                return base[key];
            }
            set
            {
                if (!base.ContainsKey(key))
                    base[key] = value;
            }
        }

        public string RequestIdentity
        {
            get
            {
                return this["RequestIdentity"];
            }
            set
            {
                this["RequestIdentity"] = value;
            }
        }

        public string ServerExceptionID
        {
            get
            {
                return this["ServerExceptionID"];
            }
            set
            {
                this["ServerExceptionID"] = value;
            }
        }

        public string Password
        {
            get
            {
                return this["Password"];
            }
            set
            {
                this["Password"] = value;
            }
        }

    }
}
