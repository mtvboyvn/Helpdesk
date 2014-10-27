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
	/// Generated Class for Table : HQ_SDONVI.
	/// </summary>
	public partial class HQ_SDONVI : TableBase
	{
		public HQ_SDONVI() : base(){}

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
		private string m_MA_DV;
		/// <summary>
		/// MA_DV.
		/// </summary>
		public string MA_DV
		{
			get
			{
				return m_MA_DV;
			}
			set
			{
				if ((this.m_MA_DV != value))
				{
					this.SendPropertyChanging("MA_DV");
					this.m_MA_DV = value;
					this.SendPropertyChanged("MA_DV");
				}
			}
		}

		private string m_TEN_DV;
		private bool m_TEN_DVUpdated = false;
		/// <summary>
		/// TEN_DV.
		/// </summary>
		public string TEN_DV
		{
			get
			{
				return m_TEN_DV;
			}
			set
			{
				if ((this.m_TEN_DV != value))
				{
					this.SendPropertyChanging("TEN_DV");
					this.m_TEN_DV = value;
					this.SendPropertyChanged("TEN_DV");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TEN_DVUpdated = true;
				}
			}
		}

		private string m_TEN_GD;
		private bool m_TEN_GDUpdated = false;
		/// <summary>
		/// TEN_GD.
		/// </summary>
		public string TEN_GD
		{
			get
			{
				return m_TEN_GD;
			}
			set
			{
				if ((this.m_TEN_GD != value))
				{
					this.SendPropertyChanging("TEN_GD");
					this.m_TEN_GD = value;
					this.SendPropertyChanged("TEN_GD");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TEN_GDUpdated = true;
				}
			}
		}

		private string m_MALHDN;
		private bool m_MALHDNUpdated = false;
		/// <summary>
		/// MALHDN.
		/// </summary>
		public string MALHDN
		{
			get
			{
				return m_MALHDN;
			}
			set
			{
				if ((this.m_MALHDN != value))
				{
					this.SendPropertyChanging("MALHDN");
					this.m_MALHDN = value;
					this.SendPropertyChanged("MALHDN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_MALHDNUpdated = true;
				}
			}
		}

		private string m_TWDP;
		private bool m_TWDPUpdated = false;
		/// <summary>
		/// TWDP.
		/// </summary>
		public string TWDP
		{
			get
			{
				return m_TWDP;
			}
			set
			{
				if ((this.m_TWDP != value))
				{
					this.SendPropertyChanging("TWDP");
					this.m_TWDP = value;
					this.SendPropertyChanged("TWDP");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TWDPUpdated = true;
				}
			}
		}

		private string m_NOIQUANLY;
		private bool m_NOIQUANLYUpdated = false;
		/// <summary>
		/// NOIQUANLY.
		/// </summary>
		public string NOIQUANLY
		{
			get
			{
				return m_NOIQUANLY;
			}
			set
			{
				if ((this.m_NOIQUANLY != value))
				{
					this.SendPropertyChanging("NOIQUANLY");
					this.m_NOIQUANLY = value;
					this.SendPropertyChanged("NOIQUANLY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NOIQUANLYUpdated = true;
				}
			}
		}

		private string m_SOGPKD;
		private bool m_SOGPKDUpdated = false;
		/// <summary>
		/// SOGPKD.
		/// </summary>
		public string SOGPKD
		{
			get
			{
				return m_SOGPKD;
			}
			set
			{
				if ((this.m_SOGPKD != value))
				{
					this.SendPropertyChanging("SOGPKD");
					this.m_SOGPKD = value;
					this.SendPropertyChanged("SOGPKD");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_SOGPKDUpdated = true;
				}
			}
		}

		private DateTime? m_NGAYCAPGPKD;
		private bool m_NGAYCAPGPKDUpdated = false;
		/// <summary>
		/// NGAYCAPGPKD.
		/// </summary>
		public DateTime? NGAYCAPGPKD
		{
			get
			{
				return m_NGAYCAPGPKD;
			}
			set
			{
				if ((this.m_NGAYCAPGPKD != value))
				{
					this.SendPropertyChanging("NGAYCAPGPKD");
					this.m_NGAYCAPGPKD = value;
					this.SendPropertyChanged("NGAYCAPGPKD");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NGAYCAPGPKDUpdated = true;
				}
			}
		}

		private string m_DIACHI;
		private bool m_DIACHIUpdated = false;
		/// <summary>
		/// DIACHI.
		/// </summary>
		public string DIACHI
		{
			get
			{
				return m_DIACHI;
			}
			set
			{
				if ((this.m_DIACHI != value))
				{
					this.SendPropertyChanging("DIACHI");
					this.m_DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DIACHIUpdated = true;
				}
			}
		}

		private string m_DIENTHOAI;
		private bool m_DIENTHOAIUpdated = false;
		/// <summary>
		/// DIENTHOAI.
		/// </summary>
		public string DIENTHOAI
		{
			get
			{
				return m_DIENTHOAI;
			}
			set
			{
				if ((this.m_DIENTHOAI != value))
				{
					this.SendPropertyChanging("DIENTHOAI");
					this.m_DIENTHOAI = value;
					this.SendPropertyChanged("DIENTHOAI");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DIENTHOAIUpdated = true;
				}
			}
		}

		private string m_FAX;
		private bool m_FAXUpdated = false;
		/// <summary>
		/// FAX.
		/// </summary>
		public string FAX
		{
			get
			{
				return m_FAX;
			}
			set
			{
				if ((this.m_FAX != value))
				{
					this.SendPropertyChanging("FAX");
					this.m_FAX = value;
					this.SendPropertyChanged("FAX");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_FAXUpdated = true;
				}
			}
		}

		private string m_GIAMDOC;
		private bool m_GIAMDOCUpdated = false;
		/// <summary>
		/// GIAMDOC.
		/// </summary>
		public string GIAMDOC
		{
			get
			{
				return m_GIAMDOC;
			}
			set
			{
				if ((this.m_GIAMDOC != value))
				{
					this.SendPropertyChanging("GIAMDOC");
					this.m_GIAMDOC = value;
					this.SendPropertyChanged("GIAMDOC");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_GIAMDOCUpdated = true;
				}
			}
		}

		private string m_KETOAN;
		private bool m_KETOANUpdated = false;
		/// <summary>
		/// KETOAN.
		/// </summary>
		public string KETOAN
		{
			get
			{
				return m_KETOAN;
			}
			set
			{
				if ((this.m_KETOAN != value))
				{
					this.SendPropertyChanging("KETOAN");
					this.m_KETOAN = value;
					this.SendPropertyChanged("KETOAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_KETOANUpdated = true;
				}
			}
		}

		private string m_TAIKHOAN;
		private bool m_TAIKHOANUpdated = false;
		/// <summary>
		/// TAIKHOAN.
		/// </summary>
		public string TAIKHOAN
		{
			get
			{
				return m_TAIKHOAN;
			}
			set
			{
				if ((this.m_TAIKHOAN != value))
				{
					this.SendPropertyChanging("TAIKHOAN");
					this.m_TAIKHOAN = value;
					this.SendPropertyChanged("TAIKHOAN");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TAIKHOANUpdated = true;
				}
			}
		}

		private string m_PPT_GTGT;
		private bool m_PPT_GTGTUpdated = false;
		/// <summary>
		/// PPT_GTGT.
		/// </summary>
		public string PPT_GTGT
		{
			get
			{
				return m_PPT_GTGT;
			}
			set
			{
				if ((this.m_PPT_GTGT != value))
				{
					this.SendPropertyChanging("PPT_GTGT");
					this.m_PPT_GTGT = value;
					this.SendPropertyChanged("PPT_GTGT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_PPT_GTGTUpdated = true;
				}
			}
		}

		private string m_TT_DV;
		private bool m_TT_DVUpdated = false;
		/// <summary>
		/// TT_DV.
		/// </summary>
		public string TT_DV
		{
			get
			{
				return m_TT_DV;
			}
			set
			{
				if ((this.m_TT_DV != value))
				{
					this.SendPropertyChanging("TT_DV");
					this.m_TT_DV = value;
					this.SendPropertyChanged("TT_DV");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_TT_DVUpdated = true;
				}
			}
		}

		private string m_MLNSCHUONG;
		private bool m_MLNSCHUONGUpdated = false;
		/// <summary>
		/// MLNSCHUONG.
		/// </summary>
		public string MLNSCHUONG
		{
			get
			{
				return m_MLNSCHUONG;
			}
			set
			{
				if ((this.m_MLNSCHUONG != value))
				{
					this.SendPropertyChanging("MLNSCHUONG");
					this.m_MLNSCHUONG = value;
					this.SendPropertyChanged("MLNSCHUONG");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_MLNSCHUONGUpdated = true;
				}
			}
		}

		private DateTime? m_NGAYDANGKY;
		private bool m_NGAYDANGKYUpdated = false;
		/// <summary>
		/// NGAYDANGKY.
		/// </summary>
		public DateTime? NGAYDANGKY
		{
			get
			{
				return m_NGAYDANGKY;
			}
			set
			{
				if ((this.m_NGAYDANGKY != value))
				{
					this.SendPropertyChanging("NGAYDANGKY");
					this.m_NGAYDANGKY = value;
					this.SendPropertyChanged("NGAYDANGKY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NGAYDANGKYUpdated = true;
				}
			}
		}

		private DateTime? m_NGAYGIAITHE;
		private bool m_NGAYGIAITHEUpdated = false;
		/// <summary>
		/// NGAYGIAITHE.
		/// </summary>
		public DateTime? NGAYGIAITHE
		{
			get
			{
				return m_NGAYGIAITHE;
			}
			set
			{
				if ((this.m_NGAYGIAITHE != value))
				{
					this.SendPropertyChanging("NGAYGIAITHE");
					this.m_NGAYGIAITHE = value;
					this.SendPropertyChanged("NGAYGIAITHE");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NGAYGIAITHEUpdated = true;
				}
			}
		}

		private string m_LOAI_GIAY;
		private bool m_LOAI_GIAYUpdated = false;
		/// <summary>
		/// LOAI_GIAY.
		/// </summary>
		public string LOAI_GIAY
		{
			get
			{
				return m_LOAI_GIAY;
			}
			set
			{
				if ((this.m_LOAI_GIAY != value))
				{
					this.SendPropertyChanging("LOAI_GIAY");
					this.m_LOAI_GIAY = value;
					this.SendPropertyChanged("LOAI_GIAY");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_LOAI_GIAYUpdated = true;
				}
			}
		}

		private DateTime? m_NGAY_CAP_NHAT;
		private bool m_NGAY_CAP_NHATUpdated = false;
		/// <summary>
		/// NGAY_CAP_NHAT.
		/// </summary>
		public DateTime? NGAY_CAP_NHAT
		{
			get
			{
				return m_NGAY_CAP_NHAT;
			}
			set
			{
				if ((this.m_NGAY_CAP_NHAT != value))
				{
					this.SendPropertyChanging("NGAY_CAP_NHAT");
					this.m_NGAY_CAP_NHAT = value;
					this.SendPropertyChanged("NGAY_CAP_NHAT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_NGAY_CAP_NHATUpdated = true;
				}
			}
		}

		private string m_DA_KET_XUAT;
		private bool m_DA_KET_XUATUpdated = false;
		/// <summary>
		/// DA_KET_XUAT.
		/// </summary>
		public string DA_KET_XUAT
		{
			get
			{
				return m_DA_KET_XUAT;
			}
			set
			{
				if ((this.m_DA_KET_XUAT != value))
				{
					this.SendPropertyChanging("DA_KET_XUAT");
					this.m_DA_KET_XUAT = value;
					this.SendPropertyChanged("DA_KET_XUAT");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_DA_KET_XUATUpdated = true;
				}
			}
		}

		private string m_Ma_DVQL;
		private bool m_Ma_DVQLUpdated = false;
		/// <summary>
		/// Ma_DVQL.
		/// </summary>
		public string Ma_DVQL
		{
			get
			{
				return m_Ma_DVQL;
			}
			set
			{
				if ((this.m_Ma_DVQL != value))
				{
					this.SendPropertyChanging("Ma_DVQL");
					this.m_Ma_DVQL = value;
					this.SendPropertyChanged("Ma_DVQL");
					if ((this.DataStatus != DBStatus.Inserted))
						this.m_Ma_DVQLUpdated = true;
				}
			}
		}

		/// <summary>
		/// Tạo câu SQL lấy dữ liệu.
		/// </summary>
		public override string SelectStatement(string Fields, string WhereClause, string OrderClause)
		{
			return "SELECT " + Fields + " FROM HQ_SDONVI " + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause) + (string.IsNullOrEmpty(OrderClause) ? string.Empty : " ORDER BY " + OrderClause);
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
				sbSQL.Append(clsDAL.SelectField("[MA_DV]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TEN_DV]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TEN_GD]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[MALHDN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TWDP]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[NOIQUANLY]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[SOGPKD]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[NGAYCAPGPKD]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[DIACHI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[DIENTHOAI]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[FAX]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[GIAMDOC]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[KETOAN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TAIKHOAN]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[PPT_GTGT]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[TT_DV]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[MLNSCHUONG]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[NGAYDANGKY]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[NGAYGIAITHE]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[LOAI_GIAY]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[NGAY_CAP_NHAT]", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[DA_KET_XUAT]", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("[Ma_DVQL]", ProType.OTHER, this.DataManagement));
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(clsDAL.SelectField("MA_DV", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TEN_DV", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TEN_GD", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("MALHDN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TWDP", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NOIQUANLY", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("SOGPKD", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NGAYCAPGPKD", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DIACHI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DIENTHOAI", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("FAX", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("GIAMDOC", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("KETOAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TAIKHOAN", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("PPT_GTGT", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("TT_DV", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("MLNSCHUONG", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NGAYDANGKY", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NGAYGIAITHE", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("LOAI_GIAY", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("NGAY_CAP_NHAT", ProType.DATETIME, this.DataManagement)).Append(",").Append(clsDAL.SelectField("DA_KET_XUAT", ProType.OTHER, this.DataManagement)).Append(",").Append(clsDAL.SelectField("Ma_DVQL", ProType.OTHER, this.DataManagement));
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
				sbSQL.Append("INSERT INTO HQ_SDONVI ([MA_DV], [TEN_DV], [TEN_GD], [MALHDN], [TWDP], [NOIQUANLY], [SOGPKD], [NGAYCAPGPKD], [DIACHI], [DIENTHOAI], [FAX], [GIAMDOC], [KETOAN], [TAIKHOAN], [PPT_GTGT], [TT_DV], [MLNSCHUONG], [NGAYDANGKY], [NGAYGIAITHE], [LOAI_GIAY], [NGAY_CAP_NHAT], [DA_KET_XUAT], [Ma_DVQL]) VALUES(").Append("@MA_DV").Append(",").Append("@TEN_DV").Append(",").Append("@TEN_GD").Append(",").Append("@MALHDN").Append(",").Append("@TWDP").Append(",").Append("@NOIQUANLY").Append(",").Append("@SOGPKD").Append(",").Append("@NGAYCAPGPKD").Append(",").Append("@DIACHI").Append(",").Append("@DIENTHOAI").Append(",").Append("@FAX").Append(",").Append("@GIAMDOC").Append(",").Append("@KETOAN").Append(",").Append("@TAIKHOAN").Append(",").Append("@PPT_GTGT").Append(",").Append("@TT_DV").Append(",").Append("@MLNSCHUONG").Append(",").Append("@NGAYDANGKY").Append(",").Append("@NGAYGIAITHE").Append(",").Append("@LOAI_GIAY").Append(",").Append("@NGAY_CAP_NHAT").Append(",").Append("@DA_KET_XUAT").Append(",").Append("@Ma_DVQL").Append(")");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append("INSERT INTO HQ_SDONVI (MA_DV, TEN_DV, TEN_GD, MALHDN, TWDP, NOIQUANLY, SOGPKD, NGAYCAPGPKD, DIACHI, DIENTHOAI, FAX, GIAMDOC, KETOAN, TAIKHOAN, PPT_GTGT, TT_DV, MLNSCHUONG, NGAYDANGKY, NGAYGIAITHE, LOAI_GIAY, NGAY_CAP_NHAT, DA_KET_XUAT, Ma_DVQL) VALUES(").Append(":MA_DV").Append(",").Append(":TEN_DV").Append(",").Append(":TEN_GD").Append(",").Append(":MALHDN").Append(",").Append(":TWDP").Append(",").Append(":NOIQUANLY").Append(",").Append(":SOGPKD").Append(",").Append(":NGAYCAPGPKD").Append(",").Append(":DIACHI").Append(",").Append(":DIENTHOAI").Append(",").Append(":FAX").Append(",").Append(":GIAMDOC").Append(",").Append(":KETOAN").Append(",").Append(":TAIKHOAN").Append(",").Append(":PPT_GTGT").Append(",").Append(":TT_DV").Append(",").Append(":MLNSCHUONG").Append(",").Append(":NGAYDANGKY").Append(",").Append(":NGAYGIAITHE").Append(",").Append(":LOAI_GIAY").Append(",").Append(":NGAY_CAP_NHAT").Append(",").Append(":DA_KET_XUAT").Append(",").Append(":Ma_DVQL").Append(")");
				break;
			}
			return sbSQL.ToString();		}

		/// <summary>
		/// Tạo câu SQL cập nhật dữ liệu.
		/// </summary>
		public override string UpdateStatement(string Fields, string WhereClause)
		{
			return "UPDATE HQ_SDONVI SET " + Fields + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.Append(m_TEN_DVUpdated ? string.Format(",[TEN_DV] = {0}", "@TEN_DV") : string.Empty).Append(m_TEN_GDUpdated ? string.Format(",[TEN_GD] = {0}", "@TEN_GD") : string.Empty).Append(m_MALHDNUpdated ? string.Format(",[MALHDN] = {0}", "@MALHDN") : string.Empty).Append(m_TWDPUpdated ? string.Format(",[TWDP] = {0}", "@TWDP") : string.Empty).Append(m_NOIQUANLYUpdated ? string.Format(",[NOIQUANLY] = {0}", "@NOIQUANLY") : string.Empty).Append(m_SOGPKDUpdated ? string.Format(",[SOGPKD] = {0}", "@SOGPKD") : string.Empty).Append(m_NGAYCAPGPKDUpdated ? string.Format(",[NGAYCAPGPKD] = {0}", "@NGAYCAPGPKD") : string.Empty).Append(m_DIACHIUpdated ? string.Format(",[DIACHI] = {0}", "@DIACHI") : string.Empty).Append(m_DIENTHOAIUpdated ? string.Format(",[DIENTHOAI] = {0}", "@DIENTHOAI") : string.Empty).Append(m_FAXUpdated ? string.Format(",[FAX] = {0}", "@FAX") : string.Empty).Append(m_GIAMDOCUpdated ? string.Format(",[GIAMDOC] = {0}", "@GIAMDOC") : string.Empty).Append(m_KETOANUpdated ? string.Format(",[KETOAN] = {0}", "@KETOAN") : string.Empty).Append(m_TAIKHOANUpdated ? string.Format(",[TAIKHOAN] = {0}", "@TAIKHOAN") : string.Empty).Append(m_PPT_GTGTUpdated ? string.Format(",[PPT_GTGT] = {0}", "@PPT_GTGT") : string.Empty).Append(m_TT_DVUpdated ? string.Format(",[TT_DV] = {0}", "@TT_DV") : string.Empty).Append(m_MLNSCHUONGUpdated ? string.Format(",[MLNSCHUONG] = {0}", "@MLNSCHUONG") : string.Empty).Append(m_NGAYDANGKYUpdated ? string.Format(",[NGAYDANGKY] = {0}", "@NGAYDANGKY") : string.Empty).Append(m_NGAYGIAITHEUpdated ? string.Format(",[NGAYGIAITHE] = {0}", "@NGAYGIAITHE") : string.Empty).Append(m_LOAI_GIAYUpdated ? string.Format(",[LOAI_GIAY] = {0}", "@LOAI_GIAY") : string.Empty).Append(m_NGAY_CAP_NHATUpdated ? string.Format(",[NGAY_CAP_NHAT] = {0}", "@NGAY_CAP_NHAT") : string.Empty).Append(m_DA_KET_XUATUpdated ? string.Format(",[DA_KET_XUAT] = {0}", "@DA_KET_XUAT") : string.Empty).Append(m_Ma_DVQLUpdated ? string.Format(",[Ma_DVQL] = {0}", "@Ma_DVQL") : string.Empty);
				break;
				 
				case DBManagement.Oracle:
				sbSQL.Append(m_TEN_DVUpdated ? string.Format(",TEN_DV = {0}", ":TEN_DV") : string.Empty).Append(m_TEN_GDUpdated ? string.Format(",TEN_GD = {0}", ":TEN_GD") : string.Empty).Append(m_MALHDNUpdated ? string.Format(",MALHDN = {0}", ":MALHDN") : string.Empty).Append(m_TWDPUpdated ? string.Format(",TWDP = {0}", ":TWDP") : string.Empty).Append(m_NOIQUANLYUpdated ? string.Format(",NOIQUANLY = {0}", ":NOIQUANLY") : string.Empty).Append(m_SOGPKDUpdated ? string.Format(",SOGPKD = {0}", ":SOGPKD") : string.Empty).Append(m_NGAYCAPGPKDUpdated ? string.Format(",NGAYCAPGPKD = {0}", ":NGAYCAPGPKD") : string.Empty).Append(m_DIACHIUpdated ? string.Format(",DIACHI = {0}", ":DIACHI") : string.Empty).Append(m_DIENTHOAIUpdated ? string.Format(",DIENTHOAI = {0}", ":DIENTHOAI") : string.Empty).Append(m_FAXUpdated ? string.Format(",FAX = {0}", ":FAX") : string.Empty).Append(m_GIAMDOCUpdated ? string.Format(",GIAMDOC = {0}", ":GIAMDOC") : string.Empty).Append(m_KETOANUpdated ? string.Format(",KETOAN = {0}", ":KETOAN") : string.Empty).Append(m_TAIKHOANUpdated ? string.Format(",TAIKHOAN = {0}", ":TAIKHOAN") : string.Empty).Append(m_PPT_GTGTUpdated ? string.Format(",PPT_GTGT = {0}", ":PPT_GTGT") : string.Empty).Append(m_TT_DVUpdated ? string.Format(",TT_DV = {0}", ":TT_DV") : string.Empty).Append(m_MLNSCHUONGUpdated ? string.Format(",MLNSCHUONG = {0}", ":MLNSCHUONG") : string.Empty).Append(m_NGAYDANGKYUpdated ? string.Format(",NGAYDANGKY = {0}", ":NGAYDANGKY") : string.Empty).Append(m_NGAYGIAITHEUpdated ? string.Format(",NGAYGIAITHE = {0}", ":NGAYGIAITHE") : string.Empty).Append(m_LOAI_GIAYUpdated ? string.Format(",LOAI_GIAY = {0}", ":LOAI_GIAY") : string.Empty).Append(m_NGAY_CAP_NHATUpdated ? string.Format(",NGAY_CAP_NHAT = {0}", ":NGAY_CAP_NHAT") : string.Empty).Append(m_DA_KET_XUATUpdated ? string.Format(",DA_KET_XUAT = {0}", ":DA_KET_XUAT") : string.Empty).Append(m_Ma_DVQLUpdated ? string.Format(",Ma_DVQL = {0}", ":Ma_DVQL") : string.Empty);
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
				sbSQL.AppendFormat("[TEN_DV] = {0}", "@TEN_DV").AppendFormat(",[TEN_GD] = {0}", "@TEN_GD").AppendFormat(",[MALHDN] = {0}", "@MALHDN").AppendFormat(",[TWDP] = {0}", "@TWDP").AppendFormat(",[NOIQUANLY] = {0}", "@NOIQUANLY").AppendFormat(",[SOGPKD] = {0}", "@SOGPKD").AppendFormat(",[NGAYCAPGPKD] = {0}", "@NGAYCAPGPKD").AppendFormat(",[DIACHI] = {0}", "@DIACHI").AppendFormat(",[DIENTHOAI] = {0}", "@DIENTHOAI").AppendFormat(",[FAX] = {0}", "@FAX").AppendFormat(",[GIAMDOC] = {0}", "@GIAMDOC").AppendFormat(",[KETOAN] = {0}", "@KETOAN").AppendFormat(",[TAIKHOAN] = {0}", "@TAIKHOAN").AppendFormat(",[PPT_GTGT] = {0}", "@PPT_GTGT").AppendFormat(",[TT_DV] = {0}", "@TT_DV").AppendFormat(",[MLNSCHUONG] = {0}", "@MLNSCHUONG").AppendFormat(",[NGAYDANGKY] = {0}", "@NGAYDANGKY").AppendFormat(",[NGAYGIAITHE] = {0}", "@NGAYGIAITHE").AppendFormat(",[LOAI_GIAY] = {0}", "@LOAI_GIAY").AppendFormat(",[NGAY_CAP_NHAT] = {0}", "@NGAY_CAP_NHAT").AppendFormat(",[DA_KET_XUAT] = {0}", "@DA_KET_XUAT").AppendFormat(",[Ma_DVQL] = {0}", "@Ma_DVQL");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("TEN_DV = {0}", ":TEN_DV").AppendFormat(",TEN_GD = {0}", ":TEN_GD").AppendFormat(",MALHDN = {0}", ":MALHDN").AppendFormat(",TWDP = {0}", ":TWDP").AppendFormat(",NOIQUANLY = {0}", ":NOIQUANLY").AppendFormat(",SOGPKD = {0}", ":SOGPKD").AppendFormat(",NGAYCAPGPKD = {0}", ":NGAYCAPGPKD").AppendFormat(",DIACHI = {0}", ":DIACHI").AppendFormat(",DIENTHOAI = {0}", ":DIENTHOAI").AppendFormat(",FAX = {0}", ":FAX").AppendFormat(",GIAMDOC = {0}", ":GIAMDOC").AppendFormat(",KETOAN = {0}", ":KETOAN").AppendFormat(",TAIKHOAN = {0}", ":TAIKHOAN").AppendFormat(",PPT_GTGT = {0}", ":PPT_GTGT").AppendFormat(",TT_DV = {0}", ":TT_DV").AppendFormat(",MLNSCHUONG = {0}", ":MLNSCHUONG").AppendFormat(",NGAYDANGKY = {0}", ":NGAYDANGKY").AppendFormat(",NGAYGIAITHE = {0}", ":NGAYGIAITHE").AppendFormat(",LOAI_GIAY = {0}", ":LOAI_GIAY").AppendFormat(",NGAY_CAP_NHAT = {0}", ":NGAY_CAP_NHAT").AppendFormat(",DA_KET_XUAT = {0}", ":DA_KET_XUAT").AppendFormat(",Ma_DVQL = {0}", ":Ma_DVQL");
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
			return clsDAL.DeleteString("HQ_SDONVI", this.DataManagement) + (string.IsNullOrEmpty(WhereClause) ? string.Empty : " WHERE " + WhereClause);
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
				sbSQL.AppendFormat("[MA_DV] = {0}", "@MA_DV");
				break;
				 
				case DBManagement.Oracle:
				sbSQL.AppendFormat("MA_DV = {0}", ":MA_DV");
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
			paramList.Add(clsDAL.CreateParameter("MA_DV", "WChar", clsDAL.ToDBParam(MA_DV, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> UpdateParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("TEN_DV", "WChar", clsDAL.ToDBParam(TEN_DV, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TEN_GD", "WChar", clsDAL.ToDBParam(TEN_GD, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("MALHDN", "WChar", clsDAL.ToDBParam(MALHDN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TWDP", "WChar", clsDAL.ToDBParam(TWDP, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NOIQUANLY", "WChar", clsDAL.ToDBParam(NOIQUANLY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SOGPKD", "WChar", clsDAL.ToDBParam(SOGPKD, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAYCAPGPKD", "Date", clsDAL.ToDBParam(NGAYCAPGPKD, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("DIACHI", "WChar", clsDAL.ToDBParam(DIACHI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("DIENTHOAI", "WChar", clsDAL.ToDBParam(DIENTHOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("FAX", "WChar", clsDAL.ToDBParam(FAX, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("GIAMDOC", "WChar", clsDAL.ToDBParam(GIAMDOC, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("KETOAN", "WChar", clsDAL.ToDBParam(KETOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TAIKHOAN", "WChar", clsDAL.ToDBParam(TAIKHOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("PPT_GTGT", "WChar", clsDAL.ToDBParam(PPT_GTGT, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TT_DV", "WChar", clsDAL.ToDBParam(TT_DV, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("MLNSCHUONG", "WChar", clsDAL.ToDBParam(MLNSCHUONG, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAYDANGKY", "Date", clsDAL.ToDBParam(NGAYDANGKY, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAYGIAITHE", "Date", clsDAL.ToDBParam(NGAYGIAITHE, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("LOAI_GIAY", "WChar", clsDAL.ToDBParam(LOAI_GIAY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAY_CAP_NHAT", "Date", clsDAL.ToDBParam(NGAY_CAP_NHAT, ProType.DATETIME, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("DA_KET_XUAT", "WChar", clsDAL.ToDBParam(DA_KET_XUAT, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("Ma_DVQL", "WChar", clsDAL.ToDBParam(Ma_DVQL, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("MA_DV", "WChar", clsDAL.ToDBParam(MA_DV, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}

		/// <summary>
		/// Tạo parameter để Insert dữ liệu.
		/// </summary>
		public override List<IDbDataParameter> InsertParameters()
		{
			List<IDbDataParameter> paramList = new List<IDbDataParameter>();
			paramList.Add(clsDAL.CreateParameter("MA_DV", "WChar", clsDAL.ToDBParam(MA_DV, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TEN_DV", "WChar", clsDAL.ToDBParam(TEN_DV, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TEN_GD", "WChar", clsDAL.ToDBParam(TEN_GD, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("MALHDN", "WChar", clsDAL.ToDBParam(MALHDN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TWDP", "WChar", clsDAL.ToDBParam(TWDP, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NOIQUANLY", "WChar", clsDAL.ToDBParam(NOIQUANLY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("SOGPKD", "WChar", clsDAL.ToDBParam(SOGPKD, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAYCAPGPKD", "Date", clsDAL.ToDBParam(NGAYCAPGPKD, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("DIACHI", "WChar", clsDAL.ToDBParam(DIACHI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("DIENTHOAI", "WChar", clsDAL.ToDBParam(DIENTHOAI, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("FAX", "WChar", clsDAL.ToDBParam(FAX, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("GIAMDOC", "WChar", clsDAL.ToDBParam(GIAMDOC, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("KETOAN", "WChar", clsDAL.ToDBParam(KETOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TAIKHOAN", "WChar", clsDAL.ToDBParam(TAIKHOAN, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("PPT_GTGT", "WChar", clsDAL.ToDBParam(PPT_GTGT, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("TT_DV", "WChar", clsDAL.ToDBParam(TT_DV, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("MLNSCHUONG", "WChar", clsDAL.ToDBParam(MLNSCHUONG, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAYDANGKY", "Date", clsDAL.ToDBParam(NGAYDANGKY, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAYGIAITHE", "Date", clsDAL.ToDBParam(NGAYGIAITHE, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("LOAI_GIAY", "WChar", clsDAL.ToDBParam(LOAI_GIAY, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("NGAY_CAP_NHAT", "Date", clsDAL.ToDBParam(NGAY_CAP_NHAT, ProType.DATETIME, this.DataManagement), this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("DA_KET_XUAT", "WChar", clsDAL.ToDBParam(DA_KET_XUAT, ProType.STRING, this.DataManagement) , this.DataManagement));
			paramList.Add(clsDAL.CreateParameter("Ma_DVQL", "WChar", clsDAL.ToDBParam(Ma_DVQL, ProType.STRING, this.DataManagement) , this.DataManagement));
			return paramList;
		}
	}
}