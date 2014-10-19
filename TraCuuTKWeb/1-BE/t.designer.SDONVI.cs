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
	/// Generated Class for Table : SDONVI.
	/// </summary>
	public partial class SDONVI : TableBase
	{
		public SDONVI() : base(){}

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
		private string m_MA_DONVI;
		/// <summary>
		/// MA_DONVI.
		/// </summary>
		public string MA_DONVI
		{
			get
			{
				return m_MA_DONVI;
			}
			set
			{
				if ((this.m_MA_DONVI != value))
				{
					this.SendPropertyChanging("MA_DONVI");
					this.m_MA_DONVI = value;
					this.SendPropertyChanged("MA_DONVI");
				}
			}
		}

		private string m_TEN_DONVI;
		private bool m_TEN_DONVIUpdated = false;
		/// <summary>
		/// TEN_DONVI.
		/// </summary>
		public string TEN_DONVI
		{
			get
			{
				return m_TEN_DONVI;
			}
			set
			{
				if ((this.m_TEN_DONVI != value))
				{
					this.SendPropertyChanging("TEN_DONVI");
					this.m_TEN_DONVI = value;
					this.SendPropertyChanged("TEN_DONVI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TEN_DONVIUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SDONVI " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[MA_DONVI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TEN_DONVI]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("MA_DONVI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TEN_DONVI", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO SDONVI ([MA_DONVI], [TEN_DONVI]) VALUES(").Append("@MA_DONVI").Append(",").Append("@TEN_DONVI").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO SDONVI (MA_DONVI, TEN_DONVI) VALUES(").Append(":MA_DONVI").Append(",").Append(":TEN_DONVI").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SDONVI SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_TEN_DONVIUpdated ? string.Format(",[TEN_DONVI] = {0}", "@TEN_DONVI") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_TEN_DONVIUpdated ? string.Format(",TEN_DONVI = {0}", ":TEN_DONVI") : string.Empty);
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
				sbSQL.AppendFormat("[TEN_DONVI] = {0}", "@TEN_DONVI");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("TEN_DONVI = {0}", ":TEN_DONVI");
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
			return clsDAL.DeleteString("SDONVI", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[MA_DONVI] = {0}", "@MA_DONVI");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("MA_DONVI = {0}", ":MA_DONVI");
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
			paramList.Add(clsDAL.CreateParameter("MA_DONVI", "WChar", clsDAL.ToDBParam(MA_DONVI, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("TEN_DONVI", "WChar", clsDAL.ToDBParam(TEN_DONVI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("MA_DONVI", "WChar", clsDAL.ToDBParam(MA_DONVI, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("MA_DONVI", "WChar", clsDAL.ToDBParam(MA_DONVI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TEN_DONVI", "WChar", clsDAL.ToDBParam(TEN_DONVI, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}