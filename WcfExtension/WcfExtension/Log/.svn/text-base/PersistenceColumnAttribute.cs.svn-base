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

    public enum ShardSpan
    {
        Day,
        Week,
        Month,
        Year,
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class PersistenceColumnAttribute : Attribute
    {
        public bool IsIndex { get; set; }

        public bool IsShard { get; set; }

        public ShardSpan ShardSpan { get; set; }

        public PersistenceColumnAttribute()
        {
            this.IsIndex = this.IsShard = false;
            this.ShardSpan = WcfExtension.ShardSpan.Month;
        }
    }
}
