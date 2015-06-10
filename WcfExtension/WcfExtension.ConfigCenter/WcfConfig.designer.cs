﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfExtension.ConfigCenter
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WcfConfig")]
	public partial class WcfConfigDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBinding(Binding instance);
    partial void UpdateBinding(Binding instance);
    partial void DeleteBinding(Binding instance);
    partial void InsertServiceEndpoint(ServiceEndpoint instance);
    partial void UpdateServiceEndpoint(ServiceEndpoint instance);
    partial void DeleteServiceEndpoint(ServiceEndpoint instance);
    partial void InsertClientAccess(ClientAccess instance);
    partial void UpdateClientAccess(ClientAccess instance);
    partial void DeleteClientAccess(ClientAccess instance);
    partial void InsertClientEndpoint(ClientEndpoint instance);
    partial void UpdateClientEndpoint(ClientEndpoint instance);
    partial void DeleteClientEndpoint(ClientEndpoint instance);
    partial void InsertServerFarm(ServerFarm instance);
    partial void UpdateServerFarm(ServerFarm instance);
    partial void DeleteServerFarm(ServerFarm instance);
    partial void InsertService(Service instance);
    partial void UpdateService(Service instance);
    partial void DeleteService(Service instance);
    #endregion
		
		public WcfConfigDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WcfConfigConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WcfConfigDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WcfConfigDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WcfConfigDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WcfConfigDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Binding> Bindings
		{
			get
			{
				return this.GetTable<Binding>();
			}
		}
		
		public System.Data.Linq.Table<ServiceEndpoint> ServiceEndpoints
		{
			get
			{
				return this.GetTable<ServiceEndpoint>();
			}
		}
		
		public System.Data.Linq.Table<ClientAccess> ClientAccesses
		{
			get
			{
				return this.GetTable<ClientAccess>();
			}
		}
		
		public System.Data.Linq.Table<ClientEndpoint> ClientEndpoints
		{
			get
			{
				return this.GetTable<ClientEndpoint>();
			}
		}
		
		public System.Data.Linq.Table<ServerFarm> ServerFarms
		{
			get
			{
				return this.GetTable<ServerFarm>();
			}
		}
		
		public System.Data.Linq.Table<Service> Services
		{
			get
			{
				return this.GetTable<Service>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Binding")]
	public partial class Binding : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BindingName;
		
		private string _BindingType;
		
		private int _BindingPriority;
		
		private System.Xml.Linq.XElement _BindingXml;
		
		private string _BindingProtocol;
		
		private EntitySet<ServiceEndpoint> _ServiceEndpoints;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBindingNameChanging(string value);
    partial void OnBindingNameChanged();
    partial void OnBindingTypeChanging(string value);
    partial void OnBindingTypeChanged();
    partial void OnBindingPriorityChanging(int value);
    partial void OnBindingPriorityChanged();
    partial void OnBindingXmlChanging(System.Xml.Linq.XElement value);
    partial void OnBindingXmlChanged();
    partial void OnBindingProtocolChanging(string value);
    partial void OnBindingProtocolChanged();
    #endregion
		
		public Binding()
		{
			this._ServiceEndpoints = new EntitySet<ServiceEndpoint>(new Action<ServiceEndpoint>(this.attach_ServiceEndpoints), new Action<ServiceEndpoint>(this.detach_ServiceEndpoints));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BindingName", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string BindingName
		{
			get
			{
				return this._BindingName;
			}
			set
			{
				if ((this._BindingName != value))
				{
					this.OnBindingNameChanging(value);
					this.SendPropertyChanging();
					this._BindingName = value;
					this.SendPropertyChanged("BindingName");
					this.OnBindingNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BindingType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string BindingType
		{
			get
			{
				return this._BindingType;
			}
			set
			{
				if ((this._BindingType != value))
				{
					this.OnBindingTypeChanging(value);
					this.SendPropertyChanging();
					this._BindingType = value;
					this.SendPropertyChanged("BindingType");
					this.OnBindingTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BindingPriority", DbType="Int NOT NULL")]
		public int BindingPriority
		{
			get
			{
				return this._BindingPriority;
			}
			set
			{
				if ((this._BindingPriority != value))
				{
					this.OnBindingPriorityChanging(value);
					this.SendPropertyChanging();
					this._BindingPriority = value;
					this.SendPropertyChanged("BindingPriority");
					this.OnBindingPriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BindingXml", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement BindingXml
		{
			get
			{
				return this._BindingXml;
			}
			set
			{
				if ((this._BindingXml != value))
				{
					this.OnBindingXmlChanging(value);
					this.SendPropertyChanging();
					this._BindingXml = value;
					this.SendPropertyChanged("BindingXml");
					this.OnBindingXmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BindingProtocol", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string BindingProtocol
		{
			get
			{
				return this._BindingProtocol;
			}
			set
			{
				if ((this._BindingProtocol != value))
				{
					this.OnBindingProtocolChanging(value);
					this.SendPropertyChanging();
					this._BindingProtocol = value;
					this.SendPropertyChanged("BindingProtocol");
					this.OnBindingProtocolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Binding_ServiceEndpoint", Storage="_ServiceEndpoints", ThisKey="BindingName", OtherKey="ServiceEndpointBindingName")]
		public EntitySet<ServiceEndpoint> ServiceEndpoints
		{
			get
			{
				return this._ServiceEndpoints;
			}
			set
			{
				this._ServiceEndpoints.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ServiceEndpoints(ServiceEndpoint entity)
		{
			this.SendPropertyChanging();
			entity.Binding = this;
		}
		
		private void detach_ServiceEndpoints(ServiceEndpoint entity)
		{
			this.SendPropertyChanging();
			entity.Binding = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ServiceEndpoint")]
	public partial class ServiceEndpoint : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ServiceContractType;
		
		private string _ServiceContractVersion;
		
		private string _ServerMachineIP;
		
		private string _ServiceType;
		
		private System.Xml.Linq.XElement _ServiceEndpointBehaviorXml;
		
		private string _ServiceEndpointBindingName;
		
		private int _ServiceEndpointPort;
		
		private string _ServiceEndpointName;
		
		private EntityRef<Binding> _Binding;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnServiceContractTypeChanging(string value);
    partial void OnServiceContractTypeChanged();
    partial void OnServiceContractVersionChanging(string value);
    partial void OnServiceContractVersionChanged();
    partial void OnServerMachineIPChanging(string value);
    partial void OnServerMachineIPChanged();
    partial void OnServiceTypeChanging(string value);
    partial void OnServiceTypeChanged();
    partial void OnServiceEndpointBehaviorXmlChanging(System.Xml.Linq.XElement value);
    partial void OnServiceEndpointBehaviorXmlChanged();
    partial void OnServiceEndpointBindingNameChanging(string value);
    partial void OnServiceEndpointBindingNameChanged();
    partial void OnServiceEndpointPortChanging(int value);
    partial void OnServiceEndpointPortChanged();
    partial void OnServiceEndpointNameChanging(string value);
    partial void OnServiceEndpointNameChanged();
    #endregion
		
		public ServiceEndpoint()
		{
			this._Binding = default(EntityRef<Binding>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceContractType", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ServiceContractType
		{
			get
			{
				return this._ServiceContractType;
			}
			set
			{
				if ((this._ServiceContractType != value))
				{
					this.OnServiceContractTypeChanging(value);
					this.SendPropertyChanging();
					this._ServiceContractType = value;
					this.SendPropertyChanged("ServiceContractType");
					this.OnServiceContractTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceContractVersion", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ServiceContractVersion
		{
			get
			{
				return this._ServiceContractVersion;
			}
			set
			{
				if ((this._ServiceContractVersion != value))
				{
					this.OnServiceContractVersionChanging(value);
					this.SendPropertyChanging();
					this._ServiceContractVersion = value;
					this.SendPropertyChanged("ServiceContractVersion");
					this.OnServiceContractVersionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServerMachineIP", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ServerMachineIP
		{
			get
			{
				return this._ServerMachineIP;
			}
			set
			{
				if ((this._ServerMachineIP != value))
				{
					this.OnServerMachineIPChanging(value);
					this.SendPropertyChanging();
					this._ServerMachineIP = value;
					this.SendPropertyChanged("ServerMachineIP");
					this.OnServerMachineIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceType", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string ServiceType
		{
			get
			{
				return this._ServiceType;
			}
			set
			{
				if ((this._ServiceType != value))
				{
					this.OnServiceTypeChanging(value);
					this.SendPropertyChanging();
					this._ServiceType = value;
					this.SendPropertyChanged("ServiceType");
					this.OnServiceTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceEndpointBehaviorXml", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement ServiceEndpointBehaviorXml
		{
			get
			{
				return this._ServiceEndpointBehaviorXml;
			}
			set
			{
				if ((this._ServiceEndpointBehaviorXml != value))
				{
					this.OnServiceEndpointBehaviorXmlChanging(value);
					this.SendPropertyChanging();
					this._ServiceEndpointBehaviorXml = value;
					this.SendPropertyChanged("ServiceEndpointBehaviorXml");
					this.OnServiceEndpointBehaviorXmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceEndpointBindingName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ServiceEndpointBindingName
		{
			get
			{
				return this._ServiceEndpointBindingName;
			}
			set
			{
				if ((this._ServiceEndpointBindingName != value))
				{
					if (this._Binding.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnServiceEndpointBindingNameChanging(value);
					this.SendPropertyChanging();
					this._ServiceEndpointBindingName = value;
					this.SendPropertyChanged("ServiceEndpointBindingName");
					this.OnServiceEndpointBindingNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceEndpointPort", DbType="Int NOT NULL")]
		public int ServiceEndpointPort
		{
			get
			{
				return this._ServiceEndpointPort;
			}
			set
			{
				if ((this._ServiceEndpointPort != value))
				{
					this.OnServiceEndpointPortChanging(value);
					this.SendPropertyChanging();
					this._ServiceEndpointPort = value;
					this.SendPropertyChanged("ServiceEndpointPort");
					this.OnServiceEndpointPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceEndpointName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ServiceEndpointName
		{
			get
			{
				return this._ServiceEndpointName;
			}
			set
			{
				if ((this._ServiceEndpointName != value))
				{
					this.OnServiceEndpointNameChanging(value);
					this.SendPropertyChanging();
					this._ServiceEndpointName = value;
					this.SendPropertyChanged("ServiceEndpointName");
					this.OnServiceEndpointNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Binding_ServiceEndpoint", Storage="_Binding", ThisKey="ServiceEndpointBindingName", OtherKey="BindingName", IsForeignKey=true)]
		public Binding Binding
		{
			get
			{
				return this._Binding.Entity;
			}
			set
			{
				Binding previousValue = this._Binding.Entity;
				if (((previousValue != value) 
							|| (this._Binding.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Binding.Entity = null;
						previousValue.ServiceEndpoints.Remove(this);
					}
					this._Binding.Entity = value;
					if ((value != null))
					{
						value.ServiceEndpoints.Add(this);
						this._ServiceEndpointBindingName = value.BindingName;
					}
					else
					{
						this._ServiceEndpointBindingName = default(string);
					}
					this.SendPropertyChanged("Binding");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClientAccess")]
	public partial class ClientAccess : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _ClientMachineIP;
		
		private string _AccessServerFarmName;
		
		private EntityRef<ServerFarm> _ServerFarm;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnClientMachineIPChanging(string value);
    partial void OnClientMachineIPChanged();
    partial void OnAccessServerFarmNameChanging(string value);
    partial void OnAccessServerFarmNameChanged();
    #endregion
		
		public ClientAccess()
		{
			this._ServerFarm = default(EntityRef<ServerFarm>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientMachineIP", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ClientMachineIP
		{
			get
			{
				return this._ClientMachineIP;
			}
			set
			{
				if ((this._ClientMachineIP != value))
				{
					this.OnClientMachineIPChanging(value);
					this.SendPropertyChanging();
					this._ClientMachineIP = value;
					this.SendPropertyChanged("ClientMachineIP");
					this.OnClientMachineIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessServerFarmName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AccessServerFarmName
		{
			get
			{
				return this._AccessServerFarmName;
			}
			set
			{
				if ((this._AccessServerFarmName != value))
				{
					if (this._ServerFarm.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccessServerFarmNameChanging(value);
					this.SendPropertyChanging();
					this._AccessServerFarmName = value;
					this.SendPropertyChanged("AccessServerFarmName");
					this.OnAccessServerFarmNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ServerFarm_ClientAccess", Storage="_ServerFarm", ThisKey="AccessServerFarmName", OtherKey="ServerFarmName", IsForeignKey=true)]
		public ServerFarm ServerFarm
		{
			get
			{
				return this._ServerFarm.Entity;
			}
			set
			{
				ServerFarm previousValue = this._ServerFarm.Entity;
				if (((previousValue != value) 
							|| (this._ServerFarm.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ServerFarm.Entity = null;
						previousValue.ClientAccesses.Remove(this);
					}
					this._ServerFarm.Entity = value;
					if ((value != null))
					{
						value.ClientAccesses.Add(this);
						this._AccessServerFarmName = value.ServerFarmName;
					}
					else
					{
						this._AccessServerFarmName = default(string);
					}
					this.SendPropertyChanged("ServerFarm");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClientEndpoint")]
	public partial class ClientEndpoint : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ServiceContractType;
		
		private string _ClientMachineIP;
		
		private System.Xml.Linq.XElement _ClientEndpointBehaviorXml;
		
		private System.Xml.Linq.XElement _ServiceConfig;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnServiceContractTypeChanging(string value);
    partial void OnServiceContractTypeChanged();
    partial void OnClientMachineIPChanging(string value);
    partial void OnClientMachineIPChanged();
    partial void OnClientEndpointBehaviorXmlChanging(System.Xml.Linq.XElement value);
    partial void OnClientEndpointBehaviorXmlChanged();
    partial void OnServiceConfigChanging(System.Xml.Linq.XElement value);
    partial void OnServiceConfigChanged();
    #endregion
		
		public ClientEndpoint()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceContractType", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ServiceContractType
		{
			get
			{
				return this._ServiceContractType;
			}
			set
			{
				if ((this._ServiceContractType != value))
				{
					this.OnServiceContractTypeChanging(value);
					this.SendPropertyChanging();
					this._ServiceContractType = value;
					this.SendPropertyChanged("ServiceContractType");
					this.OnServiceContractTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientMachineIP", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ClientMachineIP
		{
			get
			{
				return this._ClientMachineIP;
			}
			set
			{
				if ((this._ClientMachineIP != value))
				{
					this.OnClientMachineIPChanging(value);
					this.SendPropertyChanging();
					this._ClientMachineIP = value;
					this.SendPropertyChanged("ClientMachineIP");
					this.OnClientMachineIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientEndpointBehaviorXml", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement ClientEndpointBehaviorXml
		{
			get
			{
				return this._ClientEndpointBehaviorXml;
			}
			set
			{
				if ((this._ClientEndpointBehaviorXml != value))
				{
					this.OnClientEndpointBehaviorXmlChanging(value);
					this.SendPropertyChanging();
					this._ClientEndpointBehaviorXml = value;
					this.SendPropertyChanged("ClientEndpointBehaviorXml");
					this.OnClientEndpointBehaviorXmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceConfig", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement ServiceConfig
		{
			get
			{
				return this._ServiceConfig;
			}
			set
			{
				if ((this._ServiceConfig != value))
				{
					this.OnServiceConfigChanging(value);
					this.SendPropertyChanging();
					this._ServiceConfig = value;
					this.SendPropertyChanged("ServiceConfig");
					this.OnServiceConfigChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ServerFarm")]
	public partial class ServerFarm : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ServerFarmName;
		
		private string _ServerFarmAddress;
		
		private EntitySet<ClientAccess> _ClientAccesses;
		
		private EntitySet<Service> _Services;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnServerFarmNameChanging(string value);
    partial void OnServerFarmNameChanged();
    partial void OnServerFarmAddressChanging(string value);
    partial void OnServerFarmAddressChanged();
    #endregion
		
		public ServerFarm()
		{
			this._ClientAccesses = new EntitySet<ClientAccess>(new Action<ClientAccess>(this.attach_ClientAccesses), new Action<ClientAccess>(this.detach_ClientAccesses));
			this._Services = new EntitySet<Service>(new Action<Service>(this.attach_Services), new Action<Service>(this.detach_Services));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServerFarmName", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ServerFarmName
		{
			get
			{
				return this._ServerFarmName;
			}
			set
			{
				if ((this._ServerFarmName != value))
				{
					this.OnServerFarmNameChanging(value);
					this.SendPropertyChanging();
					this._ServerFarmName = value;
					this.SendPropertyChanged("ServerFarmName");
					this.OnServerFarmNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServerFarmAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ServerFarmAddress
		{
			get
			{
				return this._ServerFarmAddress;
			}
			set
			{
				if ((this._ServerFarmAddress != value))
				{
					this.OnServerFarmAddressChanging(value);
					this.SendPropertyChanging();
					this._ServerFarmAddress = value;
					this.SendPropertyChanged("ServerFarmAddress");
					this.OnServerFarmAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ServerFarm_ClientAccess", Storage="_ClientAccesses", ThisKey="ServerFarmName", OtherKey="AccessServerFarmName")]
		public EntitySet<ClientAccess> ClientAccesses
		{
			get
			{
				return this._ClientAccesses;
			}
			set
			{
				this._ClientAccesses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ServerFarm_Service", Storage="_Services", ThisKey="ServerFarmName", OtherKey="ServerFarmName")]
		public EntitySet<Service> Services
		{
			get
			{
				return this._Services;
			}
			set
			{
				this._Services.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ClientAccesses(ClientAccess entity)
		{
			this.SendPropertyChanging();
			entity.ServerFarm = this;
		}
		
		private void detach_ClientAccesses(ClientAccess entity)
		{
			this.SendPropertyChanging();
			entity.ServerFarm = null;
		}
		
		private void attach_Services(Service entity)
		{
			this.SendPropertyChanging();
			entity.ServerFarm = this;
		}
		
		private void detach_Services(Service entity)
		{
			this.SendPropertyChanging();
			entity.ServerFarm = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Service")]
	public partial class Service : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ServiceType;
		
		private System.Xml.Linq.XElement _ServiceBehaviorXml;
		
		private string _ServerFarmName;
		
		private System.Xml.Linq.XElement _ServiceConfig;
		
		private string _ServerMachineIP;
		
		private EntityRef<ServerFarm> _ServerFarm;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnServiceTypeChanging(string value);
    partial void OnServiceTypeChanged();
    partial void OnServiceBehaviorXmlChanging(System.Xml.Linq.XElement value);
    partial void OnServiceBehaviorXmlChanged();
    partial void OnServerFarmNameChanging(string value);
    partial void OnServerFarmNameChanged();
    partial void OnServiceConfigChanging(System.Xml.Linq.XElement value);
    partial void OnServiceConfigChanged();
    partial void OnServerMachineIPChanging(string value);
    partial void OnServerMachineIPChanged();
    #endregion
		
		public Service()
		{
			this._ServerFarm = default(EntityRef<ServerFarm>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceType", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ServiceType
		{
			get
			{
				return this._ServiceType;
			}
			set
			{
				if ((this._ServiceType != value))
				{
					this.OnServiceTypeChanging(value);
					this.SendPropertyChanging();
					this._ServiceType = value;
					this.SendPropertyChanged("ServiceType");
					this.OnServiceTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceBehaviorXml", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement ServiceBehaviorXml
		{
			get
			{
				return this._ServiceBehaviorXml;
			}
			set
			{
				if ((this._ServiceBehaviorXml != value))
				{
					this.OnServiceBehaviorXmlChanging(value);
					this.SendPropertyChanging();
					this._ServiceBehaviorXml = value;
					this.SendPropertyChanged("ServiceBehaviorXml");
					this.OnServiceBehaviorXmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServerFarmName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ServerFarmName
		{
			get
			{
				return this._ServerFarmName;
			}
			set
			{
				if ((this._ServerFarmName != value))
				{
					if (this._ServerFarm.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnServerFarmNameChanging(value);
					this.SendPropertyChanging();
					this._ServerFarmName = value;
					this.SendPropertyChanged("ServerFarmName");
					this.OnServerFarmNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServiceConfig", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement ServiceConfig
		{
			get
			{
				return this._ServiceConfig;
			}
			set
			{
				if ((this._ServiceConfig != value))
				{
					this.OnServiceConfigChanging(value);
					this.SendPropertyChanging();
					this._ServiceConfig = value;
					this.SendPropertyChanged("ServiceConfig");
					this.OnServiceConfigChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServerMachineIP", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ServerMachineIP
		{
			get
			{
				return this._ServerMachineIP;
			}
			set
			{
				if ((this._ServerMachineIP != value))
				{
					this.OnServerMachineIPChanging(value);
					this.SendPropertyChanging();
					this._ServerMachineIP = value;
					this.SendPropertyChanged("ServerMachineIP");
					this.OnServerMachineIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ServerFarm_Service", Storage="_ServerFarm", ThisKey="ServerFarmName", OtherKey="ServerFarmName", IsForeignKey=true)]
		public ServerFarm ServerFarm
		{
			get
			{
				return this._ServerFarm.Entity;
			}
			set
			{
				ServerFarm previousValue = this._ServerFarm.Entity;
				if (((previousValue != value) 
							|| (this._ServerFarm.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ServerFarm.Entity = null;
						previousValue.Services.Remove(this);
					}
					this._ServerFarm.Entity = value;
					if ((value != null))
					{
						value.Services.Add(this);
						this._ServerFarmName = value.ServerFarmName;
					}
					else
					{
						this._ServerFarmName = default(string);
					}
					this.SendPropertyChanged("ServerFarm");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
