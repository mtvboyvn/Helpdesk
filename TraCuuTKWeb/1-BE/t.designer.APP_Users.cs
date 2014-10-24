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
	/// Generated Class for Table : APP_Users.
	/// </summary>
	public partial class APP_Users : TableBase
	{
		public APP_Users() : base(){}

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
		private string m_User_ID;
		/// <summary>
		/// User_ID.
		/// </summary>
		public string User_ID
		{
			get
			{
				return m_User_ID;
			}
			set
			{
				if ((this.m_User_ID != value))
				{
					this.SendPropertyChanging("User_ID");
					this.m_User_ID = value;
					this.SendPropertyChanged("User_ID");
				}
			}
		}

		private string m_Customs_ID;
		private bool m_Customs_IDUpdated = false;
		/// <summary>
		/// Customs_ID.
		/// </summary>
		public string Customs_ID
		{
			get
			{
				return m_Customs_ID;
			}
			set
			{
				if ((this.m_Customs_ID != value))
				{
					this.SendPropertyChanging("Customs_ID");
					this.m_Customs_ID = value;
					this.SendPropertyChanged("Customs_ID");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_Customs_IDUpdated = true;
				}
			}
		}

		private string m_User_Password;
		private bool m_User_PasswordUpdated = false;
		/// <summary>
		/// User_Password.
		/// </summary>
		public string User_Password
		{
			get
			{
				return m_User_Password;
			}
			set
			{
				if ((this.m_User_Password != value))
				{
					this.SendPropertyChanging("User_Password");
					this.m_User_Password = value;
					this.SendPropertyChanged("User_Password");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_User_PasswordUpdated = true;
				}
			}
		}

		private string m_User_Principal;
		private bool m_User_PrincipalUpdated = false;
		/// <summary>
		/// User_Principal.
		/// </summary>
		public string User_Principal
		{
			get
			{
				return m_User_Principal;
			}
			set
			{
				if ((this.m_User_Principal != value))
				{
					this.SendPropertyChanging("User_Principal");
					this.m_User_Principal = value;
					this.SendPropertyChanged("User_Principal");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_User_PrincipalUpdated = true;
				}
			}
		}

		private string m_User_Name;
		private bool m_User_NameUpdated = false;
		/// <summary>
		/// User_Name.
		/// </summary>
		public string User_Name
		{
			get
			{
				return m_User_Name;
			}
			set
			{
				if ((this.m_User_Name != value))
				{
					this.SendPropertyChanging("User_Name");
					this.m_User_Name = value;
					this.SendPropertyChanged("User_Name");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_User_NameUpdated = true;
				}
			}
		}

		private string m_User_Mail;
		private bool m_User_MailUpdated = false;
		/// <summary>
		/// User_Mail.
		/// </summary>
		public string User_Mail
		{
			get
			{
				return m_User_Mail;
			}
			set
			{
				if ((this.m_User_Mail != value))
				{
					this.SendPropertyChanging("User_Mail");
					this.m_User_Mail = value;
					this.SendPropertyChanged("User_Mail");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_User_MailUpdated = true;
				}
			}
		}

		private string m_User_Desc;
		private bool m_User_DescUpdated = false;
		/// <summary>
		/// User_Desc.
		/// </summary>
		public string User_Desc
		{
			get
			{
				return m_User_Desc;
			}
			set
			{
				if ((this.m_User_Desc != value))
				{
					this.SendPropertyChanging("User_Desc");
					this.m_User_Desc = value;
					this.SendPropertyChanged("User_Desc");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_User_DescUpdated = true;
				}
			}
		}

		private int? m_User_Locked;
		private bool m_User_LockedUpdated = false;
		/// <summary>
		/// User_Locked.
		/// </summary>
		public int? User_Locked
		{
			get
			{
				return m_User_Locked;
			}
			set
			{
				if ((this.m_User_Locked != value))
				{
					this.SendPropertyChanging("User_Locked");
					this.m_User_Locked = value;
					this.SendPropertyChanged("User_Locked");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_User_LockedUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM APP_Users " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[User_ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[Customs_ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[User_Password]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[User_Principal]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[User_Name]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[User_Mail]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[User_Desc]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[User_Locked]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("User_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("Customs_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("User_Password", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("User_Principal", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("User_Name", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("User_Mail", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("User_Desc", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("User_Locked", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO APP_Users ([User_ID], [Customs_ID], [User_Password], [User_Principal], [User_Name], [User_Mail], [User_Desc], [User_Locked]) VALUES(").Append("@User_ID").Append(",").Append("@Customs_ID").Append(",").Append("@User_Password").Append(",").Append("@User_Principal").Append(",").Append("@User_Name").Append(",").Append("@User_Mail").Append(",").Append("@User_Desc").Append(",").Append("@User_Locked").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO APP_Users (User_ID, Customs_ID, User_Password, User_Principal, User_Name, User_Mail, User_Desc, User_Locked) VALUES(").Append(":User_ID").Append(",").Append(":Customs_ID").Append(",").Append(":User_Password").Append(",").Append(":User_Principal").Append(",").Append(":User_Name").Append(",").Append(":User_Mail").Append(",").Append(":User_Desc").Append(",").Append(":User_Locked").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE APP_Users SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_Customs_IDUpdated ? string.Format(",[Customs_ID] = {0}", "@Customs_ID") : string.Empty).Append(m_User_PasswordUpdated ? string.Format(",[User_Password] = {0}", "@User_Password") : string.Empty).Append(m_User_PrincipalUpdated ? string.Format(",[User_Principal] = {0}", "@User_Principal") : string.Empty).Append(m_User_NameUpdated ? string.Format(",[User_Name] = {0}", "@User_Name") : string.Empty).Append(m_User_MailUpdated ? string.Format(",[User_Mail] = {0}", "@User_Mail") : string.Empty).Append(m_User_DescUpdated ? string.Format(",[User_Desc] = {0}", "@User_Desc") : string.Empty).Append(m_User_LockedUpdated ? string.Format(",[User_Locked] = {0}", "@User_Locked") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_Customs_IDUpdated ? string.Format(",Customs_ID = {0}", ":Customs_ID") : string.Empty).Append(m_User_PasswordUpdated ? string.Format(",User_Password = {0}", ":User_Password") : string.Empty).Append(m_User_PrincipalUpdated ? string.Format(",User_Principal = {0}", ":User_Principal") : string.Empty).Append(m_User_NameUpdated ? string.Format(",User_Name = {0}", ":User_Name") : string.Empty).Append(m_User_MailUpdated ? string.Format(",User_Mail = {0}", ":User_Mail") : string.Empty).Append(m_User_DescUpdated ? string.Format(",User_Desc = {0}", ":User_Desc") : string.Empty).Append(m_User_LockedUpdated ? string.Format(",User_Locked = {0}", ":User_Locked") : string.Empty);
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
				sbSQL.AppendFormat("[Customs_ID] = {0}", "@Customs_ID").AppendFormat(",[User_Password] = {0}", "@User_Password").AppendFormat(",[User_Principal] = {0}", "@User_Principal").AppendFormat(",[User_Name] = {0}", "@User_Name").AppendFormat(",[User_Mail] = {0}", "@User_Mail").AppendFormat(",[User_Desc] = {0}", "@User_Desc").AppendFormat(",[User_Locked] = {0}", "@User_Locked");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("Customs_ID = {0}", ":Customs_ID").AppendFormat(",User_Password = {0}", ":User_Password").AppendFormat(",User_Principal = {0}", ":User_Principal").AppendFormat(",User_Name = {0}", ":User_Name").AppendFormat(",User_Mail = {0}", ":User_Mail").AppendFormat(",User_Desc = {0}", ":User_Desc").AppendFormat(",User_Locked = {0}", ":User_Locked");
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
			return clsDAL.DeleteString("APP_Users", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[User_ID] = {0}", "@User_ID");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("User_ID = {0}", ":User_ID");
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
			paramList.Add(clsDAL.CreateParameter("User_ID", "WChar", clsDAL.ToDBParam(User_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("Customs_ID", "WChar", clsDAL.ToDBParam(Customs_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Password", "WChar", clsDAL.ToDBParam(User_Password, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Principal", "WChar", clsDAL.ToDBParam(User_Principal, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Name", "WChar", clsDAL.ToDBParam(User_Name, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Mail", "WChar", clsDAL.ToDBParam(User_Mail, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Desc", "WChar", clsDAL.ToDBParam(User_Desc, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Locked", "Integer", clsDAL.ToDBParam(User_Locked, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_ID", "WChar", clsDAL.ToDBParam(User_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("User_ID", "WChar", clsDAL.ToDBParam(User_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("Customs_ID", "WChar", clsDAL.ToDBParam(Customs_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Password", "WChar", clsDAL.ToDBParam(User_Password, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Principal", "WChar", clsDAL.ToDBParam(User_Principal, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Name", "WChar", clsDAL.ToDBParam(User_Name, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Mail", "WChar", clsDAL.ToDBParam(User_Mail, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Desc", "WChar", clsDAL.ToDBParam(User_Desc, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("User_Locked", "Integer", clsDAL.ToDBParam(User_Locked, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}