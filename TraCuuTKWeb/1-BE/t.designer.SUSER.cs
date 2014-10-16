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
	/// Generated Class for Table : SUSER.
	/// </summary>
	public partial class SUSER : TableBase
	{
		public SUSER() : base(){}

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
		private string m_ST_USERNAME;
		/// <summary>
		/// ST_USERNAME.
		/// </summary>
		public string ST_USERNAME
		{
			get
			{
				return m_ST_USERNAME;
			}
			set
			{
				if ((this.m_ST_USERNAME != value))
				{
					this.SendPropertyChanging("ST_USERNAME");
					this.m_ST_USERNAME = value;
					this.SendPropertyChanged("ST_USERNAME");
				}
			}
		}

		private string m_ST_PASSWORD;
		private bool m_ST_PASSWORDUpdated = false;
		/// <summary>
		/// ST_PASSWORD.
		/// </summary>
		public string ST_PASSWORD
		{
			get
			{
				return m_ST_PASSWORD;
			}
			set
			{
				if ((this.m_ST_PASSWORD != value))
				{
					this.SendPropertyChanging("ST_PASSWORD");
					this.m_ST_PASSWORD = value;
					this.SendPropertyChanged("ST_PASSWORD");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_ST_PASSWORDUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SUSER " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[ST_USERNAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[ST_PASSWORD]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("ST_USERNAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("ST_PASSWORD", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO SUSER ([ST_USERNAME], [ST_PASSWORD]) VALUES(").Append("@ST_USERNAME").Append(",").Append("@ST_PASSWORD").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO SUSER (ST_USERNAME, ST_PASSWORD) VALUES(").Append(":ST_USERNAME").Append(",").Append(":ST_PASSWORD").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SUSER SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_ST_PASSWORDUpdated ? string.Format(",[ST_PASSWORD] = {0}", "@ST_PASSWORD") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_ST_PASSWORDUpdated ? string.Format(",ST_PASSWORD = {0}", ":ST_PASSWORD") : string.Empty);
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
				sbSQL.AppendFormat("[ST_PASSWORD] = {0}", "@ST_PASSWORD");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("ST_PASSWORD = {0}", ":ST_PASSWORD");
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
			return clsDAL.DeleteString("SUSER", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[ST_USERNAME] = {0}", "@ST_USERNAME");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("ST_USERNAME = {0}", ":ST_USERNAME");
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
			paramList.Add(clsDAL.CreateParameter("ST_USERNAME", "WChar", clsDAL.ToDBParam(ST_USERNAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("ST_PASSWORD", "WChar", clsDAL.ToDBParam(ST_PASSWORD, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("ST_USERNAME", "WChar", clsDAL.ToDBParam(ST_USERNAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("ST_USERNAME", "WChar", clsDAL.ToDBParam(ST_USERNAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("ST_PASSWORD", "WChar", clsDAL.ToDBParam(ST_PASSWORD, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}