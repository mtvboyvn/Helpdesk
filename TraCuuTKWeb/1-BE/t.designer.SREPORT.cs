﻿using System;
using System.Data;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
namespace t
{
	/// <summary>
	/// Generated Class for Table : SREPORT.
	/// </summary>
	public partial class SREPORT : TableBase
	{
		public SREPORT() : base(){}

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
		private int m_RP_ID = 0;
		/// <summary>
		/// ID yêu cầu trích báo cáo.
		/// </summary>
		public int RP_ID
		{
			get
			{
				return m_RP_ID;
			}
			set
			{
				if ((this.m_RP_ID != value))
				{
					this.SendPropertyChanging("RP_ID");
					this.m_RP_ID = value;
					this.SendPropertyChanged("RP_ID");
				}
			}
		}

		private string m_RP_USERNAME;
		/// <summary>
		/// Tài khoản người yêu cầu trích báo cáo.
		/// </summary>
		public string RP_USERNAME
		{
			get
			{
				return m_RP_USERNAME;
			}
			set
			{
				if ((this.m_RP_USERNAME != value))
				{
					this.SendPropertyChanging("RP_USERNAME");
					this.m_RP_USERNAME = value;
					this.SendPropertyChanged("RP_USERNAME");
				}
			}
		}

		private DateTime? m_RP_CREATEDATE;
		private bool m_RP_CREATEDATEUpdated = false;
		/// <summary>
		/// Ngày giờ yêu cầu trích báo cáo.
		/// </summary>
		public DateTime? RP_CREATEDATE
		{
			get
			{
				return m_RP_CREATEDATE;
			}
			set
			{
				if ((this.m_RP_CREATEDATE != value))
				{
					this.SendPropertyChanging("RP_CREATEDATE");
					this.m_RP_CREATEDATE = value;
					this.SendPropertyChanged("RP_CREATEDATE");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_RP_CREATEDATEUpdated = true;
				}
			}
		}

		private string m_RP_DISPLAY;
		private bool m_RP_DISPLAYUpdated = false;
		/// <summary>
		/// Nội dung các điều kiện tìm kiếm để hiển thị cho người dùng: Số TK:123, Mã HQ:E03E.
		/// </summary>
		public string RP_DISPLAY
		{
			get
			{
				return m_RP_DISPLAY;
			}
			set
			{
				if ((this.m_RP_DISPLAY != value))
				{
					this.SendPropertyChanging("RP_DISPLAY");
					this.m_RP_DISPLAY = value;
					this.SendPropertyChanged("RP_DISPLAY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_RP_DISPLAYUpdated = true;
				}
			}
		}

		private string m_RP_QUERY;
		private bool m_RP_QUERYUpdated = false;
		/// <summary>
		/// SQL QUERY báo cáo, hệ thống tạo ra, người dùng ko nhìn thấy.
		/// </summary>
		public string RP_QUERY
		{
			get
			{
				return m_RP_QUERY;
			}
			set
			{
				if ((this.m_RP_QUERY != value))
				{
					this.SendPropertyChanging("RP_QUERY");
					this.m_RP_QUERY = value;
					this.SendPropertyChanged("RP_QUERY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_RP_QUERYUpdated = true;
				}
			}
		}

		private DateTime? m_RP_EXPORTDATE;
		private bool m_RP_EXPORTDATEUpdated = false;
		/// <summary>
		/// Ngày báo cáo được hệ thống xuất ra.
		/// </summary>
		public DateTime? RP_EXPORTDATE
		{
			get
			{
				return m_RP_EXPORTDATE;
			}
			set
			{
				if ((this.m_RP_EXPORTDATE != value))
				{
					this.SendPropertyChanging("RP_EXPORTDATE");
					this.m_RP_EXPORTDATE = value;
					this.SendPropertyChanged("RP_EXPORTDATE");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_RP_EXPORTDATEUpdated = true;
				}
			}
		}

		private string m_RP_FILEPATH;
		private bool m_RP_FILEPATHUpdated = false;
		/// <summary>
		/// Đường dẫn đến file báo cáo kết xuất được.
		/// </summary>
		public string RP_FILEPATH
		{
			get
			{
				return m_RP_FILEPATH;
			}
			set
			{
				if ((this.m_RP_FILEPATH != value))
				{
					this.SendPropertyChanging("RP_FILEPATH");
					this.m_RP_FILEPATH = value;
					this.SendPropertyChanged("RP_FILEPATH");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_RP_FILEPATHUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM SREPORT " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[RP_ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[RP_USERNAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[RP_CREATEDATE]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[RP_DISPLAY]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[RP_QUERY]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[RP_EXPORTDATE]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[RP_FILEPATH]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("RP_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("RP_USERNAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("RP_CREATEDATE", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("RP_DISPLAY", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("RP_QUERY", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("RP_EXPORTDATE", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("RP_FILEPATH", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO SREPORT ([RP_ID], [RP_USERNAME], [RP_CREATEDATE], [RP_DISPLAY], [RP_QUERY], [RP_EXPORTDATE], [RP_FILEPATH]) VALUES(").Append("@RP_ID").Append(",").Append("@RP_USERNAME").Append(",").Append("@RP_CREATEDATE").Append(",").Append("@RP_DISPLAY").Append(",").Append("@RP_QUERY").Append(",").Append("@RP_EXPORTDATE").Append(",").Append("@RP_FILEPATH").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO SREPORT (RP_ID, RP_USERNAME, RP_CREATEDATE, RP_DISPLAY, RP_QUERY, RP_EXPORTDATE, RP_FILEPATH) VALUES(").Append(":RP_ID").Append(",").Append(":RP_USERNAME").Append(",").Append(":RP_CREATEDATE").Append(",").Append(":RP_DISPLAY").Append(",").Append(":RP_QUERY").Append(",").Append(":RP_EXPORTDATE").Append(",").Append(":RP_FILEPATH").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE SREPORT SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_RP_CREATEDATEUpdated ? string.Format(",[RP_CREATEDATE] = {0}", "@RP_CREATEDATE") : string.Empty).Append(m_RP_DISPLAYUpdated ? string.Format(",[RP_DISPLAY] = {0}", "@RP_DISPLAY") : string.Empty).Append(m_RP_QUERYUpdated ? string.Format(",[RP_QUERY] = {0}", "@RP_QUERY") : string.Empty).Append(m_RP_EXPORTDATEUpdated ? string.Format(",[RP_EXPORTDATE] = {0}", "@RP_EXPORTDATE") : string.Empty).Append(m_RP_FILEPATHUpdated ? string.Format(",[RP_FILEPATH] = {0}", "@RP_FILEPATH") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_RP_CREATEDATEUpdated ? string.Format(",RP_CREATEDATE = {0}", ":RP_CREATEDATE") : string.Empty).Append(m_RP_DISPLAYUpdated ? string.Format(",RP_DISPLAY = {0}", ":RP_DISPLAY") : string.Empty).Append(m_RP_QUERYUpdated ? string.Format(",RP_QUERY = {0}", ":RP_QUERY") : string.Empty).Append(m_RP_EXPORTDATEUpdated ? string.Format(",RP_EXPORTDATE = {0}", ":RP_EXPORTDATE") : string.Empty).Append(m_RP_FILEPATHUpdated ? string.Format(",RP_FILEPATH = {0}", ":RP_FILEPATH") : string.Empty);
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
				sbSQL.AppendFormat("[RP_CREATEDATE] = {0}", "@RP_CREATEDATE").AppendFormat(",[RP_DISPLAY] = {0}", "@RP_DISPLAY").AppendFormat(",[RP_QUERY] = {0}", "@RP_QUERY").AppendFormat(",[RP_EXPORTDATE] = {0}", "@RP_EXPORTDATE").AppendFormat(",[RP_FILEPATH] = {0}", "@RP_FILEPATH");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("RP_CREATEDATE = {0}", ":RP_CREATEDATE").AppendFormat(",RP_DISPLAY = {0}", ":RP_DISPLAY").AppendFormat(",RP_QUERY = {0}", ":RP_QUERY").AppendFormat(",RP_EXPORTDATE = {0}", ":RP_EXPORTDATE").AppendFormat(",RP_FILEPATH = {0}", ":RP_FILEPATH");
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
			return clsDAL.DeleteString("SREPORT", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[RP_ID] = {0}", "@RP_ID").AppendFormat(" AND [RP_USERNAME] = {0}", "@RP_USERNAME");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("RP_ID = {0}", ":RP_ID").AppendFormat(" AND RP_USERNAME = {0}", ":RP_USERNAME");
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
			paramList.Add(clsDAL.CreateParameter("RP_ID", "Integer", clsDAL.ToDBParam(RP_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_USERNAME", "WChar", clsDAL.ToDBParam(RP_USERNAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("RP_CREATEDATE", "Date", clsDAL.ToDBParam(RP_CREATEDATE, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_DISPLAY", "WChar", clsDAL.ToDBParam(RP_DISPLAY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_QUERY", "WChar", clsDAL.ToDBParam(RP_QUERY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_EXPORTDATE", "Date", clsDAL.ToDBParam(RP_EXPORTDATE, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_FILEPATH", "WChar", clsDAL.ToDBParam(RP_FILEPATH, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_ID", "Integer", clsDAL.ToDBParam(RP_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_USERNAME", "WChar", clsDAL.ToDBParam(RP_USERNAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("RP_ID", "Integer", clsDAL.ToDBParam(RP_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_USERNAME", "WChar", clsDAL.ToDBParam(RP_USERNAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_CREATEDATE", "Date", clsDAL.ToDBParam(RP_CREATEDATE, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_DISPLAY", "WChar", clsDAL.ToDBParam(RP_DISPLAY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_QUERY", "WChar", clsDAL.ToDBParam(RP_QUERY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_EXPORTDATE", "Date", clsDAL.ToDBParam(RP_EXPORTDATE, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("RP_FILEPATH", "WChar", clsDAL.ToDBParam(RP_FILEPATH, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}