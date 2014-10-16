using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;

namespace t
{
    public class st
    {
        //Liên quan tới CSDL
        //public static string AccessDBDir = Server.MapPath("~");
        public static string sqlSTRINGADO = "Data Source=.\\SQL2012ENT;Initial Catalog=HelpDesk;User ID=sa;pwd=1";
        public static string sqlSTRINGADO_MONITORING = "Data Source=.\\SQL2012ENT;Initial Catalog=TTDL;User ID=sa;pwd=1";
        public static string sqlSTRINGOLE = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DesignDB.mdb;Persist Security Info=True;Jet OLEDB:Database Password=tuyenchim";
        public static string sqlSTRINGLITE = "Data Source= |DataDirectory|NACCS.VN.db;Version=3;New=False;Compress=True;";
        public static string sqlSTRINGORACLE = "Data Source=//localhost:1521/orcl;User ID=thelpdesk;pwd=1";
        //public static string sqlSTRINGORACLE = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //Liên quan tới thư mục tạm, excel
        public static string TEMP_DIR = "";//Path.Combine(Server.MapPath("~"), "@temp");

        //Liên quan đến lỗi, thông báo lỗi, tính năng học lỗi
        public static string CurrentErrorFormName = "ALL";
        public static string CurrentErrorMessage = "Lỗi ngoại lệ không xác định";
        public static string CurrentErrorLearned = "0";

        //Liên quan tới tài khoản đăng nhập phần mềm này
        public static string LoginUsername = string.Empty;//Tài khoản đăng nhập vào hệ thống này
    }
}
