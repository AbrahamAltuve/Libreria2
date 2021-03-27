﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libreria2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ventas")]
	public partial class ServicioLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertempresa(empresa instance);
    partial void Updateempresa(empresa instance);
    partial void Deleteempresa(empresa instance);
    partial void Insertpersona(persona instance);
    partial void Updatepersona(persona instance);
    partial void Deletepersona(persona instance);
    #endregion
		
		public ServicioLinqDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ventasConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ServicioLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ServicioLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ServicioLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ServicioLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<empresa> empresa
		{
			get
			{
				return this.GetTable<empresa>();
			}
		}
		
		public System.Data.Linq.Table<persona> persona
		{
			get
			{
				return this.GetTable<persona>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.empresa")]
	public partial class empresa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _identificacion;
		
		private string _razonSocial;
		
		private string _direccion;
		
		private string _telefono;
		
		private string _correoContacto;
		
		private string _represemtanteLegal;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidentificacionChanging(string value);
    partial void OnidentificacionChanged();
    partial void OnrazonSocialChanging(string value);
    partial void OnrazonSocialChanged();
    partial void OndireccionChanging(string value);
    partial void OndireccionChanged();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OncorreoContactoChanging(string value);
    partial void OncorreoContactoChanged();
    partial void OnrepresemtanteLegalChanging(string value);
    partial void OnrepresemtanteLegalChanged();
    #endregion
		
		public empresa()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identificacion", DbType="NChar(12)")]
		public string identificacion
		{
			get
			{
				return this._identificacion;
			}
			set
			{
				if ((this._identificacion != value))
				{
					this.OnidentificacionChanging(value);
					this.SendPropertyChanging();
					this._identificacion = value;
					this.SendPropertyChanged("identificacion");
					this.OnidentificacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_razonSocial", DbType="NChar(15)")]
		public string razonSocial
		{
			get
			{
				return this._razonSocial;
			}
			set
			{
				if ((this._razonSocial != value))
				{
					this.OnrazonSocialChanging(value);
					this.SendPropertyChanging();
					this._razonSocial = value;
					this.SendPropertyChanged("razonSocial");
					this.OnrazonSocialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="NChar(30)")]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this.OndireccionChanging(value);
					this.SendPropertyChanging();
					this._direccion = value;
					this.SendPropertyChanged("direccion");
					this.OndireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="NChar(12)")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correoContacto", DbType="NChar(20)")]
		public string correoContacto
		{
			get
			{
				return this._correoContacto;
			}
			set
			{
				if ((this._correoContacto != value))
				{
					this.OncorreoContactoChanging(value);
					this.SendPropertyChanging();
					this._correoContacto = value;
					this.SendPropertyChanged("correoContacto");
					this.OncorreoContactoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_represemtanteLegal", DbType="NChar(30)")]
		public string represemtanteLegal
		{
			get
			{
				return this._represemtanteLegal;
			}
			set
			{
				if ((this._represemtanteLegal != value))
				{
					this.OnrepresemtanteLegalChanging(value);
					this.SendPropertyChanging();
					this._represemtanteLegal = value;
					this.SendPropertyChanged("represemtanteLegal");
					this.OnrepresemtanteLegalChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.persona")]
	public partial class persona : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private string _documento;
		
		private System.Nullable<int> _edad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OndocumentoChanging(string value);
    partial void OndocumentoChanged();
    partial void OnedadChanging(System.Nullable<int> value);
    partial void OnedadChanged();
    #endregion
		
		public persona()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NChar(20)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_documento", DbType="NChar(20)")]
		public string documento
		{
			get
			{
				return this._documento;
			}
			set
			{
				if ((this._documento != value))
				{
					this.OndocumentoChanging(value);
					this.SendPropertyChanging();
					this._documento = value;
					this.SendPropertyChanged("documento");
					this.OndocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_edad", DbType="Int")]
		public System.Nullable<int> edad
		{
			get
			{
				return this._edad;
			}
			set
			{
				if ((this._edad != value))
				{
					this.OnedadChanging(value);
					this.SendPropertyChanging();
					this._edad = value;
					this.SendPropertyChanged("edad");
					this.OnedadChanged();
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
