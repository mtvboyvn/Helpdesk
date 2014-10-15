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
	/// Generated Class for Table : DM_SV.
	/// </summary>
	public partial class DM_SV : TableBase
	{
		public DM_SV() : base(){}

		/// <summary>
		/// Là View hay là Table.
		/// </summary>
		public override bool IsView 
		{
			get
			{
				return false;
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

		private int m_APP_TYPE = 0;
		/// <summary>
		/// APP_TYPE.
		/// </summary>
		public int APP_TYPE
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
		private bool m_APP_NAMEUpdated = false;
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
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_APP_NAMEUpdated = true;
				}
			}
		}

		private string m_SERVICES_TYPE;
		private bool m_SERVICES_TYPEUpdated = false;
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
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_SERVICES_TYPEUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM DM_SV " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[COMPUTER_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[APP_TYPE]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[SERVICES_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[APP_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[SERVICES_TYPE]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("COMPUTER_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("APP_TYPE", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SERVICES_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("APP_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SERVICES_TYPE", ProType.OTHER, this.DataManagement));
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

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu theo khóa chính.
		/// </summary>
		public override string SelectStatement()
		{
			return SelectStatement(WhereById());
		}

		/// <summary>
		/// Tạo câu SQL thêm dữ liệu.
		/// </summary>
		public override string InsertStatement()
		{
			StringBuilder sbSQL = new StringBuilder();
			switch(this.DataManagement)
			{
				case DBManagement.Access:
				case DBManagement.SQL:
				case DBManagement.SQLLite:
				default:
				sbSQL.Append("INSERT INTO DM_SV ([COMPUTER_NAME], [APP_TYPE], [SERVICES_NAME], [APP_NAME], [SERVICES_TYPE]) VALUES(").Append("@COMPUTER_NAME").Append(",").Append("@APP_TYPE").Append(",").Append("@SERVICES_NAME").Append(",").Append("@APP_NAME").Append(",").Append("@SERVICES_TYPE").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO DM_SV (COMPUTER_NAME, APP_TYPE, SERVICES_NAME, APP_NAME, SERVICES_TYPE) VALUES(").Append(":COMPUTER_NAME").Append(",").Append(":APP_TYPE").Append(",").Append(":SERVICES_NAME").Append(",").Append(":APP_NAME").Append(",").Append(":SERVICES_TYPE").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE DM_SV SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			switch(this.DataManagement)
			{
				case DBManagement.Access:
					return UpdateFullStatement(WhereClause);
				case DBManagement.SQL:
				case DBManagement.SQLLite:
				default:
				sbSQL.Append(m_APP_NAMEUpdated ? string.Format(",[APP_NAME] = {0}", "@APP_NAME") : string.Empty).Append(m_SERVICES_TYPEUpdated ? string.Format(",[SERVICES_TYPE] = {0}", "@SERVICES_TYPE") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_APP_NAMEUpdated ? string.Format(",APP_NAME = {0}", ":APP_NAME") : string.Empty).Append(m_SERVICES_TYPEUpdated ? string.Format(",SERVICES_TYPE = {0}", ":SERVICES_TYPE") : string.Empty);
				break;
			}
			if(sbSQL.Length > 0)
				return UpdateStatement(sbSQL.ToString().Substring(1), WhereClause);
			else
				return UpdateFullStatement(WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateFullStatement(string WhereClause)
		{
			StringBuilder sbSQL = new StringBuilder();
			switch(this.DataManagement)
			{
				case DBManagement.Access:
				case DBManagement.SQL:
				case DBManagement.SQLLite:
				default:
				sbSQL.AppendFormat("[APP_NAME] = {0}", "@APP_NAME").AppendFormat(",[SERVICES_TYPE] = {0}", "@SERVICES_TYPE");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("APP_NAME = {0}", ":APP_NAME").AppendFormat(",SERVICES_TYPE = {0}", ":SERVICES_TYPE");
				break;
			}
			return UpdateStatement(sbSQL.ToString(), WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL cập nhật liêu theo khóa chính.
		/// </summary>
		public override string UpdateStatement()
		{
			return UpdateStatement(WhereById());
		}

		/// <summary>
		/// Tạo câu SQL xóa dữ liêu.
		/// </summary>
		public override string DeleteStatement(string WhereClause)
		{
			return clsDAL.DeleteString("DM_SV", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
		}

		/// <summary>
		/// Tạo câu SQL xóa dữ liệu theo khóa chính.
		/// </summary>
		public override string DeleteStatement()
		{
			 return DeleteStatement(WhereById());
		}

		/// <summary>
		/// Tạo điều kiện tìm kiếm theo khóa chính.
		/// </summary>
		public override string WhereById()
		{
			StringBuilder sbSQL = new StringBuilder();
			switch(this.DataManagement)
			{
				case DBManagement.Access:
				case DBManagement.SQL:
				case DBManagement.SQLLite:
				default:
				sbSQL.AppendFormat("[COMPUTER_NAME] = {0}", "@COMPUTER_NAME").AppendFormat(" AND [APP_TYPE] = {0}", "@APP_TYPE").AppendFormat(" AND [SERVICES_NAME] = {0}", "@SERVICES_NAME");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("COMPUTER_NAME = {0}", ":COMPUTER_NAME").AppendFormat(" AND APP_TYPE = {0}", ":APP_TYPE").AppendFormat(" AND SERVICES_NAME = {0}", ":SERVICES_NAME");
				break;
			}
			return sbSQL.ToString();
		}

		/// <summary>
		/// Tạo parameter để Delete dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> DeleteParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("COMPUTER_NAME", "WChar", clsDAL.ToDBParam(COMPUTER_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("APP_TYPE", "Integer", clsDAL.ToDBParam(APP_TYPE, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SERVICES_NAME", "WChar", clsDAL.ToDBParam(SERVICES_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("APP_NAME", "WChar", clsDAL.ToDBParam(APP_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SERVICES_TYPE", "WChar", clsDAL.ToDBParam(SERVICES_TYPE, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("COMPUTER_NAME", "WChar", clsDAL.ToDBParam(COMPUTER_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("APP_TYPE", "Integer", clsDAL.ToDBParam(APP_TYPE, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SERVICES_NAME", "WChar", clsDAL.ToDBParam(SERVICES_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("COMPUTER_NAME", "WChar", clsDAL.ToDBParam(COMPUTER_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("APP_TYPE", "Integer", clsDAL.ToDBParam(APP_TYPE, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SERVICES_NAME", "WChar", clsDAL.ToDBParam(SERVICES_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("APP_NAME", "WChar", clsDAL.ToDBParam(APP_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SERVICES_TYPE", "WChar", clsDAL.ToDBParam(SERVICES_TYPE, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}