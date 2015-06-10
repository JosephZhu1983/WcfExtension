/****************************************************************************************************************
*                                                                                                               *
* Copyright (C) 2011 5173.com                                                                                   *
* This project may be copied only under the terms of the Apache License 2.0.                                    *
* Please visit the project Home Page http://wcfextension.codeplex.com/ for more detail.                         *
*                                                                                                               *
****************************************************************************************************************/

namespace WcfExtension
{
    internal interface IClientInfo
    {
        string ClientTypeName { get; set; }

        [PersistenceColumn(IsIndex = true)]
        string ContractName { get; set; }
    }
}
