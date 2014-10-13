using System;
using System.Data;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
namespace t
{
	/// <summary>
	/// Generated Class for Table : V1_SERVICES_MONITORING.
	/// </summary>
	public partial class V1_SERVICES_MONITORING : ViewBase
	{
		public V1_SERVICES_MONITORING() : base(){}

		/// <summary>
		/// Là View hay là Table.
		/// </summary>
		public override bool IsView 
		{
			get
			{
				return true;
			}
		}
		private string m_COMPUTER_NAME;
		/// <summary>
		/// COMPUTER_NAME.
		/// </summary>
		public string COMPUTER_NAME
		{
			get
			{
				return m_COMPUTER_NAME;
			}
			set
			{
				if ((this.m_COMPUTER_NAME != value))
				{
					this.SendPropertyChanging("COMPUTER_NAME");
					this.m_COMPUTER_NAME = value;
					this.SendPropertyChanged("COMPUTER_NAME");
				}
			}
		}

		private int? m_APP_TYPE;
		/// <summary>
		/// APP_TYPE.
		/// </summary>
		public int? APP_TYPE
		{
			get
			{
				return m_APP_TYPE;
			}
			set
			{
				if ((this.m_APP_TYPE != value))
				{
					this.SendPropertyChanging("APP_TYPE");
					this.m_APP_TYPE = value;
					this.SendPropertyChanged("APP_TYPE");
				}
			}
		}

		private string m_SERVICES_NAME;
		/// <summary>
		/// SERVICES_NAME.
		/// </summary>
		public string SERVICES_NAME
		{
			get
			{
				return m_SERVICES_NAME;
			}
			set
			{
				if ((this.m_SERVICES_NAME != value))
				{
					this.SendPropertyChanging("SERVICES_NAME");
					this.m_SERVICES_NAME = value;
					this.SendPropertyChanged("SERVICES_NAME");
				}
			}
		}

		private string m_APP_NAME;
		/// <summary>
		/// APP_NAME.
		/// </summary>
		public string APP_NAME
		{
			get
			{
				return m_APP_NAME;
			}
			set
			{
				if ((this.m_APP_NAME != value))
				{
					this.SendPropertyChanging("APP_NAME");
					this.m_APP_NAME = value;
					this.SendPropertyChanged("APP_NAME");
				}
			}
		}

		private string m_SERVICES_TYPE;
		/// <summary>
		/// SERVICES_TYPE.
		/// </summary>
		public string SERVICES_TYPE
		{
			get
			{
				return m_SERVICES_TYPE;
			}
			set
			{
				if ((this.m_SERVICES_TYPE != value))
				{
					this.SendPropertyChanging("SERVICES_TYPE");
					this.m_SERVICES_TYPE = value;
					this.SendPropertyChanged("SERVICES_TYPE");
				}
			}
		}

		private DateTime? m_NGAY_INSERT;
		/// <summary>
		/// NGAY_INSERT.
		/// </summary>
		public DateTime? NGAY_INSERT
		{
			get
			{
				return m_NGAY_INSERT;
			}
			set
			{
				if ((this.m_NGAY_INSERT != value))
				{
					this.SendPropertyChanging("NGAY_INSERT");
					this.m_NGAY_INSERT = value;
					this.SendPropertyChanged("NGAY_INSERT");
				}
			}
		}

		private string m_COLOR;
		/// <summary>
		/// COLOR.
		/// </summary>
		public string COLOR
		{
			get
			{
				return m_COLOR;
			}
			set
			{
				if ((this.m_COLOR != value))
				{
					this.SendPropertyChanging("COLOR");
					this.m_COLOR = value;
					this.SendPropertyChanged("COLOR");
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM V1_SERVICES_MONITORING " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause, string OrderClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			switch(this.DataManagement)
			{
				case DBManagement.Access:
				case DBManagement.SQL:
				case DBManagement.SQLLite:
				default:
				sbSQL.Append(clsDAL.SelectField("[COMPUTER_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[APP_TYPE]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[SERVICES_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[APP_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[SERVICES_TYPE]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[NGAY_INSERT]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[COLOR]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("COMPUTER_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("APP_TYPE", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SERVICES_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("APP_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SERVICES_TYPE", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NGAY_INSERT", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("COLOR", ProType.OTHER, this.DataManagement));
				break;
			}
			return SelectStatement(sbSQL.ToString(), WhereClause, OrderClause);
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string WhereClause)
		{
			return SelectStatement(WhereClause, string.Empty);
		}
	}
}