﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLinq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Heddiye")]
	public partial class HeddiyeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBurc(Burc instance);
    partial void UpdateBurc(Burc instance);
    partial void DeleteBurc(Burc instance);
    partial void InsertCinsiyet(Cinsiyet instance);
    partial void UpdateCinsiyet(Cinsiyet instance);
    partial void DeleteCinsiyet(Cinsiyet instance);
    partial void InsertHediyeAmaci(HediyeAmaci instance);
    partial void UpdateHediyeAmaci(HediyeAmaci instance);
    partial void DeleteHediyeAmaci(HediyeAmaci instance);
    partial void InsertUrunler(Urunler instance);
    partial void UpdateUrunler(Urunler instance);
    partial void DeleteUrunler(Urunler instance);
    partial void InsertYakinlikDerecesi(YakinlikDerecesi instance);
    partial void UpdateYakinlikDerecesi(YakinlikDerecesi instance);
    partial void DeleteYakinlikDerecesi(YakinlikDerecesi instance);
    partial void InsertYasAraligi(YasAraligi instance);
    partial void UpdateYasAraligi(YasAraligi instance);
    partial void DeleteYasAraligi(YasAraligi instance);
    #endregion
		
		public HeddiyeDataContext() : 
				base(global::DataLinq.Properties.Settings.Default.HeddiyeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HeddiyeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HeddiyeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HeddiyeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HeddiyeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Burc> Burcs
		{
			get
			{
				return this.GetTable<Burc>();
			}
		}
		
		public System.Data.Linq.Table<Cinsiyet> Cinsiyets
		{
			get
			{
				return this.GetTable<Cinsiyet>();
			}
		}
		
		public System.Data.Linq.Table<HediyeAmaci> HediyeAmacis
		{
			get
			{
				return this.GetTable<HediyeAmaci>();
			}
		}
		
		public System.Data.Linq.Table<Urunler> Urunlers
		{
			get
			{
				return this.GetTable<Urunler>();
			}
		}
		
		public System.Data.Linq.Table<YakinlikDerecesi> YakinlikDerecesis
		{
			get
			{
				return this.GetTable<YakinlikDerecesi>();
			}
		}
		
		public System.Data.Linq.Table<YasAraligi> YasAraligis
		{
			get
			{
				return this.GetTable<YasAraligi>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_UrunEkle")]
		public int SP_UrunEkle([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UrunAdii", DbType="VarChar(50)")] string urunAdii, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cinsiyet", DbType="VarChar(50)")] string cinsiyet, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HediyeAmacii", DbType="VarChar(50)")] string hediyeAmacii, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="YakinlikDerecesii", DbType="VarChar(50)")] string yakinlikDerecesii, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="YasAraligii", DbType="VarChar(50)")] string yasAraligii, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BurcAdii", DbType="VarChar(50)")] string burcAdii, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Link", DbType="NVarChar(MAX)")] string link)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), urunAdii, cinsiyet, hediyeAmacii, yakinlikDerecesii, yasAraligii, burcAdii, link);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UrunListele")]
		public ISingleResult<UrunListeleResult> UrunListele([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CinsiyetAdi", DbType="NChar(10)")] string cinsiyetAdi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HediyeAmacAdi", DbType="VarChar(100)")] string hediyeAmacAdi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="YakinlikDerecesi", DbType="VarChar(50)")] string yakinlikDerecesi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Yas", DbType="VarChar(50)")] string yas, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Burc", DbType="VarChar(15)")] string burc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cinsiyetAdi, hediyeAmacAdi, yakinlikDerecesi, yas, burc);
			return ((ISingleResult<UrunListeleResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin
	{
		
		private string _email;
		
		private string _şifre;
		
		public Admin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_şifre", DbType="VarChar(50)")]
		public string şifre
		{
			get
			{
				return this._şifre;
			}
			set
			{
				if ((this._şifre != value))
				{
					this._şifre = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Burc")]
	public partial class Burc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BurcId;
		
		private string _BurcAdi;
		
		private EntitySet<Urunler> _Urunlers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBurcIdChanging(int value);
    partial void OnBurcIdChanged();
    partial void OnBurcAdiChanging(string value);
    partial void OnBurcAdiChanged();
    #endregion
		
		public Burc()
		{
			this._Urunlers = new EntitySet<Urunler>(new Action<Urunler>(this.attach_Urunlers), new Action<Urunler>(this.detach_Urunlers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BurcId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BurcId
		{
			get
			{
				return this._BurcId;
			}
			set
			{
				if ((this._BurcId != value))
				{
					this.OnBurcIdChanging(value);
					this.SendPropertyChanging();
					this._BurcId = value;
					this.SendPropertyChanged("BurcId");
					this.OnBurcIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BurcAdi", DbType="VarChar(50)")]
		public string BurcAdi
		{
			get
			{
				return this._BurcAdi;
			}
			set
			{
				if ((this._BurcAdi != value))
				{
					this.OnBurcAdiChanging(value);
					this.SendPropertyChanging();
					this._BurcAdi = value;
					this.SendPropertyChanged("BurcAdi");
					this.OnBurcAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Burc_Urunler", Storage="_Urunlers", ThisKey="BurcId", OtherKey="BurcId")]
		public EntitySet<Urunler> Urunlers
		{
			get
			{
				return this._Urunlers;
			}
			set
			{
				this._Urunlers.Assign(value);
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
		
		private void attach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Burc = this;
		}
		
		private void detach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Burc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cinsiyet")]
	public partial class Cinsiyet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CinsiyetId;
		
		private string _CinsiyetAdi;
		
		private EntitySet<Urunler> _Urunlers;
		
		private EntitySet<YakinlikDerecesi> _YakinlikDerecesis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCinsiyetIdChanging(int value);
    partial void OnCinsiyetIdChanged();
    partial void OnCinsiyetAdiChanging(string value);
    partial void OnCinsiyetAdiChanged();
    #endregion
		
		public Cinsiyet()
		{
			this._Urunlers = new EntitySet<Urunler>(new Action<Urunler>(this.attach_Urunlers), new Action<Urunler>(this.detach_Urunlers));
			this._YakinlikDerecesis = new EntitySet<YakinlikDerecesi>(new Action<YakinlikDerecesi>(this.attach_YakinlikDerecesis), new Action<YakinlikDerecesi>(this.detach_YakinlikDerecesis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CinsiyetId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CinsiyetId
		{
			get
			{
				return this._CinsiyetId;
			}
			set
			{
				if ((this._CinsiyetId != value))
				{
					this.OnCinsiyetIdChanging(value);
					this.SendPropertyChanging();
					this._CinsiyetId = value;
					this.SendPropertyChanged("CinsiyetId");
					this.OnCinsiyetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CinsiyetAdi", DbType="NChar(10)")]
		public string CinsiyetAdi
		{
			get
			{
				return this._CinsiyetAdi;
			}
			set
			{
				if ((this._CinsiyetAdi != value))
				{
					this.OnCinsiyetAdiChanging(value);
					this.SendPropertyChanging();
					this._CinsiyetAdi = value;
					this.SendPropertyChanged("CinsiyetAdi");
					this.OnCinsiyetAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cinsiyet_Urunler", Storage="_Urunlers", ThisKey="CinsiyetId", OtherKey="CinsiyetId")]
		public EntitySet<Urunler> Urunlers
		{
			get
			{
				return this._Urunlers;
			}
			set
			{
				this._Urunlers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cinsiyet_YakinlikDerecesi", Storage="_YakinlikDerecesis", ThisKey="CinsiyetId", OtherKey="CinsiyetId")]
		public EntitySet<YakinlikDerecesi> YakinlikDerecesis
		{
			get
			{
				return this._YakinlikDerecesis;
			}
			set
			{
				this._YakinlikDerecesis.Assign(value);
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
		
		private void attach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Cinsiyet = this;
		}
		
		private void detach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Cinsiyet = null;
		}
		
		private void attach_YakinlikDerecesis(YakinlikDerecesi entity)
		{
			this.SendPropertyChanging();
			entity.Cinsiyet = this;
		}
		
		private void detach_YakinlikDerecesis(YakinlikDerecesi entity)
		{
			this.SendPropertyChanging();
			entity.Cinsiyet = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HediyeAmaci")]
	public partial class HediyeAmaci : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _HediyeAmacId;
		
		private string _HediyeAmaci1;
		
		private EntitySet<Urunler> _Urunlers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHediyeAmacIdChanging(int value);
    partial void OnHediyeAmacIdChanged();
    partial void OnHediyeAmaci1Changing(string value);
    partial void OnHediyeAmaci1Changed();
    #endregion
		
		public HediyeAmaci()
		{
			this._Urunlers = new EntitySet<Urunler>(new Action<Urunler>(this.attach_Urunlers), new Action<Urunler>(this.detach_Urunlers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HediyeAmacId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int HediyeAmacId
		{
			get
			{
				return this._HediyeAmacId;
			}
			set
			{
				if ((this._HediyeAmacId != value))
				{
					this.OnHediyeAmacIdChanging(value);
					this.SendPropertyChanging();
					this._HediyeAmacId = value;
					this.SendPropertyChanged("HediyeAmacId");
					this.OnHediyeAmacIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="HediyeAmaci", Storage="_HediyeAmaci1", DbType="VarChar(50)")]
		public string HediyeAmaci1
		{
			get
			{
				return this._HediyeAmaci1;
			}
			set
			{
				if ((this._HediyeAmaci1 != value))
				{
					this.OnHediyeAmaci1Changing(value);
					this.SendPropertyChanging();
					this._HediyeAmaci1 = value;
					this.SendPropertyChanged("HediyeAmaci1");
					this.OnHediyeAmaci1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HediyeAmaci_Urunler", Storage="_Urunlers", ThisKey="HediyeAmacId", OtherKey="HediyeAmacId")]
		public EntitySet<Urunler> Urunlers
		{
			get
			{
				return this._Urunlers;
			}
			set
			{
				this._Urunlers.Assign(value);
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
		
		private void attach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.HediyeAmaci = this;
		}
		
		private void detach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.HediyeAmaci = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Urunler")]
	public partial class Urunler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UrunId;
		
		private string _UrunAdi;
		
		private int _CinsiyetId;
		
		private int _HediyeAmacId;
		
		private int _YakinlikId;
		
		private int _YasId;
		
		private int _BurcId;
		
		private string _Link;
		
		private EntityRef<Burc> _Burc;
		
		private EntityRef<Cinsiyet> _Cinsiyet;
		
		private EntityRef<HediyeAmaci> _HediyeAmaci;
		
		private EntityRef<YakinlikDerecesi> _YakinlikDerecesi;
		
		private EntityRef<YasAraligi> _YasAraligi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUrunIdChanging(int value);
    partial void OnUrunIdChanged();
    partial void OnUrunAdiChanging(string value);
    partial void OnUrunAdiChanged();
    partial void OnCinsiyetIdChanging(int value);
    partial void OnCinsiyetIdChanged();
    partial void OnHediyeAmacIdChanging(int value);
    partial void OnHediyeAmacIdChanged();
    partial void OnYakinlikIdChanging(int value);
    partial void OnYakinlikIdChanged();
    partial void OnYasIdChanging(int value);
    partial void OnYasIdChanged();
    partial void OnBurcIdChanging(int value);
    partial void OnBurcIdChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    #endregion
		
		public Urunler()
		{
			this._Burc = default(EntityRef<Burc>);
			this._Cinsiyet = default(EntityRef<Cinsiyet>);
			this._HediyeAmaci = default(EntityRef<HediyeAmaci>);
			this._YakinlikDerecesi = default(EntityRef<YakinlikDerecesi>);
			this._YasAraligi = default(EntityRef<YasAraligi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UrunId
		{
			get
			{
				return this._UrunId;
			}
			set
			{
				if ((this._UrunId != value))
				{
					this.OnUrunIdChanging(value);
					this.SendPropertyChanging();
					this._UrunId = value;
					this.SendPropertyChanged("UrunId");
					this.OnUrunIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunAdi", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UrunAdi
		{
			get
			{
				return this._UrunAdi;
			}
			set
			{
				if ((this._UrunAdi != value))
				{
					this.OnUrunAdiChanging(value);
					this.SendPropertyChanging();
					this._UrunAdi = value;
					this.SendPropertyChanged("UrunAdi");
					this.OnUrunAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CinsiyetId", DbType="Int NOT NULL")]
		public int CinsiyetId
		{
			get
			{
				return this._CinsiyetId;
			}
			set
			{
				if ((this._CinsiyetId != value))
				{
					if (this._Cinsiyet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCinsiyetIdChanging(value);
					this.SendPropertyChanging();
					this._CinsiyetId = value;
					this.SendPropertyChanged("CinsiyetId");
					this.OnCinsiyetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HediyeAmacId", DbType="Int NOT NULL")]
		public int HediyeAmacId
		{
			get
			{
				return this._HediyeAmacId;
			}
			set
			{
				if ((this._HediyeAmacId != value))
				{
					if (this._HediyeAmaci.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHediyeAmacIdChanging(value);
					this.SendPropertyChanging();
					this._HediyeAmacId = value;
					this.SendPropertyChanged("HediyeAmacId");
					this.OnHediyeAmacIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YakinlikId", DbType="Int NOT NULL")]
		public int YakinlikId
		{
			get
			{
				return this._YakinlikId;
			}
			set
			{
				if ((this._YakinlikId != value))
				{
					if (this._YakinlikDerecesi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnYakinlikIdChanging(value);
					this.SendPropertyChanging();
					this._YakinlikId = value;
					this.SendPropertyChanged("YakinlikId");
					this.OnYakinlikIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YasId", DbType="Int NOT NULL")]
		public int YasId
		{
			get
			{
				return this._YasId;
			}
			set
			{
				if ((this._YasId != value))
				{
					if (this._YasAraligi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnYasIdChanging(value);
					this.SendPropertyChanging();
					this._YasId = value;
					this.SendPropertyChanged("YasId");
					this.OnYasIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BurcId", DbType="Int NOT NULL")]
		public int BurcId
		{
			get
			{
				return this._BurcId;
			}
			set
			{
				if ((this._BurcId != value))
				{
					if (this._Burc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBurcIdChanging(value);
					this.SendPropertyChanging();
					this._BurcId = value;
					this.SendPropertyChanged("BurcId");
					this.OnBurcIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Burc_Urunler", Storage="_Burc", ThisKey="BurcId", OtherKey="BurcId", IsForeignKey=true)]
		public Burc Burc
		{
			get
			{
				return this._Burc.Entity;
			}
			set
			{
				Burc previousValue = this._Burc.Entity;
				if (((previousValue != value) 
							|| (this._Burc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Burc.Entity = null;
						previousValue.Urunlers.Remove(this);
					}
					this._Burc.Entity = value;
					if ((value != null))
					{
						value.Urunlers.Add(this);
						this._BurcId = value.BurcId;
					}
					else
					{
						this._BurcId = default(int);
					}
					this.SendPropertyChanged("Burc");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cinsiyet_Urunler", Storage="_Cinsiyet", ThisKey="CinsiyetId", OtherKey="CinsiyetId", IsForeignKey=true)]
		public Cinsiyet Cinsiyet
		{
			get
			{
				return this._Cinsiyet.Entity;
			}
			set
			{
				Cinsiyet previousValue = this._Cinsiyet.Entity;
				if (((previousValue != value) 
							|| (this._Cinsiyet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cinsiyet.Entity = null;
						previousValue.Urunlers.Remove(this);
					}
					this._Cinsiyet.Entity = value;
					if ((value != null))
					{
						value.Urunlers.Add(this);
						this._CinsiyetId = value.CinsiyetId;
					}
					else
					{
						this._CinsiyetId = default(int);
					}
					this.SendPropertyChanged("Cinsiyet");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HediyeAmaci_Urunler", Storage="_HediyeAmaci", ThisKey="HediyeAmacId", OtherKey="HediyeAmacId", IsForeignKey=true)]
		public HediyeAmaci HediyeAmaci
		{
			get
			{
				return this._HediyeAmaci.Entity;
			}
			set
			{
				HediyeAmaci previousValue = this._HediyeAmaci.Entity;
				if (((previousValue != value) 
							|| (this._HediyeAmaci.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HediyeAmaci.Entity = null;
						previousValue.Urunlers.Remove(this);
					}
					this._HediyeAmaci.Entity = value;
					if ((value != null))
					{
						value.Urunlers.Add(this);
						this._HediyeAmacId = value.HediyeAmacId;
					}
					else
					{
						this._HediyeAmacId = default(int);
					}
					this.SendPropertyChanged("HediyeAmaci");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="YakinlikDerecesi_Urunler", Storage="_YakinlikDerecesi", ThisKey="YakinlikId", OtherKey="YakinlikId", IsForeignKey=true)]
		public YakinlikDerecesi YakinlikDerecesi
		{
			get
			{
				return this._YakinlikDerecesi.Entity;
			}
			set
			{
				YakinlikDerecesi previousValue = this._YakinlikDerecesi.Entity;
				if (((previousValue != value) 
							|| (this._YakinlikDerecesi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._YakinlikDerecesi.Entity = null;
						previousValue.Urunlers.Remove(this);
					}
					this._YakinlikDerecesi.Entity = value;
					if ((value != null))
					{
						value.Urunlers.Add(this);
						this._YakinlikId = value.YakinlikId;
					}
					else
					{
						this._YakinlikId = default(int);
					}
					this.SendPropertyChanged("YakinlikDerecesi");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="YasAraligi_Urunler", Storage="_YasAraligi", ThisKey="YasId", OtherKey="YasId", IsForeignKey=true)]
		public YasAraligi YasAraligi
		{
			get
			{
				return this._YasAraligi.Entity;
			}
			set
			{
				YasAraligi previousValue = this._YasAraligi.Entity;
				if (((previousValue != value) 
							|| (this._YasAraligi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._YasAraligi.Entity = null;
						previousValue.Urunlers.Remove(this);
					}
					this._YasAraligi.Entity = value;
					if ((value != null))
					{
						value.Urunlers.Add(this);
						this._YasId = value.YasId;
					}
					else
					{
						this._YasId = default(int);
					}
					this.SendPropertyChanged("YasAraligi");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.YakinlikDerecesi")]
	public partial class YakinlikDerecesi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _YakinlikId;
		
		private string _YakinlikDerecesi1;
		
		private int _CinsiyetId;
		
		private EntitySet<Urunler> _Urunlers;
		
		private EntityRef<Cinsiyet> _Cinsiyet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnYakinlikIdChanging(int value);
    partial void OnYakinlikIdChanged();
    partial void OnYakinlikDerecesi1Changing(string value);
    partial void OnYakinlikDerecesi1Changed();
    partial void OnCinsiyetIdChanging(int value);
    partial void OnCinsiyetIdChanged();
    #endregion
		
		public YakinlikDerecesi()
		{
			this._Urunlers = new EntitySet<Urunler>(new Action<Urunler>(this.attach_Urunlers), new Action<Urunler>(this.detach_Urunlers));
			this._Cinsiyet = default(EntityRef<Cinsiyet>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YakinlikId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int YakinlikId
		{
			get
			{
				return this._YakinlikId;
			}
			set
			{
				if ((this._YakinlikId != value))
				{
					this.OnYakinlikIdChanging(value);
					this.SendPropertyChanging();
					this._YakinlikId = value;
					this.SendPropertyChanged("YakinlikId");
					this.OnYakinlikIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="YakinlikDerecesi", Storage="_YakinlikDerecesi1", DbType="VarChar(50)")]
		public string YakinlikDerecesi1
		{
			get
			{
				return this._YakinlikDerecesi1;
			}
			set
			{
				if ((this._YakinlikDerecesi1 != value))
				{
					this.OnYakinlikDerecesi1Changing(value);
					this.SendPropertyChanging();
					this._YakinlikDerecesi1 = value;
					this.SendPropertyChanged("YakinlikDerecesi1");
					this.OnYakinlikDerecesi1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CinsiyetId", DbType="Int NOT NULL")]
		public int CinsiyetId
		{
			get
			{
				return this._CinsiyetId;
			}
			set
			{
				if ((this._CinsiyetId != value))
				{
					if (this._Cinsiyet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCinsiyetIdChanging(value);
					this.SendPropertyChanging();
					this._CinsiyetId = value;
					this.SendPropertyChanged("CinsiyetId");
					this.OnCinsiyetIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="YakinlikDerecesi_Urunler", Storage="_Urunlers", ThisKey="YakinlikId", OtherKey="YakinlikId")]
		public EntitySet<Urunler> Urunlers
		{
			get
			{
				return this._Urunlers;
			}
			set
			{
				this._Urunlers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cinsiyet_YakinlikDerecesi", Storage="_Cinsiyet", ThisKey="CinsiyetId", OtherKey="CinsiyetId", IsForeignKey=true)]
		public Cinsiyet Cinsiyet
		{
			get
			{
				return this._Cinsiyet.Entity;
			}
			set
			{
				Cinsiyet previousValue = this._Cinsiyet.Entity;
				if (((previousValue != value) 
							|| (this._Cinsiyet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cinsiyet.Entity = null;
						previousValue.YakinlikDerecesis.Remove(this);
					}
					this._Cinsiyet.Entity = value;
					if ((value != null))
					{
						value.YakinlikDerecesis.Add(this);
						this._CinsiyetId = value.CinsiyetId;
					}
					else
					{
						this._CinsiyetId = default(int);
					}
					this.SendPropertyChanged("Cinsiyet");
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
		
		private void attach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.YakinlikDerecesi = this;
		}
		
		private void detach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.YakinlikDerecesi = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.YasAraligi")]
	public partial class YasAraligi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _YasId;
		
		private string _YasAraligi1;
		
		private EntitySet<Urunler> _Urunlers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnYasIdChanging(int value);
    partial void OnYasIdChanged();
    partial void OnYasAraligi1Changing(string value);
    partial void OnYasAraligi1Changed();
    #endregion
		
		public YasAraligi()
		{
			this._Urunlers = new EntitySet<Urunler>(new Action<Urunler>(this.attach_Urunlers), new Action<Urunler>(this.detach_Urunlers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YasId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int YasId
		{
			get
			{
				return this._YasId;
			}
			set
			{
				if ((this._YasId != value))
				{
					this.OnYasIdChanging(value);
					this.SendPropertyChanging();
					this._YasId = value;
					this.SendPropertyChanged("YasId");
					this.OnYasIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="YasAraligi", Storage="_YasAraligi1", DbType="VarChar(50)")]
		public string YasAraligi1
		{
			get
			{
				return this._YasAraligi1;
			}
			set
			{
				if ((this._YasAraligi1 != value))
				{
					this.OnYasAraligi1Changing(value);
					this.SendPropertyChanging();
					this._YasAraligi1 = value;
					this.SendPropertyChanged("YasAraligi1");
					this.OnYasAraligi1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="YasAraligi_Urunler", Storage="_Urunlers", ThisKey="YasId", OtherKey="YasId")]
		public EntitySet<Urunler> Urunlers
		{
			get
			{
				return this._Urunlers;
			}
			set
			{
				this._Urunlers.Assign(value);
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
		
		private void attach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.YasAraligi = this;
		}
		
		private void detach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.YasAraligi = null;
		}
	}
	
	public partial class UrunListeleResult
	{
		
		private string _UrunAdi;
		
		private string _CinsiyetAdi;
		
		private string _HediyeAmaci;
		
		private string _YakinlikDerecesi;
		
		private string _YasAraligi;
		
		private string _BurcAdi;
		
		public UrunListeleResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunAdi", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UrunAdi
		{
			get
			{
				return this._UrunAdi;
			}
			set
			{
				if ((this._UrunAdi != value))
				{
					this._UrunAdi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CinsiyetAdi", DbType="NChar(10)")]
		public string CinsiyetAdi
		{
			get
			{
				return this._CinsiyetAdi;
			}
			set
			{
				if ((this._CinsiyetAdi != value))
				{
					this._CinsiyetAdi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HediyeAmaci", DbType="VarChar(50)")]
		public string HediyeAmaci
		{
			get
			{
				return this._HediyeAmaci;
			}
			set
			{
				if ((this._HediyeAmaci != value))
				{
					this._HediyeAmaci = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YakinlikDerecesi", DbType="VarChar(50)")]
		public string YakinlikDerecesi
		{
			get
			{
				return this._YakinlikDerecesi;
			}
			set
			{
				if ((this._YakinlikDerecesi != value))
				{
					this._YakinlikDerecesi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YasAraligi", DbType="VarChar(50)")]
		public string YasAraligi
		{
			get
			{
				return this._YasAraligi;
			}
			set
			{
				if ((this._YasAraligi != value))
				{
					this._YasAraligi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BurcAdi", DbType="VarChar(50)")]
		public string BurcAdi
		{
			get
			{
				return this._BurcAdi;
			}
			set
			{
				if ((this._BurcAdi != value))
				{
					this._BurcAdi = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
