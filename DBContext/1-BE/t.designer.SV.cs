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
	/// Generated Class for Table : SV.
	/// </summary>
	public partial class SV : TableBase
	{
		public SV() : base(){}

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
		private int m_ID = 0;
		/// <summary>
		/// ID.
		/// </summary>
		public int ID
		{
			get
			{
				return m_ID;
			}
			set
			{
				if ((this.m_ID != value))
				{
					this.SendPropertyChanging("ID");
					this.m_ID = value;
					this.SendPropertyChanged("ID");
				}
			}
		}

		private string m_COMPUTER_NAME;
		private bool m_COMPUTER_NAMEUpdated = false;
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
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_COMPUTER_NAMEUpdated = true;
				}
			}
		}

		private string m_SERVICES_NAME;
		private bool m_SERVICES_NAMEUpdated = false;
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
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_SERVICES_NAMEUpdated = true;
				}
			}
		}

		private string m_APP_TYPE;
		private bool m_APP_TYPEUpdated = false;
		/// <summary>
		/// APP_TYPE.
		/// </summary>
		public string APP_TYPE
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
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_APP_TYPEUpdated = true;
				}
			}
		}

		private DateTime m_NGAY_INSERT;
		private bool m_NGAY_INSERTUpdated = false;
		/// <summary>
		/// NGAY_INSERT.
		/// </summary>
		public DateTime NGAY_INSERT
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
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NGAY_INSERTUpdated = true;
				}
			}
		}

		private int? m_TRANG_THAI = 0;
		private bool m_TRANG_THAIUpdated = false;
		/// <summary>
		/// TRANG_THAI.
		/// </summary>
		public int? TRANG_THAI
		{
			get
			{
				return m_TRANG_THAI;
			}
			set
			{
				if ((this.m_TRANG_THAI != value))
				{
					this.SendPropertyChanging("TRANG_THAI");
					this.m_TRANG_THAI = value;
					this.SendPropertyChanged("TRANG_THAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TRANG_THAIUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SV " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[COMPUTER_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[SERVICES_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[APP_TYPE]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[NGAY_INSERT]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TRANG_THAI]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("COMPUTER_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SERVICES_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("APP_TYPE", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NGAY_INSERT", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TRANG_THAI", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO SV ([ID], [COMPUTER_NAME], [SERVICES_NAME], [APP_TYPE], [NGAY_INSERT], [TRANG_THAI]) VALUES(").Append("@ID").Append(",").Append("@COMPUTER_NAME").Append(",").Append("@SERVICES_NAME").Append(",").Append("@APP_TYPE").Append(",").Append("@NGAY_INSERT").Append(",").Append("@TRANG_THAI").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO SV (ID, COMPUTER_NAME, SERVICES_NAME, APP_TYPE, NGAY_INSERT, TRANG_THAI) VALUES(").Append(":ID").Append(",").Append(":COMPUTER_NAME").Append(",").Append(":SERVICES_NAME").Append(",").Append(":APP_TYPE").Append(",").Append(":NGAY_INSERT").Append(",").Append(":TRANG_THAI").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SV SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_COMPUTER_NAMEUpdated ? string.Format(",[COMPUTER_NAME] = {0}", "@COMPUTER_NAME") : string.Empty).Append(m_SERVICES_NAMEUpdated ? string.Format(",[SERVICES_NAME] = {0}", "@SERVICES_NAME") : string.Empty).Append(m_APP_TYPEUpdated ? string.Format(",[APP_TYPE] = {0}", "@APP_TYPE") : string.Empty).Append(m_NGAY_INSERTUpdated ? string.Format(",[NGAY_INSERT] = {0}", "@NGAY_INSERT") : string.Empty).Append(m_TRANG_THAIUpdated ? string.Format(",[TRANG_THAI] = {0}", "@TRANG_THAI") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_COMPUTER_NAMEUpdated ? string.Format(",COMPUTER_NAME = {0}", ":COMPUTER_NAME") : string.Empty).Append(m_SERVICES_NAMEUpdated ? string.Format(",SERVICES_NAME = {0}", ":SERVICES_NAME") : string.Empty).Append(m_APP_TYPEUpdated ? string.Format(",APP_TYPE = {0}", ":APP_TYPE") : string.Empty).Append(m_NGAY_INSERTUpdated ? string.Format(",NGAY_INSERT = {0}", ":NGAY_INSERT") : string.Empty).Append(m_TRANG_THAIUpdated ? string.Format(",TRANG_THAI = {0}", ":TRANG_THAI") : string.Empty);
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
				sbSQL.AppendFormat("[COMPUTER_NAME] = {0}", "@COMPUTER_NAME").AppendFormat(",[SERVICES_NAME] = {0}", "@SERVICES_NAME").AppendFormat(",[APP_TYPE] = {0}", "@APP_TYPE").AppendFormat(",[NGAY_INSERT] = {0}", "@NGAY_INSERT").AppendFormat(",[TRANG_THAI] = {0}", "@TRANG_THAI");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("COMPUTER_NAME = {0}", ":COMPUTER_NAME").AppendFormat(",SERVICES_NAME = {0}", ":SERVICES_NAME").AppendFormat(",APP_TYPE = {0}", ":APP_TYPE").AppendFormat(",NGAY_INSERT = {0}", ":NGAY_INSERT").AppendFormat(",TRANG_THAI = {0}", ":TRANG_THAI");
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
			return clsDAL.DeleteString("SV", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[ID] = {0}", "@ID");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("ID = {0}", ":ID");
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
			paramList.Add(clsDAL.CreateParameter("ID", "Integer", clsDAL.ToDBParam(ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("COMPUTER_NAME", "WChar", clsDAL.ToDBParam(COMPUTER_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SERVICES_NAME", "WChar", clsDAL.ToDBParam(SERVICES_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("APP_TYPE", "WChar", clsDAL.ToDBParam(APP_TYPE, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAY_INSERT", "Date", clsDAL.ToDBParam(NGAY_INSERT, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TRANG_THAI", "Integer", clsDAL.ToDBParam(TRANG_THAI, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("ID", "Integer", clsDAL.ToDBParam(ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("ID", "Integer", clsDAL.ToDBParam(ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("COMPUTER_NAME", "WChar", clsDAL.ToDBParam(COMPUTER_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SERVICES_NAME", "WChar", clsDAL.ToDBParam(SERVICES_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("APP_TYPE", "WChar", clsDAL.ToDBParam(APP_TYPE, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAY_INSERT", "Date", clsDAL.ToDBParam(NGAY_INSERT, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TRANG_THAI", "Integer", clsDAL.ToDBParam(TRANG_THAI, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}