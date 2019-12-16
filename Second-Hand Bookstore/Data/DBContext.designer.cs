﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BookstoreDB")]
	public partial class DBContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBooks(Books instance);
    partial void UpdateBooks(Books instance);
    partial void DeleteBooks(Books instance);
    partial void InsertSuppliers(Suppliers instance);
    partial void UpdateSuppliers(Suppliers instance);
    partial void DeleteSuppliers(Suppliers instance);
    partial void InsertClients(Clients instance);
    partial void UpdateClients(Clients instance);
    partial void DeleteClients(Clients instance);
    partial void InsertEvents(Events instance);
    partial void UpdateEvents(Events instance);
    partial void DeleteEvents(Events instance);
    #endregion
		
		public DBContextDataContext() : 
				base(global::Data.Properties.Settings.Default.BookstoreDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Books> Books
		{
			get
			{
				return this.GetTable<Books>();
			}
		}
		
		public System.Data.Linq.Table<Suppliers> Suppliers
		{
			get
			{
				return this.GetTable<Suppliers>();
			}
		}
		
		public System.Data.Linq.Table<Clients> Clients
		{
			get
			{
				return this.GetTable<Clients>();
			}
		}
		
		public System.Data.Linq.Table<Events> Events
		{
			get
			{
				return this.GetTable<Events>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Books : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _b_name;
		
		private string _b_author;
		
		private System.Nullable<double> _price;
		
		private System.Nullable<int> _amount;
		
		private System.Nullable<bool> _isNew;
		
		private System.Nullable<int> _supplierID;
		
		private EntitySet<Events> _Events;
		
		private EntityRef<Suppliers> _Suppliers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onb_nameChanging(string value);
    partial void Onb_nameChanged();
    partial void Onb_authorChanging(string value);
    partial void Onb_authorChanged();
    partial void OnpriceChanging(System.Nullable<double> value);
    partial void OnpriceChanged();
    partial void OnamountChanging(System.Nullable<int> value);
    partial void OnamountChanged();
    partial void OnisNewChanging(System.Nullable<bool> value);
    partial void OnisNewChanged();
    partial void OnsupplierIDChanging(System.Nullable<int> value);
    partial void OnsupplierIDChanged();
    #endregion
		
		public Books()
		{
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
			this._Suppliers = default(EntityRef<Suppliers>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_b_name", DbType="VarChar(255)")]
		public string b_name
		{
			get
			{
				return this._b_name;
			}
			set
			{
				if ((this._b_name != value))
				{
					this.Onb_nameChanging(value);
					this.SendPropertyChanging();
					this._b_name = value;
					this.SendPropertyChanged("b_name");
					this.Onb_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_b_author", DbType="VarChar(255)")]
		public string b_author
		{
			get
			{
				return this._b_author;
			}
			set
			{
				if ((this._b_author != value))
				{
					this.Onb_authorChanging(value);
					this.SendPropertyChanging();
					this._b_author = value;
					this.SendPropertyChanged("b_author");
					this.Onb_authorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float")]
		public System.Nullable<double> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int")]
		public System.Nullable<int> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isNew", DbType="Bit")]
		public System.Nullable<bool> isNew
		{
			get
			{
				return this._isNew;
			}
			set
			{
				if ((this._isNew != value))
				{
					this.OnisNewChanging(value);
					this.SendPropertyChanging();
					this._isNew = value;
					this.SendPropertyChanged("isNew");
					this.OnisNewChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supplierID", DbType="Int")]
		public System.Nullable<int> supplierID
		{
			get
			{
				return this._supplierID;
			}
			set
			{
				if ((this._supplierID != value))
				{
					if (this._Suppliers.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsupplierIDChanging(value);
					this.SendPropertyChanging();
					this._supplierID = value;
					this.SendPropertyChanged("supplierID");
					this.OnsupplierIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Books_Events", Storage="_Events", ThisKey="id", OtherKey="book_id")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Books", Storage="_Suppliers", ThisKey="supplierID", OtherKey="id", IsForeignKey=true)]
		public Suppliers Suppliers
		{
			get
			{
				return this._Suppliers.Entity;
			}
			set
			{
				Suppliers previousValue = this._Suppliers.Entity;
				if (((previousValue != value) 
							|| (this._Suppliers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Suppliers.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Suppliers.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._supplierID = value.id;
					}
					else
					{
						this._supplierID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Suppliers");
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
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Books = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Books = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suppliers")]
	public partial class Suppliers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _s_name;
		
		private string _nip;
		
		private EntitySet<Books> _Books;
		
		private EntitySet<Events> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ons_nameChanging(string value);
    partial void Ons_nameChanged();
    partial void OnnipChanging(string value);
    partial void OnnipChanged();
    #endregion
		
		public Suppliers()
		{
			this._Books = new EntitySet<Books>(new Action<Books>(this.attach_Books), new Action<Books>(this.detach_Books));
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_s_name", DbType="VarChar(255)")]
		public string s_name
		{
			get
			{
				return this._s_name;
			}
			set
			{
				if ((this._s_name != value))
				{
					this.Ons_nameChanging(value);
					this.SendPropertyChanging();
					this._s_name = value;
					this.SendPropertyChanged("s_name");
					this.Ons_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nip", DbType="VarChar(15)")]
		public string nip
		{
			get
			{
				return this._nip;
			}
			set
			{
				if ((this._nip != value))
				{
					this.OnnipChanging(value);
					this.SendPropertyChanging();
					this._nip = value;
					this.SendPropertyChanged("nip");
					this.OnnipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Books", Storage="_Books", ThisKey="id", OtherKey="supplierID")]
		public EntitySet<Books> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Events", Storage="_Events", ThisKey="id", OtherKey="supplier_id")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Books(Books entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = this;
		}
		
		private void detach_Books(Books entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = null;
		}
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clients")]
	public partial class Clients : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _c_name;
		
		private string _c_surname;
		
		private System.Nullable<System.DateTime> _creation_date;
		
		private EntitySet<Events> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onc_nameChanging(string value);
    partial void Onc_nameChanged();
    partial void Onc_surnameChanging(string value);
    partial void Onc_surnameChanged();
    partial void Oncreation_dateChanging(System.Nullable<System.DateTime> value);
    partial void Oncreation_dateChanged();
    #endregion
		
		public Clients()
		{
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_c_name", DbType="VarChar(255)")]
		public string c_name
		{
			get
			{
				return this._c_name;
			}
			set
			{
				if ((this._c_name != value))
				{
					this.Onc_nameChanging(value);
					this.SendPropertyChanging();
					this._c_name = value;
					this.SendPropertyChanged("c_name");
					this.Onc_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_c_surname", DbType="VarChar(255)")]
		public string c_surname
		{
			get
			{
				return this._c_surname;
			}
			set
			{
				if ((this._c_surname != value))
				{
					this.Onc_surnameChanging(value);
					this.SendPropertyChanging();
					this._c_surname = value;
					this.SendPropertyChanged("c_surname");
					this.Onc_surnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creation_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> creation_date
		{
			get
			{
				return this._creation_date;
			}
			set
			{
				if ((this._creation_date != value))
				{
					this.Oncreation_dateChanging(value);
					this.SendPropertyChanging();
					this._creation_date = value;
					this.SendPropertyChanged("creation_date");
					this.Oncreation_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clients_Events", Storage="_Events", ThisKey="id", OtherKey="client_id")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Clients = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Clients = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Events : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<double> _account_balance;
		
		private System.Nullable<System.DateTime> _event_time;
		
		private System.Nullable<int> _book_id;
		
		private System.Nullable<int> _client_id;
		
		private System.Nullable<int> _supplier_id;
		
		private EntityRef<Books> _Books;
		
		private EntityRef<Clients> _Clients;
		
		private EntityRef<Suppliers> _Suppliers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onaccount_balanceChanging(System.Nullable<double> value);
    partial void Onaccount_balanceChanged();
    partial void Onevent_timeChanging(System.Nullable<System.DateTime> value);
    partial void Onevent_timeChanged();
    partial void Onbook_idChanging(System.Nullable<int> value);
    partial void Onbook_idChanged();
    partial void Onclient_idChanging(System.Nullable<int> value);
    partial void Onclient_idChanged();
    partial void Onsupplier_idChanging(System.Nullable<int> value);
    partial void Onsupplier_idChanged();
    #endregion
		
		public Events()
		{
			this._Books = default(EntityRef<Books>);
			this._Clients = default(EntityRef<Clients>);
			this._Suppliers = default(EntityRef<Suppliers>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_balance", DbType="Float")]
		public System.Nullable<double> account_balance
		{
			get
			{
				return this._account_balance;
			}
			set
			{
				if ((this._account_balance != value))
				{
					this.Onaccount_balanceChanging(value);
					this.SendPropertyChanging();
					this._account_balance = value;
					this.SendPropertyChanged("account_balance");
					this.Onaccount_balanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_event_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> event_time
		{
			get
			{
				return this._event_time;
			}
			set
			{
				if ((this._event_time != value))
				{
					this.Onevent_timeChanging(value);
					this.SendPropertyChanging();
					this._event_time = value;
					this.SendPropertyChanged("event_time");
					this.Onevent_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_book_id", DbType="Int")]
		public System.Nullable<int> book_id
		{
			get
			{
				return this._book_id;
			}
			set
			{
				if ((this._book_id != value))
				{
					if (this._Books.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onbook_idChanging(value);
					this.SendPropertyChanging();
					this._book_id = value;
					this.SendPropertyChanged("book_id");
					this.Onbook_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_client_id", DbType="Int")]
		public System.Nullable<int> client_id
		{
			get
			{
				return this._client_id;
			}
			set
			{
				if ((this._client_id != value))
				{
					if (this._Clients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onclient_idChanging(value);
					this.SendPropertyChanging();
					this._client_id = value;
					this.SendPropertyChanged("client_id");
					this.Onclient_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supplier_id", DbType="Int")]
		public System.Nullable<int> supplier_id
		{
			get
			{
				return this._supplier_id;
			}
			set
			{
				if ((this._supplier_id != value))
				{
					if (this._Suppliers.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsupplier_idChanging(value);
					this.SendPropertyChanging();
					this._supplier_id = value;
					this.SendPropertyChanged("supplier_id");
					this.Onsupplier_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Books_Events", Storage="_Books", ThisKey="book_id", OtherKey="id", IsForeignKey=true)]
		public Books Books
		{
			get
			{
				return this._Books.Entity;
			}
			set
			{
				Books previousValue = this._Books.Entity;
				if (((previousValue != value) 
							|| (this._Books.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Books.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._Books.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._book_id = value.id;
					}
					else
					{
						this._book_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Books");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clients_Events", Storage="_Clients", ThisKey="client_id", OtherKey="id", IsForeignKey=true)]
		public Clients Clients
		{
			get
			{
				return this._Clients.Entity;
			}
			set
			{
				Clients previousValue = this._Clients.Entity;
				if (((previousValue != value) 
							|| (this._Clients.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Clients.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._Clients.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._client_id = value.id;
					}
					else
					{
						this._client_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Clients");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Events", Storage="_Suppliers", ThisKey="supplier_id", OtherKey="id", IsForeignKey=true)]
		public Suppliers Suppliers
		{
			get
			{
				return this._Suppliers.Entity;
			}
			set
			{
				Suppliers previousValue = this._Suppliers.Entity;
				if (((previousValue != value) 
							|| (this._Suppliers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Suppliers.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._Suppliers.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._supplier_id = value.id;
					}
					else
					{
						this._supplier_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Suppliers");
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