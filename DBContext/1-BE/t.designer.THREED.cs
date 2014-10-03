using System;
using System.Data;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
namespace tHelpDesk
{
	/// <summary>
	/// Generated Class for Table : THREED.
	/// </summary>
	public partial class THREED : TableBase
	{
		public THREED() : base(){}

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
		private int m_TH_ID;
		/// <summary>
		/// TH_ID.
		/// </summary>
		public int TH_ID
		{
			get
			{
				return m_TH_ID;
			}
			set
			{
				if ((this.m_TH_ID != value))
				{
					this.SendPropertyChanging("TH_ID");
					this.m_TH_ID = value;
					this.SendPropertyChanged("TH_ID");
				}
			}
		}

		private int m_TH_GROUP;
		/// <summary>
		/// TH_GROUP.
		/// </summary>
		public int TH_GROUP
		{
			get
			{
				return m_TH_GROUP;
			}
			set
			{
				if ((this.m_TH_GROUP != value))
				{
					this.SendPropertyChanging("TH_GROUP");
					this.m_TH_GROUP = value;
					this.SendPropertyChanged("TH_GROUP");
				}
			}
		}

		private string m_TH_CREATER;
		private bool m_TH_CREATERUpdated = false;
		/// <summary>
		/// TH_CREATER.
		/// </summary>
		public string TH_CREATER
		{
			get
			{
				return m_TH_CREATER;
			}
			set
			{
				if ((this.m_TH_CREATER != value))
				{
					this.SendPropertyChanging("TH_CREATER");
					this.m_TH_CREATER = value;
					this.SendPropertyChanged("TH_CREATER");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TH_CREATERUpdated = true;
				}
			}
		}

		private DateTime? m_TH_CREATE_DATE;
		private bool m_TH_CREATE_DATEUpdated = false;
		/// <summary>
		/// TH_CREATE_DATE.
		/// </summary>
		public DateTime? TH_CREATE_DATE
		{
			get
			{
				return m_TH_CREATE_DATE;
			}
			set
			{
				if ((this.m_TH_CREATE_DATE != value))
				{
					this.SendPropertyChanging("TH_CREATE_DATE");
					this.m_TH_CREATE_DATE = value;
					this.SendPropertyChanged("TH_CREATE_DATE");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TH_CREATE_DATEUpdated = true;
				}
			}
		}

		private string m_TH_CONTENT;
		private bool m_TH_CONTENTUpdated = false;
		/// <summary>
		/// TH_CONTENT.
		/// </summary>
		public string TH_CONTENT
		{
			get
			{
				return m_TH_CONTENT;
			}
			set
			{
				if ((this.m_TH_CONTENT != value))
				{
					this.SendPropertyChanging("TH_CONTENT");
					this.m_TH_CONTENT = value;
					this.SendPropertyChanged("TH_CONTENT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TH_CONTENTUpdated = true;
				}
			}
		}

		private string m_TH_CONTENT_INDEXER;
		private bool m_TH_CONTENT_INDEXERUpdated = false;
		/// <summary>
		/// TH_CONTENT_INDEXER.
		/// </summary>
		public string TH_CONTENT_INDEXER
		{
			get
			{
				return m_TH_CONTENT_INDEXER;
			}
			set
			{
				if ((this.m_TH_CONTENT_INDEXER != value))
				{
					this.SendPropertyChanging("TH_CONTENT_INDEXER");
					this.m_TH_CONTENT_INDEXER = value;
					this.SendPropertyChanged("TH_CONTENT_INDEXER");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TH_CONTENT_INDEXERUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM THREED " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[TH_ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TH_GROUP]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TH_CREATER]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TH_CREATE_DATE]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TH_CONTENT]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TH_CONTENT_INDEXER]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("TH_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_GROUP", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_CREATER", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_CREATE_DATE", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_CONTENT", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TH_CONTENT_INDEXER", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO THREED ([TH_ID], [TH_GROUP], [TH_CREATER], [TH_CREATE_DATE], [TH_CONTENT], [TH_CONTENT_INDEXER]) VALUES(").Append("@TH_ID").Append(",").Append("@TH_GROUP").Append(",").Append("@TH_CREATER").Append(",").Append("@TH_CREATE_DATE").Append(",").Append("@TH_CONTENT").Append(",").Append("@TH_CONTENT_INDEXER").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO THREED (TH_ID, TH_GROUP, TH_CREATER, TH_CREATE_DATE, TH_CONTENT, TH_CONTENT_INDEXER) VALUES(").Append(":TH_ID").Append(",").Append(":TH_GROUP").Append(",").Append(":TH_CREATER").Append(",").Append(":TH_CREATE_DATE").Append(",").Append(":TH_CONTENT").Append(",").Append(":TH_CONTENT_INDEXER").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE THREED SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				case DBManagement.SQL:
				case DBManagement.SQLLite:
				default:
				sbSQL.Append(m_TH_CREATERUpdated ? string.Format(",[TH_CREATER] = {0}", "@TH_CREATER") : string.Empty).Append(m_TH_CREATE_DATEUpdated ? string.Format(",[TH_CREATE_DATE] = {0}", "@TH_CREATE_DATE") : string.Empty).Append(m_TH_CONTENTUpdated ? string.Format(",[TH_CONTENT] = {0}", "@TH_CONTENT") : string.Empty).Append(m_TH_CONTENT_INDEXERUpdated ? string.Format(",[TH_CONTENT_INDEXER] = {0}", "@TH_CONTENT_INDEXER") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_TH_CREATERUpdated ? string.Format(",TH_CREATER = {0}", ":TH_CREATER") : string.Empty).Append(m_TH_CREATE_DATEUpdated ? string.Format(",TH_CREATE_DATE = {0}", ":TH_CREATE_DATE") : string.Empty).Append(m_TH_CONTENTUpdated ? string.Format(",TH_CONTENT = {0}", ":TH_CONTENT") : string.Empty).Append(m_TH_CONTENT_INDEXERUpdated ? string.Format(",TH_CONTENT_INDEXER = {0}", ":TH_CONTENT_INDEXER") : string.Empty);
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
				sbSQL.AppendFormat("[TH_CREATER] = {0}", "@TH_CREATER").AppendFormat(",[TH_CREATE_DATE] = {0}", "@TH_CREATE_DATE").AppendFormat(",[TH_CONTENT] = {0}", "@TH_CONTENT").AppendFormat(",[TH_CONTENT_INDEXER] = {0}", "@TH_CONTENT_INDEXER");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("TH_CREATER = {0}", ":TH_CREATER").AppendFormat(",TH_CREATE_DATE = {0}", ":TH_CREATE_DATE").AppendFormat(",TH_CONTENT = {0}", ":TH_CONTENT").AppendFormat(",TH_CONTENT_INDEXER = {0}", ":TH_CONTENT_INDEXER");
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
			return clsDAL.DeleteString("THREED", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[TH_ID] = {0}", "@TH_ID").AppendFormat(" AND [TH_GROUP] = {0}", "@TH_GROUP");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("TH_ID = {0}", ":TH_ID").AppendFormat(" AND TH_GROUP = {0}", ":TH_GROUP");
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
			paramList.Add(clsDAL.CreateParameter("TH_ID", "SmallInt", clsDAL.ToDBParam(TH_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_GROUP", "SmallInt", clsDAL.ToDBParam(TH_GROUP, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			if (m_TH_CREATERUpdated == true) paramList.Add(clsDAL.CreateParameter("TH_CREATER", "WChar", clsDAL.ToDBParam(TH_CREATER, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_TH_CREATE_DATEUpdated == true) paramList.Add(clsDAL.CreateParameter("TH_CREATE_DATE", "Date", clsDAL.ToDBParam(TH_CREATE_DATE, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			if (m_TH_CONTENTUpdated == true) paramList.Add(clsDAL.CreateParameter("TH_CONTENT", "WChar", clsDAL.ToDBParam(TH_CONTENT, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_TH_CONTENT_INDEXERUpdated == true) paramList.Add(clsDAL.CreateParameter("TH_CONTENT_INDEXER", "WChar", clsDAL.ToDBParam(TH_CONTENT_INDEXER, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_ID", "SmallInt", clsDAL.ToDBParam(TH_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_GROUP", "SmallInt", clsDAL.ToDBParam(TH_GROUP, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("TH_ID", "SmallInt", clsDAL.ToDBParam(TH_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_GROUP", "SmallInt", clsDAL.ToDBParam(TH_GROUP, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_CREATER", "WChar", clsDAL.ToDBParam(TH_CREATER, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_CREATE_DATE", "Date", clsDAL.ToDBParam(TH_CREATE_DATE, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_CONTENT", "WChar", clsDAL.ToDBParam(TH_CONTENT, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TH_CONTENT_INDEXER", "WChar", clsDAL.ToDBParam(TH_CONTENT_INDEXER, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}