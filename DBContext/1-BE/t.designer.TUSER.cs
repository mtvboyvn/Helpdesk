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
	/// Generated Class for Table : TUSER.
	/// </summary>
	public partial class TUSER : TableBase
	{
		public TUSER() : base(){}

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
		private string m_USER_ID;
		/// <summary>
		/// USER_ID.
		/// </summary>
		public string USER_ID
		{
			get
			{
				return m_USER_ID;
			}
			set
			{
				if ((this.m_USER_ID != value))
				{
					this.SendPropertyChanging("USER_ID");
					this.m_USER_ID = value;
					this.SendPropertyChanged("USER_ID");
				}
			}
		}

		private string m_USER_PASSWORD;
		private bool m_USER_PASSWORDUpdated = false;
		/// <summary>
		/// USER_PASSWORD.
		/// </summary>
		public string USER_PASSWORD
		{
			get
			{
				return m_USER_PASSWORD;
			}
			set
			{
				if ((this.m_USER_PASSWORD != value))
				{
					this.SendPropertyChanging("USER_PASSWORD");
					this.m_USER_PASSWORD = value;
					this.SendPropertyChanged("USER_PASSWORD");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_PASSWORDUpdated = true;
				}
			}
		}

		private DateTime? m_USER_CREATE_DATE;
		private bool m_USER_CREATE_DATEUpdated = false;
		/// <summary>
		/// USER_CREATE_DATE.
		/// </summary>
		public DateTime? USER_CREATE_DATE
		{
			get
			{
				return m_USER_CREATE_DATE;
			}
			set
			{
				if ((this.m_USER_CREATE_DATE != value))
				{
					this.SendPropertyChanging("USER_CREATE_DATE");
					this.m_USER_CREATE_DATE = value;
					this.SendPropertyChanged("USER_CREATE_DATE");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_CREATE_DATEUpdated = true;
				}
			}
		}

		private int m_USER_ROLE = 0;
		private bool m_USER_ROLEUpdated = false;
		/// <summary>
		/// 0=người yêu cầu, 1=người hỗ trợ, 2=quản trị         - mặc định 0.
		/// </summary>
		public int USER_ROLE
		{
			get
			{
				return m_USER_ROLE;
			}
			set
			{
				if ((this.m_USER_ROLE != value))
				{
					this.SendPropertyChanging("USER_ROLE");
					this.m_USER_ROLE = value;
					this.SendPropertyChanged("USER_ROLE");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_ROLEUpdated = true;
				}
			}
		}

		private string m_USER_FULL_NAME;
		private bool m_USER_FULL_NAMEUpdated = false;
		/// <summary>
		/// USER_FULL_NAME.
		/// </summary>
		public string USER_FULL_NAME
		{
			get
			{
				return m_USER_FULL_NAME;
			}
			set
			{
				if ((this.m_USER_FULL_NAME != value))
				{
					this.SendPropertyChanging("USER_FULL_NAME");
					this.m_USER_FULL_NAME = value;
					this.SendPropertyChanged("USER_FULL_NAME");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_FULL_NAMEUpdated = true;
				}
			}
		}

		private string m_USER_EMAIL;
		private bool m_USER_EMAILUpdated = false;
		/// <summary>
		/// USER_EMAIL.
		/// </summary>
		public string USER_EMAIL
		{
			get
			{
				return m_USER_EMAIL;
			}
			set
			{
				if ((this.m_USER_EMAIL != value))
				{
					this.SendPropertyChanging("USER_EMAIL");
					this.m_USER_EMAIL = value;
					this.SendPropertyChanged("USER_EMAIL");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_EMAILUpdated = true;
				}
			}
		}

		private string m_USER_PHONE1;
		private bool m_USER_PHONE1Updated = false;
		/// <summary>
		/// USER_PHONE1.
		/// </summary>
		public string USER_PHONE1
		{
			get
			{
				return m_USER_PHONE1;
			}
			set
			{
				if ((this.m_USER_PHONE1 != value))
				{
					this.SendPropertyChanging("USER_PHONE1");
					this.m_USER_PHONE1 = value;
					this.SendPropertyChanged("USER_PHONE1");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_PHONE1Updated = true;
				}
			}
		}

		private string m_USER_PHONE2;
		private bool m_USER_PHONE2Updated = false;
		/// <summary>
		/// USER_PHONE2.
		/// </summary>
		public string USER_PHONE2
		{
			get
			{
				return m_USER_PHONE2;
			}
			set
			{
				if ((this.m_USER_PHONE2 != value))
				{
					this.SendPropertyChanging("USER_PHONE2");
					this.m_USER_PHONE2 = value;
					this.SendPropertyChanged("USER_PHONE2");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_PHONE2Updated = true;
				}
			}
		}

		private string m_USER_PHONE3;
		private bool m_USER_PHONE3Updated = false;
		/// <summary>
		/// USER_PHONE3.
		/// </summary>
		public string USER_PHONE3
		{
			get
			{
				return m_USER_PHONE3;
			}
			set
			{
				if ((this.m_USER_PHONE3 != value))
				{
					this.SendPropertyChanging("USER_PHONE3");
					this.m_USER_PHONE3 = value;
					this.SendPropertyChanged("USER_PHONE3");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_PHONE3Updated = true;
				}
			}
		}

		private string m_USER_CTY_MST;
		private bool m_USER_CTY_MSTUpdated = false;
		/// <summary>
		/// USER_CTY_MST.
		/// </summary>
		public string USER_CTY_MST
		{
			get
			{
				return m_USER_CTY_MST;
			}
			set
			{
				if ((this.m_USER_CTY_MST != value))
				{
					this.SendPropertyChanging("USER_CTY_MST");
					this.m_USER_CTY_MST = value;
					this.SendPropertyChanged("USER_CTY_MST");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_CTY_MSTUpdated = true;
				}
			}
		}

		private string m_USER_CTY_TEN;
		private bool m_USER_CTY_TENUpdated = false;
		/// <summary>
		/// USER_CTY_TEN.
		/// </summary>
		public string USER_CTY_TEN
		{
			get
			{
				return m_USER_CTY_TEN;
			}
			set
			{
				if ((this.m_USER_CTY_TEN != value))
				{
					this.SendPropertyChanging("USER_CTY_TEN");
					this.m_USER_CTY_TEN = value;
					this.SendPropertyChanged("USER_CTY_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_CTY_TENUpdated = true;
				}
			}
		}

		private string m_USER_CTY_DIACHI;
		private bool m_USER_CTY_DIACHIUpdated = false;
		/// <summary>
		/// USER_CTY_DIACHI.
		/// </summary>
		public string USER_CTY_DIACHI
		{
			get
			{
				return m_USER_CTY_DIACHI;
			}
			set
			{
				if ((this.m_USER_CTY_DIACHI != value))
				{
					this.SendPropertyChanging("USER_CTY_DIACHI");
					this.m_USER_CTY_DIACHI = value;
					this.SendPropertyChanged("USER_CTY_DIACHI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_CTY_DIACHIUpdated = true;
				}
			}
		}

		private string m_USER_VNACCS_ACCOUNT;
		private bool m_USER_VNACCS_ACCOUNTUpdated = false;
		/// <summary>
		/// USER_VNACCS_ACCOUNT.
		/// </summary>
		public string USER_VNACCS_ACCOUNT
		{
			get
			{
				return m_USER_VNACCS_ACCOUNT;
			}
			set
			{
				if ((this.m_USER_VNACCS_ACCOUNT != value))
				{
					this.SendPropertyChanging("USER_VNACCS_ACCOUNT");
					this.m_USER_VNACCS_ACCOUNT = value;
					this.SendPropertyChanged("USER_VNACCS_ACCOUNT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_VNACCS_ACCOUNTUpdated = true;
				}
			}
		}

		private string m_USER_VNACCS_PASSWORD;
		private bool m_USER_VNACCS_PASSWORDUpdated = false;
		/// <summary>
		/// USER_VNACCS_PASSWORD.
		/// </summary>
		public string USER_VNACCS_PASSWORD
		{
			get
			{
				return m_USER_VNACCS_PASSWORD;
			}
			set
			{
				if ((this.m_USER_VNACCS_PASSWORD != value))
				{
					this.SendPropertyChanging("USER_VNACCS_PASSWORD");
					this.m_USER_VNACCS_PASSWORD = value;
					this.SendPropertyChanged("USER_VNACCS_PASSWORD");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_VNACCS_PASSWORDUpdated = true;
				}
			}
		}

		private string m_USER_VNACCS_TERMINAL_ID;
		private bool m_USER_VNACCS_TERMINAL_IDUpdated = false;
		/// <summary>
		/// USER_VNACCS_TERMINAL_ID.
		/// </summary>
		public string USER_VNACCS_TERMINAL_ID
		{
			get
			{
				return m_USER_VNACCS_TERMINAL_ID;
			}
			set
			{
				if ((this.m_USER_VNACCS_TERMINAL_ID != value))
				{
					this.SendPropertyChanging("USER_VNACCS_TERMINAL_ID");
					this.m_USER_VNACCS_TERMINAL_ID = value;
					this.SendPropertyChanged("USER_VNACCS_TERMINAL_ID");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_VNACCS_TERMINAL_IDUpdated = true;
				}
			}
		}

		private string m_USER_TERMICAL_ACCESS_KEY;
		private bool m_USER_TERMICAL_ACCESS_KEYUpdated = false;
		/// <summary>
		/// USER_TERMICAL_ACCESS_KEY.
		/// </summary>
		public string USER_TERMICAL_ACCESS_KEY
		{
			get
			{
				return m_USER_TERMICAL_ACCESS_KEY;
			}
			set
			{
				if ((this.m_USER_TERMICAL_ACCESS_KEY != value))
				{
					this.SendPropertyChanging("USER_TERMICAL_ACCESS_KEY");
					this.m_USER_TERMICAL_ACCESS_KEY = value;
					this.SendPropertyChanged("USER_TERMICAL_ACCESS_KEY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_TERMICAL_ACCESS_KEYUpdated = true;
				}
			}
		}

		private string m_USER_HAIQUAN_MA;
		private bool m_USER_HAIQUAN_MAUpdated = false;
		/// <summary>
		/// Mã Hải quan hay mở tờ khai.
		/// </summary>
		public string USER_HAIQUAN_MA
		{
			get
			{
				return m_USER_HAIQUAN_MA;
			}
			set
			{
				if ((this.m_USER_HAIQUAN_MA != value))
				{
					this.SendPropertyChanging("USER_HAIQUAN_MA");
					this.m_USER_HAIQUAN_MA = value;
					this.SendPropertyChanged("USER_HAIQUAN_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_HAIQUAN_MAUpdated = true;
				}
			}
		}

		private string m_USER_HAIQUAN_TEN;
		private bool m_USER_HAIQUAN_TENUpdated = false;
		/// <summary>
		/// Tên Hải quan hay mở tờ khai.
		/// </summary>
		public string USER_HAIQUAN_TEN
		{
			get
			{
				return m_USER_HAIQUAN_TEN;
			}
			set
			{
				if ((this.m_USER_HAIQUAN_TEN != value))
				{
					this.SendPropertyChanging("USER_HAIQUAN_TEN");
					this.m_USER_HAIQUAN_TEN = value;
					this.SendPropertyChanged("USER_HAIQUAN_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_HAIQUAN_TENUpdated = true;
				}
			}
		}

		private string m_USER_TINHTHANH_MA;
		private bool m_USER_TINHTHANH_MAUpdated = false;
		/// <summary>
		/// MÃ TỈNH USER Ở.
		/// </summary>
		public string USER_TINHTHANH_MA
		{
			get
			{
				return m_USER_TINHTHANH_MA;
			}
			set
			{
				if ((this.m_USER_TINHTHANH_MA != value))
				{
					this.SendPropertyChanging("USER_TINHTHANH_MA");
					this.m_USER_TINHTHANH_MA = value;
					this.SendPropertyChanged("USER_TINHTHANH_MA");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_TINHTHANH_MAUpdated = true;
				}
			}
		}

		private string m_USER_TINHTHANH_TEN;
		private bool m_USER_TINHTHANH_TENUpdated = false;
		/// <summary>
		/// TÊN TỈNH USER Ở.
		/// </summary>
		public string USER_TINHTHANH_TEN
		{
			get
			{
				return m_USER_TINHTHANH_TEN;
			}
			set
			{
				if ((this.m_USER_TINHTHANH_TEN != value))
				{
					this.SendPropertyChanging("USER_TINHTHANH_TEN");
					this.m_USER_TINHTHANH_TEN = value;
					this.SendPropertyChanged("USER_TINHTHANH_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_USER_TINHTHANH_TENUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM TUSER " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[USER_ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_PASSWORD]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_CREATE_DATE]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_ROLE]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_FULL_NAME]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_EMAIL]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_PHONE1]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_PHONE2]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_PHONE3]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_CTY_MST]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_CTY_TEN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_CTY_DIACHI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_VNACCS_ACCOUNT]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_VNACCS_PASSWORD]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_VNACCS_TERMINAL_ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_TERMICAL_ACCESS_KEY]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_HAIQUAN_MA]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_HAIQUAN_TEN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_TINHTHANH_MA]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[USER_TINHTHANH_TEN]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("USER_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_PASSWORD", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_CREATE_DATE", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_ROLE", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_FULL_NAME", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_EMAIL", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_PHONE1", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_PHONE2", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_PHONE3", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_CTY_MST", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_CTY_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_CTY_DIACHI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_VNACCS_ACCOUNT", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_VNACCS_PASSWORD", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_VNACCS_TERMINAL_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_TERMICAL_ACCESS_KEY", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_HAIQUAN_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_HAIQUAN_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_TINHTHANH_MA", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("USER_TINHTHANH_TEN", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO TUSER ([USER_ID], [USER_PASSWORD], [USER_CREATE_DATE], [USER_ROLE], [USER_FULL_NAME], [USER_EMAIL], [USER_PHONE1], [USER_PHONE2], [USER_PHONE3], [USER_CTY_MST], [USER_CTY_TEN], [USER_CTY_DIACHI], [USER_VNACCS_ACCOUNT], [USER_VNACCS_PASSWORD], [USER_VNACCS_TERMINAL_ID], [USER_TERMICAL_ACCESS_KEY], [USER_HAIQUAN_MA], [USER_HAIQUAN_TEN], [USER_TINHTHANH_MA], [USER_TINHTHANH_TEN]) VALUES(").Append("@USER_ID").Append(",").Append("@USER_PASSWORD").Append(",").Append("@USER_CREATE_DATE").Append(",").Append("@USER_ROLE").Append(",").Append("@USER_FULL_NAME").Append(",").Append("@USER_EMAIL").Append(",").Append("@USER_PHONE1").Append(",").Append("@USER_PHONE2").Append(",").Append("@USER_PHONE3").Append(",").Append("@USER_CTY_MST").Append(",").Append("@USER_CTY_TEN").Append(",").Append("@USER_CTY_DIACHI").Append(",").Append("@USER_VNACCS_ACCOUNT").Append(",").Append("@USER_VNACCS_PASSWORD").Append(",").Append("@USER_VNACCS_TERMINAL_ID").Append(",").Append("@USER_TERMICAL_ACCESS_KEY").Append(",").Append("@USER_HAIQUAN_MA").Append(",").Append("@USER_HAIQUAN_TEN").Append(",").Append("@USER_TINHTHANH_MA").Append(",").Append("@USER_TINHTHANH_TEN").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO TUSER (USER_ID, USER_PASSWORD, USER_CREATE_DATE, USER_ROLE, USER_FULL_NAME, USER_EMAIL, USER_PHONE1, USER_PHONE2, USER_PHONE3, USER_CTY_MST, USER_CTY_TEN, USER_CTY_DIACHI, USER_VNACCS_ACCOUNT, USER_VNACCS_PASSWORD, USER_VNACCS_TERMINAL_ID, USER_TERMICAL_ACCESS_KEY, USER_HAIQUAN_MA, USER_HAIQUAN_TEN, USER_TINHTHANH_MA, USER_TINHTHANH_TEN) VALUES(").Append(":USER_ID").Append(",").Append(":USER_PASSWORD").Append(",").Append(":USER_CREATE_DATE").Append(",").Append(":USER_ROLE").Append(",").Append(":USER_FULL_NAME").Append(",").Append(":USER_EMAIL").Append(",").Append(":USER_PHONE1").Append(",").Append(":USER_PHONE2").Append(",").Append(":USER_PHONE3").Append(",").Append(":USER_CTY_MST").Append(",").Append(":USER_CTY_TEN").Append(",").Append(":USER_CTY_DIACHI").Append(",").Append(":USER_VNACCS_ACCOUNT").Append(",").Append(":USER_VNACCS_PASSWORD").Append(",").Append(":USER_VNACCS_TERMINAL_ID").Append(",").Append(":USER_TERMICAL_ACCESS_KEY").Append(",").Append(":USER_HAIQUAN_MA").Append(",").Append(":USER_HAIQUAN_TEN").Append(",").Append(":USER_TINHTHANH_MA").Append(",").Append(":USER_TINHTHANH_TEN").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE TUSER SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_USER_PASSWORDUpdated ? string.Format(",[USER_PASSWORD] = {0}", "@USER_PASSWORD") : string.Empty).Append(m_USER_CREATE_DATEUpdated ? string.Format(",[USER_CREATE_DATE] = {0}", "@USER_CREATE_DATE") : string.Empty).Append(m_USER_ROLEUpdated ? string.Format(",[USER_ROLE] = {0}", "@USER_ROLE") : string.Empty).Append(m_USER_FULL_NAMEUpdated ? string.Format(",[USER_FULL_NAME] = {0}", "@USER_FULL_NAME") : string.Empty).Append(m_USER_EMAILUpdated ? string.Format(",[USER_EMAIL] = {0}", "@USER_EMAIL") : string.Empty).Append(m_USER_PHONE1Updated ? string.Format(",[USER_PHONE1] = {0}", "@USER_PHONE1") : string.Empty).Append(m_USER_PHONE2Updated ? string.Format(",[USER_PHONE2] = {0}", "@USER_PHONE2") : string.Empty).Append(m_USER_PHONE3Updated ? string.Format(",[USER_PHONE3] = {0}", "@USER_PHONE3") : string.Empty).Append(m_USER_CTY_MSTUpdated ? string.Format(",[USER_CTY_MST] = {0}", "@USER_CTY_MST") : string.Empty).Append(m_USER_CTY_TENUpdated ? string.Format(",[USER_CTY_TEN] = {0}", "@USER_CTY_TEN") : string.Empty).Append(m_USER_CTY_DIACHIUpdated ? string.Format(",[USER_CTY_DIACHI] = {0}", "@USER_CTY_DIACHI") : string.Empty).Append(m_USER_VNACCS_ACCOUNTUpdated ? string.Format(",[USER_VNACCS_ACCOUNT] = {0}", "@USER_VNACCS_ACCOUNT") : string.Empty).Append(m_USER_VNACCS_PASSWORDUpdated ? string.Format(",[USER_VNACCS_PASSWORD] = {0}", "@USER_VNACCS_PASSWORD") : string.Empty).Append(m_USER_VNACCS_TERMINAL_IDUpdated ? string.Format(",[USER_VNACCS_TERMINAL_ID] = {0}", "@USER_VNACCS_TERMINAL_ID") : string.Empty).Append(m_USER_TERMICAL_ACCESS_KEYUpdated ? string.Format(",[USER_TERMICAL_ACCESS_KEY] = {0}", "@USER_TERMICAL_ACCESS_KEY") : string.Empty).Append(m_USER_HAIQUAN_MAUpdated ? string.Format(",[USER_HAIQUAN_MA] = {0}", "@USER_HAIQUAN_MA") : string.Empty).Append(m_USER_HAIQUAN_TENUpdated ? string.Format(",[USER_HAIQUAN_TEN] = {0}", "@USER_HAIQUAN_TEN") : string.Empty).Append(m_USER_TINHTHANH_MAUpdated ? string.Format(",[USER_TINHTHANH_MA] = {0}", "@USER_TINHTHANH_MA") : string.Empty).Append(m_USER_TINHTHANH_TENUpdated ? string.Format(",[USER_TINHTHANH_TEN] = {0}", "@USER_TINHTHANH_TEN") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_USER_PASSWORDUpdated ? string.Format(",USER_PASSWORD = {0}", ":USER_PASSWORD") : string.Empty).Append(m_USER_CREATE_DATEUpdated ? string.Format(",USER_CREATE_DATE = {0}", ":USER_CREATE_DATE") : string.Empty).Append(m_USER_ROLEUpdated ? string.Format(",USER_ROLE = {0}", ":USER_ROLE") : string.Empty).Append(m_USER_FULL_NAMEUpdated ? string.Format(",USER_FULL_NAME = {0}", ":USER_FULL_NAME") : string.Empty).Append(m_USER_EMAILUpdated ? string.Format(",USER_EMAIL = {0}", ":USER_EMAIL") : string.Empty).Append(m_USER_PHONE1Updated ? string.Format(",USER_PHONE1 = {0}", ":USER_PHONE1") : string.Empty).Append(m_USER_PHONE2Updated ? string.Format(",USER_PHONE2 = {0}", ":USER_PHONE2") : string.Empty).Append(m_USER_PHONE3Updated ? string.Format(",USER_PHONE3 = {0}", ":USER_PHONE3") : string.Empty).Append(m_USER_CTY_MSTUpdated ? string.Format(",USER_CTY_MST = {0}", ":USER_CTY_MST") : string.Empty).Append(m_USER_CTY_TENUpdated ? string.Format(",USER_CTY_TEN = {0}", ":USER_CTY_TEN") : string.Empty).Append(m_USER_CTY_DIACHIUpdated ? string.Format(",USER_CTY_DIACHI = {0}", ":USER_CTY_DIACHI") : string.Empty).Append(m_USER_VNACCS_ACCOUNTUpdated ? string.Format(",USER_VNACCS_ACCOUNT = {0}", ":USER_VNACCS_ACCOUNT") : string.Empty).Append(m_USER_VNACCS_PASSWORDUpdated ? string.Format(",USER_VNACCS_PASSWORD = {0}", ":USER_VNACCS_PASSWORD") : string.Empty).Append(m_USER_VNACCS_TERMINAL_IDUpdated ? string.Format(",USER_VNACCS_TERMINAL_ID = {0}", ":USER_VNACCS_TERMINAL_ID") : string.Empty).Append(m_USER_TERMICAL_ACCESS_KEYUpdated ? string.Format(",USER_TERMICAL_ACCESS_KEY = {0}", ":USER_TERMICAL_ACCESS_KEY") : string.Empty).Append(m_USER_HAIQUAN_MAUpdated ? string.Format(",USER_HAIQUAN_MA = {0}", ":USER_HAIQUAN_MA") : string.Empty).Append(m_USER_HAIQUAN_TENUpdated ? string.Format(",USER_HAIQUAN_TEN = {0}", ":USER_HAIQUAN_TEN") : string.Empty).Append(m_USER_TINHTHANH_MAUpdated ? string.Format(",USER_TINHTHANH_MA = {0}", ":USER_TINHTHANH_MA") : string.Empty).Append(m_USER_TINHTHANH_TENUpdated ? string.Format(",USER_TINHTHANH_TEN = {0}", ":USER_TINHTHANH_TEN") : string.Empty);
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
				sbSQL.AppendFormat("[USER_PASSWORD] = {0}", "@USER_PASSWORD").AppendFormat(",[USER_CREATE_DATE] = {0}", "@USER_CREATE_DATE").AppendFormat(",[USER_ROLE] = {0}", "@USER_ROLE").AppendFormat(",[USER_FULL_NAME] = {0}", "@USER_FULL_NAME").AppendFormat(",[USER_EMAIL] = {0}", "@USER_EMAIL").AppendFormat(",[USER_PHONE1] = {0}", "@USER_PHONE1").AppendFormat(",[USER_PHONE2] = {0}", "@USER_PHONE2").AppendFormat(",[USER_PHONE3] = {0}", "@USER_PHONE3").AppendFormat(",[USER_CTY_MST] = {0}", "@USER_CTY_MST").AppendFormat(",[USER_CTY_TEN] = {0}", "@USER_CTY_TEN").AppendFormat(",[USER_CTY_DIACHI] = {0}", "@USER_CTY_DIACHI").AppendFormat(",[USER_VNACCS_ACCOUNT] = {0}", "@USER_VNACCS_ACCOUNT").AppendFormat(",[USER_VNACCS_PASSWORD] = {0}", "@USER_VNACCS_PASSWORD").AppendFormat(",[USER_VNACCS_TERMINAL_ID] = {0}", "@USER_VNACCS_TERMINAL_ID").AppendFormat(",[USER_TERMICAL_ACCESS_KEY] = {0}", "@USER_TERMICAL_ACCESS_KEY").AppendFormat(",[USER_HAIQUAN_MA] = {0}", "@USER_HAIQUAN_MA").AppendFormat(",[USER_HAIQUAN_TEN] = {0}", "@USER_HAIQUAN_TEN").AppendFormat(",[USER_TINHTHANH_MA] = {0}", "@USER_TINHTHANH_MA").AppendFormat(",[USER_TINHTHANH_TEN] = {0}", "@USER_TINHTHANH_TEN");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("USER_PASSWORD = {0}", ":USER_PASSWORD").AppendFormat(",USER_CREATE_DATE = {0}", ":USER_CREATE_DATE").AppendFormat(",USER_ROLE = {0}", ":USER_ROLE").AppendFormat(",USER_FULL_NAME = {0}", ":USER_FULL_NAME").AppendFormat(",USER_EMAIL = {0}", ":USER_EMAIL").AppendFormat(",USER_PHONE1 = {0}", ":USER_PHONE1").AppendFormat(",USER_PHONE2 = {0}", ":USER_PHONE2").AppendFormat(",USER_PHONE3 = {0}", ":USER_PHONE3").AppendFormat(",USER_CTY_MST = {0}", ":USER_CTY_MST").AppendFormat(",USER_CTY_TEN = {0}", ":USER_CTY_TEN").AppendFormat(",USER_CTY_DIACHI = {0}", ":USER_CTY_DIACHI").AppendFormat(",USER_VNACCS_ACCOUNT = {0}", ":USER_VNACCS_ACCOUNT").AppendFormat(",USER_VNACCS_PASSWORD = {0}", ":USER_VNACCS_PASSWORD").AppendFormat(",USER_VNACCS_TERMINAL_ID = {0}", ":USER_VNACCS_TERMINAL_ID").AppendFormat(",USER_TERMICAL_ACCESS_KEY = {0}", ":USER_TERMICAL_ACCESS_KEY").AppendFormat(",USER_HAIQUAN_MA = {0}", ":USER_HAIQUAN_MA").AppendFormat(",USER_HAIQUAN_TEN = {0}", ":USER_HAIQUAN_TEN").AppendFormat(",USER_TINHTHANH_MA = {0}", ":USER_TINHTHANH_MA").AppendFormat(",USER_TINHTHANH_TEN = {0}", ":USER_TINHTHANH_TEN");
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
			return clsDAL.DeleteString("TUSER", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[USER_ID] = {0}", "@USER_ID");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("USER_ID = {0}", ":USER_ID");
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
			paramList.Add(clsDAL.CreateParameter("USER_ID", "WChar", clsDAL.ToDBParam(USER_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			if (m_USER_PASSWORDUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_PASSWORD", "WChar", clsDAL.ToDBParam(USER_PASSWORD, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_CREATE_DATEUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_CREATE_DATE", "Date", clsDAL.ToDBParam(USER_CREATE_DATE, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			if (m_USER_ROLEUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_ROLE", "SmallInt", clsDAL.ToDBParam(USER_ROLE, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			if (m_USER_FULL_NAMEUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_FULL_NAME", "WChar", clsDAL.ToDBParam(USER_FULL_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_EMAILUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_EMAIL", "WChar", clsDAL.ToDBParam(USER_EMAIL, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_PHONE1Updated == true) paramList.Add(clsDAL.CreateParameter("USER_PHONE1", "WChar", clsDAL.ToDBParam(USER_PHONE1, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_PHONE2Updated == true) paramList.Add(clsDAL.CreateParameter("USER_PHONE2", "WChar", clsDAL.ToDBParam(USER_PHONE2, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_PHONE3Updated == true) paramList.Add(clsDAL.CreateParameter("USER_PHONE3", "WChar", clsDAL.ToDBParam(USER_PHONE3, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_CTY_MSTUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_CTY_MST", "WChar", clsDAL.ToDBParam(USER_CTY_MST, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_CTY_TENUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_CTY_TEN", "WChar", clsDAL.ToDBParam(USER_CTY_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_CTY_DIACHIUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_CTY_DIACHI", "WChar", clsDAL.ToDBParam(USER_CTY_DIACHI, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_VNACCS_ACCOUNTUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_VNACCS_ACCOUNT", "WChar", clsDAL.ToDBParam(USER_VNACCS_ACCOUNT, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_VNACCS_PASSWORDUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_VNACCS_PASSWORD", "WChar", clsDAL.ToDBParam(USER_VNACCS_PASSWORD, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_VNACCS_TERMINAL_IDUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_VNACCS_TERMINAL_ID", "WChar", clsDAL.ToDBParam(USER_VNACCS_TERMINAL_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_TERMICAL_ACCESS_KEYUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_TERMICAL_ACCESS_KEY", "WChar", clsDAL.ToDBParam(USER_TERMICAL_ACCESS_KEY, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_HAIQUAN_MAUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_HAIQUAN_MA", "WChar", clsDAL.ToDBParam(USER_HAIQUAN_MA, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_HAIQUAN_TENUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_HAIQUAN_TEN", "WChar", clsDAL.ToDBParam(USER_HAIQUAN_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_TINHTHANH_MAUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_TINHTHANH_MA", "WChar", clsDAL.ToDBParam(USER_TINHTHANH_MA, ProType.STRING, this.DataManagement) , this.DataManagement));
			if (m_USER_TINHTHANH_TENUpdated == true) paramList.Add(clsDAL.CreateParameter("USER_TINHTHANH_TEN", "WChar", clsDAL.ToDBParam(USER_TINHTHANH_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_ID", "WChar", clsDAL.ToDBParam(USER_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("USER_ID", "WChar", clsDAL.ToDBParam(USER_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_PASSWORD", "WChar", clsDAL.ToDBParam(USER_PASSWORD, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_CREATE_DATE", "Date", clsDAL.ToDBParam(USER_CREATE_DATE, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_ROLE", "SmallInt", clsDAL.ToDBParam(USER_ROLE, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_FULL_NAME", "WChar", clsDAL.ToDBParam(USER_FULL_NAME, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_EMAIL", "WChar", clsDAL.ToDBParam(USER_EMAIL, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_PHONE1", "WChar", clsDAL.ToDBParam(USER_PHONE1, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_PHONE2", "WChar", clsDAL.ToDBParam(USER_PHONE2, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_PHONE3", "WChar", clsDAL.ToDBParam(USER_PHONE3, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_CTY_MST", "WChar", clsDAL.ToDBParam(USER_CTY_MST, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_CTY_TEN", "WChar", clsDAL.ToDBParam(USER_CTY_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_CTY_DIACHI", "WChar", clsDAL.ToDBParam(USER_CTY_DIACHI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_VNACCS_ACCOUNT", "WChar", clsDAL.ToDBParam(USER_VNACCS_ACCOUNT, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_VNACCS_PASSWORD", "WChar", clsDAL.ToDBParam(USER_VNACCS_PASSWORD, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_VNACCS_TERMINAL_ID", "WChar", clsDAL.ToDBParam(USER_VNACCS_TERMINAL_ID, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_TERMICAL_ACCESS_KEY", "WChar", clsDAL.ToDBParam(USER_TERMICAL_ACCESS_KEY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_HAIQUAN_MA", "WChar", clsDAL.ToDBParam(USER_HAIQUAN_MA, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_HAIQUAN_TEN", "WChar", clsDAL.ToDBParam(USER_HAIQUAN_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_TINHTHANH_MA", "WChar", clsDAL.ToDBParam(USER_TINHTHANH_MA, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("USER_TINHTHANH_TEN", "WChar", clsDAL.ToDBParam(USER_TINHTHANH_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}