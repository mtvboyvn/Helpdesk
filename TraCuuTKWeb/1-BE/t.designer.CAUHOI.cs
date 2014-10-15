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
	/// Generated Class for Table : CAUHOI.
	/// </summary>
	public partial class CAUHOI : TableBase
	{
		public CAUHOI() : base(){}

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
		private int m_CH_ID;
		/// <summary>
		/// ID câu hỏi.
		/// </summary>
		public int CH_ID
		{
			get
			{
				return m_CH_ID;
			}
			set
			{
				if ((this.m_CH_ID != value))
				{
					this.SendPropertyChanging("CH_ID");
					this.m_CH_ID = value;
					this.SendPropertyChanged("CH_ID");
				}
			}
		}

		private int? m_CH_GROUPID;
		private bool m_CH_GROUPIDUpdated = false;
		/// <summary>
		/// GROUP xác định nhóm câu hỏi liên quan với nhau, có thể để xem theo thread được.
		/// </summary>
		public int? CH_GROUPID
		{
			get
			{
				return m_CH_GROUPID;
			}
			set
			{
				if ((this.m_CH_GROUPID != value))
				{
					this.SendPropertyChanging("CH_GROUPID");
					this.m_CH_GROUPID = value;
					this.SendPropertyChanged("CH_GROUPID");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_GROUPIDUpdated = true;
				}
			}
		}

		private string m_CH_DOITUONGHOI;
		private bool m_CH_DOITUONGHOIUpdated = false;
		/// <summary>
		/// Đối tượng hỏi: Hải quan, Doanh Nghiệp.
		/// </summary>
		public string CH_DOITUONGHOI
		{
			get
			{
				return m_CH_DOITUONGHOI;
			}
			set
			{
				if ((this.m_CH_DOITUONGHOI != value))
				{
					this.SendPropertyChanging("CH_DOITUONGHOI");
					this.m_CH_DOITUONGHOI = value;
					this.SendPropertyChanged("CH_DOITUONGHOI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_DOITUONGHOIUpdated = true;
				}
			}
		}

		private string m_CH_DONVI_MST;
		private bool m_CH_DONVI_MSTUpdated = false;
		/// <summary>
		/// Mã số thuế đơn vị.
		/// </summary>
		public string CH_DONVI_MST
		{
			get
			{
				return m_CH_DONVI_MST;
			}
			set
			{
				if ((this.m_CH_DONVI_MST != value))
				{
					this.SendPropertyChanging("CH_DONVI_MST");
					this.m_CH_DONVI_MST = value;
					this.SendPropertyChanged("CH_DONVI_MST");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_DONVI_MSTUpdated = true;
				}
			}
		}

		private string m_CH_DONVI_TEN;
		private bool m_CH_DONVI_TENUpdated = false;
		/// <summary>
		/// Tên đơn vị.
		/// </summary>
		public string CH_DONVI_TEN
		{
			get
			{
				return m_CH_DONVI_TEN;
			}
			set
			{
				if ((this.m_CH_DONVI_TEN != value))
				{
					this.SendPropertyChanging("CH_DONVI_TEN");
					this.m_CH_DONVI_TEN = value;
					this.SendPropertyChanged("CH_DONVI_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_DONVI_TENUpdated = true;
				}
			}
		}

		private string m_CH_DONVI_DIENTHOAI;
		private bool m_CH_DONVI_DIENTHOAIUpdated = false;
		/// <summary>
		/// Điện thoại đơn vị.
		/// </summary>
		public string CH_DONVI_DIENTHOAI
		{
			get
			{
				return m_CH_DONVI_DIENTHOAI;
			}
			set
			{
				if ((this.m_CH_DONVI_DIENTHOAI != value))
				{
					this.SendPropertyChanging("CH_DONVI_DIENTHOAI");
					this.m_CH_DONVI_DIENTHOAI = value;
					this.SendPropertyChanged("CH_DONVI_DIENTHOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_DONVI_DIENTHOAIUpdated = true;
				}
			}
		}

		private string m_CH_NGUOIHOI_TAIKHOAN;
		private bool m_CH_NGUOIHOI_TAIKHOANUpdated = false;
		/// <summary>
		/// Tài khoản người hỏi.
		/// </summary>
		public string CH_NGUOIHOI_TAIKHOAN
		{
			get
			{
				return m_CH_NGUOIHOI_TAIKHOAN;
			}
			set
			{
				if ((this.m_CH_NGUOIHOI_TAIKHOAN != value))
				{
					this.SendPropertyChanging("CH_NGUOIHOI_TAIKHOAN");
					this.m_CH_NGUOIHOI_TAIKHOAN = value;
					this.SendPropertyChanged("CH_NGUOIHOI_TAIKHOAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOIHOI_TAIKHOANUpdated = true;
				}
			}
		}

		private string m_CH_NGUOIHOI_TEN;
		private bool m_CH_NGUOIHOI_TENUpdated = false;
		/// <summary>
		/// Tên người hỏi.
		/// </summary>
		public string CH_NGUOIHOI_TEN
		{
			get
			{
				return m_CH_NGUOIHOI_TEN;
			}
			set
			{
				if ((this.m_CH_NGUOIHOI_TEN != value))
				{
					this.SendPropertyChanging("CH_NGUOIHOI_TEN");
					this.m_CH_NGUOIHOI_TEN = value;
					this.SendPropertyChanged("CH_NGUOIHOI_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOIHOI_TENUpdated = true;
				}
			}
		}

		private string m_CH_NGUOIHOI_DIENTHOAI;
		private bool m_CH_NGUOIHOI_DIENTHOAIUpdated = false;
		/// <summary>
		/// Điện thoại người hỏi.
		/// </summary>
		public string CH_NGUOIHOI_DIENTHOAI
		{
			get
			{
				return m_CH_NGUOIHOI_DIENTHOAI;
			}
			set
			{
				if ((this.m_CH_NGUOIHOI_DIENTHOAI != value))
				{
					this.SendPropertyChanging("CH_NGUOIHOI_DIENTHOAI");
					this.m_CH_NGUOIHOI_DIENTHOAI = value;
					this.SendPropertyChanged("CH_NGUOIHOI_DIENTHOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOIHOI_DIENTHOAIUpdated = true;
				}
			}
		}

		private string m_CH_NGUOIHOI_EMAIL;
		private bool m_CH_NGUOIHOI_EMAILUpdated = false;
		/// <summary>
		/// Email người hỏi.
		/// </summary>
		public string CH_NGUOIHOI_EMAIL
		{
			get
			{
				return m_CH_NGUOIHOI_EMAIL;
			}
			set
			{
				if ((this.m_CH_NGUOIHOI_EMAIL != value))
				{
					this.SendPropertyChanging("CH_NGUOIHOI_EMAIL");
					this.m_CH_NGUOIHOI_EMAIL = value;
					this.SendPropertyChanged("CH_NGUOIHOI_EMAIL");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOIHOI_EMAILUpdated = true;
				}
			}
		}

		private string m_CH_NGUOIHOI_MAHQLIENQUAN;
		private bool m_CH_NGUOIHOI_MAHQLIENQUANUpdated = false;
		/// <summary>
		/// Mã Hải quan liên quan người hỏi.
		/// </summary>
		public string CH_NGUOIHOI_MAHQLIENQUAN
		{
			get
			{
				return m_CH_NGUOIHOI_MAHQLIENQUAN;
			}
			set
			{
				if ((this.m_CH_NGUOIHOI_MAHQLIENQUAN != value))
				{
					this.SendPropertyChanging("CH_NGUOIHOI_MAHQLIENQUAN");
					this.m_CH_NGUOIHOI_MAHQLIENQUAN = value;
					this.SendPropertyChanged("CH_NGUOIHOI_MAHQLIENQUAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOIHOI_MAHQLIENQUANUpdated = true;
				}
			}
		}

		private string m_CH_NGUOIHOI_TENHQLIENQUAN;
		private bool m_CH_NGUOIHOI_TENHQLIENQUANUpdated = false;
		/// <summary>
		/// Tên Hải quan liên quan tới người hỏi.
		/// </summary>
		public string CH_NGUOIHOI_TENHQLIENQUAN
		{
			get
			{
				return m_CH_NGUOIHOI_TENHQLIENQUAN;
			}
			set
			{
				if ((this.m_CH_NGUOIHOI_TENHQLIENQUAN != value))
				{
					this.SendPropertyChanging("CH_NGUOIHOI_TENHQLIENQUAN");
					this.m_CH_NGUOIHOI_TENHQLIENQUAN = value;
					this.SendPropertyChanged("CH_NGUOIHOI_TENHQLIENQUAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOIHOI_TENHQLIENQUANUpdated = true;
				}
			}
		}

		private string m_CH_CAUHOI_PHANLOAI;
		private bool m_CH_CAUHOI_PHANLOAIUpdated = false;
		/// <summary>
		/// Phân loại câu hỏi.
		/// </summary>
		public string CH_CAUHOI_PHANLOAI
		{
			get
			{
				return m_CH_CAUHOI_PHANLOAI;
			}
			set
			{
				if ((this.m_CH_CAUHOI_PHANLOAI != value))
				{
					this.SendPropertyChanging("CH_CAUHOI_PHANLOAI");
					this.m_CH_CAUHOI_PHANLOAI = value;
					this.SendPropertyChanged("CH_CAUHOI_PHANLOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_CAUHOI_PHANLOAIUpdated = true;
				}
			}
		}

		private string m_CH_CAUHOI_NOIDUNGCAUHOI;
		private bool m_CH_CAUHOI_NOIDUNGCAUHOIUpdated = false;
		/// <summary>
		/// Nội dung câu hỏi.
		/// </summary>
		public string CH_CAUHOI_NOIDUNGCAUHOI
		{
			get
			{
				return m_CH_CAUHOI_NOIDUNGCAUHOI;
			}
			set
			{
				if ((this.m_CH_CAUHOI_NOIDUNGCAUHOI != value))
				{
					this.SendPropertyChanging("CH_CAUHOI_NOIDUNGCAUHOI");
					this.m_CH_CAUHOI_NOIDUNGCAUHOI = value;
					this.SendPropertyChanged("CH_CAUHOI_NOIDUNGCAUHOI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_CAUHOI_NOIDUNGCAUHOIUpdated = true;
				}
			}
		}

		private DateTime? m_CH_CAUHOI_NGAYHOI;
		private bool m_CH_CAUHOI_NGAYHOIUpdated = false;
		/// <summary>
		/// Ngày hỏi.
		/// </summary>
		public DateTime? CH_CAUHOI_NGAYHOI
		{
			get
			{
				return m_CH_CAUHOI_NGAYHOI;
			}
			set
			{
				if ((this.m_CH_CAUHOI_NGAYHOI != value))
				{
					this.SendPropertyChanging("CH_CAUHOI_NGAYHOI");
					this.m_CH_CAUHOI_NGAYHOI = value;
					this.SendPropertyChanged("CH_CAUHOI_NGAYHOI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_CAUHOI_NGAYHOIUpdated = true;
				}
			}
		}

		private string m_CH_CAUHOI_NOIDUNGTRALOI;
		private bool m_CH_CAUHOI_NOIDUNGTRALOIUpdated = false;
		/// <summary>
		/// Nội dung câu trả lời.
		/// </summary>
		public string CH_CAUHOI_NOIDUNGTRALOI
		{
			get
			{
				return m_CH_CAUHOI_NOIDUNGTRALOI;
			}
			set
			{
				if ((this.m_CH_CAUHOI_NOIDUNGTRALOI != value))
				{
					this.SendPropertyChanging("CH_CAUHOI_NOIDUNGTRALOI");
					this.m_CH_CAUHOI_NOIDUNGTRALOI = value;
					this.SendPropertyChanged("CH_CAUHOI_NOIDUNGTRALOI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_CAUHOI_NOIDUNGTRALOIUpdated = true;
				}
			}
		}

		private DateTime? m_CH_CAUHOI_NGAYTRALOI;
		private bool m_CH_CAUHOI_NGAYTRALOIUpdated = false;
		/// <summary>
		/// Ngày trả lời.
		/// </summary>
		public DateTime? CH_CAUHOI_NGAYTRALOI
		{
			get
			{
				return m_CH_CAUHOI_NGAYTRALOI;
			}
			set
			{
				if ((this.m_CH_CAUHOI_NGAYTRALOI != value))
				{
					this.SendPropertyChanging("CH_CAUHOI_NGAYTRALOI");
					this.m_CH_CAUHOI_NGAYTRALOI = value;
					this.SendPropertyChanged("CH_CAUHOI_NGAYTRALOI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_CAUHOI_NGAYTRALOIUpdated = true;
				}
			}
		}

		private string m_CH_NGUOITRALOI_TAIKHOAN;
		private bool m_CH_NGUOITRALOI_TAIKHOANUpdated = false;
		/// <summary>
		/// Tài khoản người trả lời.
		/// </summary>
		public string CH_NGUOITRALOI_TAIKHOAN
		{
			get
			{
				return m_CH_NGUOITRALOI_TAIKHOAN;
			}
			set
			{
				if ((this.m_CH_NGUOITRALOI_TAIKHOAN != value))
				{
					this.SendPropertyChanging("CH_NGUOITRALOI_TAIKHOAN");
					this.m_CH_NGUOITRALOI_TAIKHOAN = value;
					this.SendPropertyChanged("CH_NGUOITRALOI_TAIKHOAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOITRALOI_TAIKHOANUpdated = true;
				}
			}
		}

		private string m_CH_NGUOITRALOI_TEN;
		private bool m_CH_NGUOITRALOI_TENUpdated = false;
		/// <summary>
		/// Tên người trả lời.
		/// </summary>
		public string CH_NGUOITRALOI_TEN
		{
			get
			{
				return m_CH_NGUOITRALOI_TEN;
			}
			set
			{
				if ((this.m_CH_NGUOITRALOI_TEN != value))
				{
					this.SendPropertyChanging("CH_NGUOITRALOI_TEN");
					this.m_CH_NGUOITRALOI_TEN = value;
					this.SendPropertyChanged("CH_NGUOITRALOI_TEN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_NGUOITRALOI_TENUpdated = true;
				}
			}
		}

		private string m_CH_FULLTEXT_SEARCH;
		private bool m_CH_FULLTEXT_SEARCHUpdated = false;
		/// <summary>
		/// Trường dữ liệu dùng để tìm kiếm, là nội dung ghép của tất cả các trường bên trên, bao gồm cả nội dung có dấu và nội dung không dấu để tìm kiếm tiếng việt không dấu.
		/// </summary>
		public string CH_FULLTEXT_SEARCH
		{
			get
			{
				return m_CH_FULLTEXT_SEARCH;
			}
			set
			{
				if ((this.m_CH_FULLTEXT_SEARCH != value))
				{
					this.SendPropertyChanging("CH_FULLTEXT_SEARCH");
					this.m_CH_FULLTEXT_SEARCH = value;
					this.SendPropertyChanged("CH_FULLTEXT_SEARCH");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_CH_FULLTEXT_SEARCHUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM CAUHOI " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[CH_ID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_GROUPID]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_DOITUONGHOI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_DONVI_MST]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_DONVI_TEN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_DONVI_DIENTHOAI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOIHOI_TAIKHOAN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOIHOI_TEN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOIHOI_DIENTHOAI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOIHOI_EMAIL]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOIHOI_MAHQLIENQUAN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOIHOI_TENHQLIENQUAN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_CAUHOI_PHANLOAI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_CAUHOI_NOIDUNGCAUHOI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_CAUHOI_NGAYHOI]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_CAUHOI_NOIDUNGTRALOI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_CAUHOI_NGAYTRALOI]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOITRALOI_TAIKHOAN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_NGUOITRALOI_TEN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[CH_FULLTEXT_SEARCH]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("CH_ID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_GROUPID", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_DOITUONGHOI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_DONVI_MST", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_DONVI_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_DONVI_DIENTHOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOIHOI_TAIKHOAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOIHOI_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOIHOI_DIENTHOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOIHOI_EMAIL", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOIHOI_MAHQLIENQUAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOIHOI_TENHQLIENQUAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_CAUHOI_PHANLOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_CAUHOI_NOIDUNGCAUHOI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_CAUHOI_NGAYHOI", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_CAUHOI_NOIDUNGTRALOI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_CAUHOI_NGAYTRALOI", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOITRALOI_TAIKHOAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_NGUOITRALOI_TEN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("CH_FULLTEXT_SEARCH", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO CAUHOI ([CH_ID], [CH_GROUPID], [CH_DOITUONGHOI], [CH_DONVI_MST], [CH_DONVI_TEN], [CH_DONVI_DIENTHOAI], [CH_NGUOIHOI_TAIKHOAN], [CH_NGUOIHOI_TEN], [CH_NGUOIHOI_DIENTHOAI], [CH_NGUOIHOI_EMAIL], [CH_NGUOIHOI_MAHQLIENQUAN], [CH_NGUOIHOI_TENHQLIENQUAN], [CH_CAUHOI_PHANLOAI], [CH_CAUHOI_NOIDUNGCAUHOI], [CH_CAUHOI_NGAYHOI], [CH_CAUHOI_NOIDUNGTRALOI], [CH_CAUHOI_NGAYTRALOI], [CH_NGUOITRALOI_TAIKHOAN], [CH_NGUOITRALOI_TEN], [CH_FULLTEXT_SEARCH]) VALUES(").Append("@CH_ID").Append(",").Append("@CH_GROUPID").Append(",").Append("@CH_DOITUONGHOI").Append(",").Append("@CH_DONVI_MST").Append(",").Append("@CH_DONVI_TEN").Append(",").Append("@CH_DONVI_DIENTHOAI").Append(",").Append("@CH_NGUOIHOI_TAIKHOAN").Append(",").Append("@CH_NGUOIHOI_TEN").Append(",").Append("@CH_NGUOIHOI_DIENTHOAI").Append(",").Append("@CH_NGUOIHOI_EMAIL").Append(",").Append("@CH_NGUOIHOI_MAHQLIENQUAN").Append(",").Append("@CH_NGUOIHOI_TENHQLIENQUAN").Append(",").Append("@CH_CAUHOI_PHANLOAI").Append(",").Append("@CH_CAUHOI_NOIDUNGCAUHOI").Append(",").Append("@CH_CAUHOI_NGAYHOI").Append(",").Append("@CH_CAUHOI_NOIDUNGTRALOI").Append(",").Append("@CH_CAUHOI_NGAYTRALOI").Append(",").Append("@CH_NGUOITRALOI_TAIKHOAN").Append(",").Append("@CH_NGUOITRALOI_TEN").Append(",").Append("@CH_FULLTEXT_SEARCH").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO CAUHOI (CH_ID, CH_GROUPID, CH_DOITUONGHOI, CH_DONVI_MST, CH_DONVI_TEN, CH_DONVI_DIENTHOAI, CH_NGUOIHOI_TAIKHOAN, CH_NGUOIHOI_TEN, CH_NGUOIHOI_DIENTHOAI, CH_NGUOIHOI_EMAIL, CH_NGUOIHOI_MAHQLIENQUAN, CH_NGUOIHOI_TENHQLIENQUAN, CH_CAUHOI_PHANLOAI, CH_CAUHOI_NOIDUNGCAUHOI, CH_CAUHOI_NGAYHOI, CH_CAUHOI_NOIDUNGTRALOI, CH_CAUHOI_NGAYTRALOI, CH_NGUOITRALOI_TAIKHOAN, CH_NGUOITRALOI_TEN, CH_FULLTEXT_SEARCH) VALUES(").Append(":CH_ID").Append(",").Append(":CH_GROUPID").Append(",").Append(":CH_DOITUONGHOI").Append(",").Append(":CH_DONVI_MST").Append(",").Append(":CH_DONVI_TEN").Append(",").Append(":CH_DONVI_DIENTHOAI").Append(",").Append(":CH_NGUOIHOI_TAIKHOAN").Append(",").Append(":CH_NGUOIHOI_TEN").Append(",").Append(":CH_NGUOIHOI_DIENTHOAI").Append(",").Append(":CH_NGUOIHOI_EMAIL").Append(",").Append(":CH_NGUOIHOI_MAHQLIENQUAN").Append(",").Append(":CH_NGUOIHOI_TENHQLIENQUAN").Append(",").Append(":CH_CAUHOI_PHANLOAI").Append(",").Append(":CH_CAUHOI_NOIDUNGCAUHOI").Append(",").Append(":CH_CAUHOI_NGAYHOI").Append(",").Append(":CH_CAUHOI_NOIDUNGTRALOI").Append(",").Append(":CH_CAUHOI_NGAYTRALOI").Append(",").Append(":CH_NGUOITRALOI_TAIKHOAN").Append(",").Append(":CH_NGUOITRALOI_TEN").Append(",").Append(":CH_FULLTEXT_SEARCH").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE CAUHOI SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_CH_GROUPIDUpdated ? string.Format(",[CH_GROUPID] = {0}", "@CH_GROUPID") : string.Empty).Append(m_CH_DOITUONGHOIUpdated ? string.Format(",[CH_DOITUONGHOI] = {0}", "@CH_DOITUONGHOI") : string.Empty).Append(m_CH_DONVI_MSTUpdated ? string.Format(",[CH_DONVI_MST] = {0}", "@CH_DONVI_MST") : string.Empty).Append(m_CH_DONVI_TENUpdated ? string.Format(",[CH_DONVI_TEN] = {0}", "@CH_DONVI_TEN") : string.Empty).Append(m_CH_DONVI_DIENTHOAIUpdated ? string.Format(",[CH_DONVI_DIENTHOAI] = {0}", "@CH_DONVI_DIENTHOAI") : string.Empty).Append(m_CH_NGUOIHOI_TAIKHOANUpdated ? string.Format(",[CH_NGUOIHOI_TAIKHOAN] = {0}", "@CH_NGUOIHOI_TAIKHOAN") : string.Empty).Append(m_CH_NGUOIHOI_TENUpdated ? string.Format(",[CH_NGUOIHOI_TEN] = {0}", "@CH_NGUOIHOI_TEN") : string.Empty).Append(m_CH_NGUOIHOI_DIENTHOAIUpdated ? string.Format(",[CH_NGUOIHOI_DIENTHOAI] = {0}", "@CH_NGUOIHOI_DIENTHOAI") : string.Empty).Append(m_CH_NGUOIHOI_EMAILUpdated ? string.Format(",[CH_NGUOIHOI_EMAIL] = {0}", "@CH_NGUOIHOI_EMAIL") : string.Empty).Append(m_CH_NGUOIHOI_MAHQLIENQUANUpdated ? string.Format(",[CH_NGUOIHOI_MAHQLIENQUAN] = {0}", "@CH_NGUOIHOI_MAHQLIENQUAN") : string.Empty).Append(m_CH_NGUOIHOI_TENHQLIENQUANUpdated ? string.Format(",[CH_NGUOIHOI_TENHQLIENQUAN] = {0}", "@CH_NGUOIHOI_TENHQLIENQUAN") : string.Empty).Append(m_CH_CAUHOI_PHANLOAIUpdated ? string.Format(",[CH_CAUHOI_PHANLOAI] = {0}", "@CH_CAUHOI_PHANLOAI") : string.Empty).Append(m_CH_CAUHOI_NOIDUNGCAUHOIUpdated ? string.Format(",[CH_CAUHOI_NOIDUNGCAUHOI] = {0}", "@CH_CAUHOI_NOIDUNGCAUHOI") : string.Empty).Append(m_CH_CAUHOI_NGAYHOIUpdated ? string.Format(",[CH_CAUHOI_NGAYHOI] = {0}", "@CH_CAUHOI_NGAYHOI") : string.Empty).Append(m_CH_CAUHOI_NOIDUNGTRALOIUpdated ? string.Format(",[CH_CAUHOI_NOIDUNGTRALOI] = {0}", "@CH_CAUHOI_NOIDUNGTRALOI") : string.Empty).Append(m_CH_CAUHOI_NGAYTRALOIUpdated ? string.Format(",[CH_CAUHOI_NGAYTRALOI] = {0}", "@CH_CAUHOI_NGAYTRALOI") : string.Empty).Append(m_CH_NGUOITRALOI_TAIKHOANUpdated ? string.Format(",[CH_NGUOITRALOI_TAIKHOAN] = {0}", "@CH_NGUOITRALOI_TAIKHOAN") : string.Empty).Append(m_CH_NGUOITRALOI_TENUpdated ? string.Format(",[CH_NGUOITRALOI_TEN] = {0}", "@CH_NGUOITRALOI_TEN") : string.Empty).Append(m_CH_FULLTEXT_SEARCHUpdated ? string.Format(",[CH_FULLTEXT_SEARCH] = {0}", "@CH_FULLTEXT_SEARCH") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_CH_GROUPIDUpdated ? string.Format(",CH_GROUPID = {0}", ":CH_GROUPID") : string.Empty).Append(m_CH_DOITUONGHOIUpdated ? string.Format(",CH_DOITUONGHOI = {0}", ":CH_DOITUONGHOI") : string.Empty).Append(m_CH_DONVI_MSTUpdated ? string.Format(",CH_DONVI_MST = {0}", ":CH_DONVI_MST") : string.Empty).Append(m_CH_DONVI_TENUpdated ? string.Format(",CH_DONVI_TEN = {0}", ":CH_DONVI_TEN") : string.Empty).Append(m_CH_DONVI_DIENTHOAIUpdated ? string.Format(",CH_DONVI_DIENTHOAI = {0}", ":CH_DONVI_DIENTHOAI") : string.Empty).Append(m_CH_NGUOIHOI_TAIKHOANUpdated ? string.Format(",CH_NGUOIHOI_TAIKHOAN = {0}", ":CH_NGUOIHOI_TAIKHOAN") : string.Empty).Append(m_CH_NGUOIHOI_TENUpdated ? string.Format(",CH_NGUOIHOI_TEN = {0}", ":CH_NGUOIHOI_TEN") : string.Empty).Append(m_CH_NGUOIHOI_DIENTHOAIUpdated ? string.Format(",CH_NGUOIHOI_DIENTHOAI = {0}", ":CH_NGUOIHOI_DIENTHOAI") : string.Empty).Append(m_CH_NGUOIHOI_EMAILUpdated ? string.Format(",CH_NGUOIHOI_EMAIL = {0}", ":CH_NGUOIHOI_EMAIL") : string.Empty).Append(m_CH_NGUOIHOI_MAHQLIENQUANUpdated ? string.Format(",CH_NGUOIHOI_MAHQLIENQUAN = {0}", ":CH_NGUOIHOI_MAHQLIENQUAN") : string.Empty).Append(m_CH_NGUOIHOI_TENHQLIENQUANUpdated ? string.Format(",CH_NGUOIHOI_TENHQLIENQUAN = {0}", ":CH_NGUOIHOI_TENHQLIENQUAN") : string.Empty).Append(m_CH_CAUHOI_PHANLOAIUpdated ? string.Format(",CH_CAUHOI_PHANLOAI = {0}", ":CH_CAUHOI_PHANLOAI") : string.Empty).Append(m_CH_CAUHOI_NOIDUNGCAUHOIUpdated ? string.Format(",CH_CAUHOI_NOIDUNGCAUHOI = {0}", ":CH_CAUHOI_NOIDUNGCAUHOI") : string.Empty).Append(m_CH_CAUHOI_NGAYHOIUpdated ? string.Format(",CH_CAUHOI_NGAYHOI = {0}", ":CH_CAUHOI_NGAYHOI") : string.Empty).Append(m_CH_CAUHOI_NOIDUNGTRALOIUpdated ? string.Format(",CH_CAUHOI_NOIDUNGTRALOI = {0}", ":CH_CAUHOI_NOIDUNGTRALOI") : string.Empty).Append(m_CH_CAUHOI_NGAYTRALOIUpdated ? string.Format(",CH_CAUHOI_NGAYTRALOI = {0}", ":CH_CAUHOI_NGAYTRALOI") : string.Empty).Append(m_CH_NGUOITRALOI_TAIKHOANUpdated ? string.Format(",CH_NGUOITRALOI_TAIKHOAN = {0}", ":CH_NGUOITRALOI_TAIKHOAN") : string.Empty).Append(m_CH_NGUOITRALOI_TENUpdated ? string.Format(",CH_NGUOITRALOI_TEN = {0}", ":CH_NGUOITRALOI_TEN") : string.Empty).Append(m_CH_FULLTEXT_SEARCHUpdated ? string.Format(",CH_FULLTEXT_SEARCH = {0}", ":CH_FULLTEXT_SEARCH") : string.Empty);
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
				sbSQL.AppendFormat("[CH_GROUPID] = {0}", "@CH_GROUPID").AppendFormat(",[CH_DOITUONGHOI] = {0}", "@CH_DOITUONGHOI").AppendFormat(",[CH_DONVI_MST] = {0}", "@CH_DONVI_MST").AppendFormat(",[CH_DONVI_TEN] = {0}", "@CH_DONVI_TEN").AppendFormat(",[CH_DONVI_DIENTHOAI] = {0}", "@CH_DONVI_DIENTHOAI").AppendFormat(",[CH_NGUOIHOI_TAIKHOAN] = {0}", "@CH_NGUOIHOI_TAIKHOAN").AppendFormat(",[CH_NGUOIHOI_TEN] = {0}", "@CH_NGUOIHOI_TEN").AppendFormat(",[CH_NGUOIHOI_DIENTHOAI] = {0}", "@CH_NGUOIHOI_DIENTHOAI").AppendFormat(",[CH_NGUOIHOI_EMAIL] = {0}", "@CH_NGUOIHOI_EMAIL").AppendFormat(",[CH_NGUOIHOI_MAHQLIENQUAN] = {0}", "@CH_NGUOIHOI_MAHQLIENQUAN").AppendFormat(",[CH_NGUOIHOI_TENHQLIENQUAN] = {0}", "@CH_NGUOIHOI_TENHQLIENQUAN").AppendFormat(",[CH_CAUHOI_PHANLOAI] = {0}", "@CH_CAUHOI_PHANLOAI").AppendFormat(",[CH_CAUHOI_NOIDUNGCAUHOI] = {0}", "@CH_CAUHOI_NOIDUNGCAUHOI").AppendFormat(",[CH_CAUHOI_NGAYHOI] = {0}", "@CH_CAUHOI_NGAYHOI").AppendFormat(",[CH_CAUHOI_NOIDUNGTRALOI] = {0}", "@CH_CAUHOI_NOIDUNGTRALOI").AppendFormat(",[CH_CAUHOI_NGAYTRALOI] = {0}", "@CH_CAUHOI_NGAYTRALOI").AppendFormat(",[CH_NGUOITRALOI_TAIKHOAN] = {0}", "@CH_NGUOITRALOI_TAIKHOAN").AppendFormat(",[CH_NGUOITRALOI_TEN] = {0}", "@CH_NGUOITRALOI_TEN").AppendFormat(",[CH_FULLTEXT_SEARCH] = {0}", "@CH_FULLTEXT_SEARCH");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("CH_GROUPID = {0}", ":CH_GROUPID").AppendFormat(",CH_DOITUONGHOI = {0}", ":CH_DOITUONGHOI").AppendFormat(",CH_DONVI_MST = {0}", ":CH_DONVI_MST").AppendFormat(",CH_DONVI_TEN = {0}", ":CH_DONVI_TEN").AppendFormat(",CH_DONVI_DIENTHOAI = {0}", ":CH_DONVI_DIENTHOAI").AppendFormat(",CH_NGUOIHOI_TAIKHOAN = {0}", ":CH_NGUOIHOI_TAIKHOAN").AppendFormat(",CH_NGUOIHOI_TEN = {0}", ":CH_NGUOIHOI_TEN").AppendFormat(",CH_NGUOIHOI_DIENTHOAI = {0}", ":CH_NGUOIHOI_DIENTHOAI").AppendFormat(",CH_NGUOIHOI_EMAIL = {0}", ":CH_NGUOIHOI_EMAIL").AppendFormat(",CH_NGUOIHOI_MAHQLIENQUAN = {0}", ":CH_NGUOIHOI_MAHQLIENQUAN").AppendFormat(",CH_NGUOIHOI_TENHQLIENQUAN = {0}", ":CH_NGUOIHOI_TENHQLIENQUAN").AppendFormat(",CH_CAUHOI_PHANLOAI = {0}", ":CH_CAUHOI_PHANLOAI").AppendFormat(",CH_CAUHOI_NOIDUNGCAUHOI = {0}", ":CH_CAUHOI_NOIDUNGCAUHOI").AppendFormat(",CH_CAUHOI_NGAYHOI = {0}", ":CH_CAUHOI_NGAYHOI").AppendFormat(",CH_CAUHOI_NOIDUNGTRALOI = {0}", ":CH_CAUHOI_NOIDUNGTRALOI").AppendFormat(",CH_CAUHOI_NGAYTRALOI = {0}", ":CH_CAUHOI_NGAYTRALOI").AppendFormat(",CH_NGUOITRALOI_TAIKHOAN = {0}", ":CH_NGUOITRALOI_TAIKHOAN").AppendFormat(",CH_NGUOITRALOI_TEN = {0}", ":CH_NGUOITRALOI_TEN").AppendFormat(",CH_FULLTEXT_SEARCH = {0}", ":CH_FULLTEXT_SEARCH");
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
			return clsDAL.DeleteString("CAUHOI", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[CH_ID] = {0}", "@CH_ID");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("CH_ID = {0}", ":CH_ID");
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
			paramList.Add(clsDAL.CreateParameter("CH_ID", "Integer", clsDAL.ToDBParam(CH_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("CH_GROUPID", "Integer", clsDAL.ToDBParam(CH_GROUPID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DOITUONGHOI", "WChar", clsDAL.ToDBParam(CH_DOITUONGHOI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DONVI_MST", "WChar", clsDAL.ToDBParam(CH_DONVI_MST, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DONVI_TEN", "WChar", clsDAL.ToDBParam(CH_DONVI_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DONVI_DIENTHOAI", "WChar", clsDAL.ToDBParam(CH_DONVI_DIENTHOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_TAIKHOAN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_TAIKHOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_TEN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_DIENTHOAI", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_DIENTHOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_EMAIL", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_EMAIL, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_MAHQLIENQUAN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_MAHQLIENQUAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_TENHQLIENQUAN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_TENHQLIENQUAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_PHANLOAI", "WChar", clsDAL.ToDBParam(CH_CAUHOI_PHANLOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NOIDUNGCAUHOI", "WChar", clsDAL.ToDBParam(CH_CAUHOI_NOIDUNGCAUHOI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NGAYHOI", "Date", clsDAL.ToDBParam(CH_CAUHOI_NGAYHOI, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NOIDUNGTRALOI", "WChar", clsDAL.ToDBParam(CH_CAUHOI_NOIDUNGTRALOI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NGAYTRALOI", "Date", clsDAL.ToDBParam(CH_CAUHOI_NGAYTRALOI, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOITRALOI_TAIKHOAN", "WChar", clsDAL.ToDBParam(CH_NGUOITRALOI_TAIKHOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOITRALOI_TEN", "WChar", clsDAL.ToDBParam(CH_NGUOITRALOI_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_FULLTEXT_SEARCH", "WChar", clsDAL.ToDBParam(CH_FULLTEXT_SEARCH, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_ID", "Integer", clsDAL.ToDBParam(CH_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("CH_ID", "Integer", clsDAL.ToDBParam(CH_ID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_GROUPID", "Integer", clsDAL.ToDBParam(CH_GROUPID, ProType.NUMBER, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DOITUONGHOI", "WChar", clsDAL.ToDBParam(CH_DOITUONGHOI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DONVI_MST", "WChar", clsDAL.ToDBParam(CH_DONVI_MST, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DONVI_TEN", "WChar", clsDAL.ToDBParam(CH_DONVI_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_DONVI_DIENTHOAI", "WChar", clsDAL.ToDBParam(CH_DONVI_DIENTHOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_TAIKHOAN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_TAIKHOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_TEN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_DIENTHOAI", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_DIENTHOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_EMAIL", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_EMAIL, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_MAHQLIENQUAN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_MAHQLIENQUAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOIHOI_TENHQLIENQUAN", "WChar", clsDAL.ToDBParam(CH_NGUOIHOI_TENHQLIENQUAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_PHANLOAI", "WChar", clsDAL.ToDBParam(CH_CAUHOI_PHANLOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NOIDUNGCAUHOI", "WChar", clsDAL.ToDBParam(CH_CAUHOI_NOIDUNGCAUHOI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NGAYHOI", "Date", clsDAL.ToDBParam(CH_CAUHOI_NGAYHOI, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NOIDUNGTRALOI", "WChar", clsDAL.ToDBParam(CH_CAUHOI_NOIDUNGTRALOI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_CAUHOI_NGAYTRALOI", "Date", clsDAL.ToDBParam(CH_CAUHOI_NGAYTRALOI, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOITRALOI_TAIKHOAN", "WChar", clsDAL.ToDBParam(CH_NGUOITRALOI_TAIKHOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_NGUOITRALOI_TEN", "WChar", clsDAL.ToDBParam(CH_NGUOITRALOI_TEN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("CH_FULLTEXT_SEARCH", "WChar", clsDAL.ToDBParam(CH_FULLTEXT_SEARCH, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}