using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGV_HS.Data
{
    class Connect
    {

        // public static string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\DuLieu.mdf;Integrated Security=True;Connect Timeout=30";
        //public static string chuoiketnoi = @"Data Source = "+ SystemInformation.ComputerName +"Initial Catalog=QuanLyGV_HS;Integrated Security=True";
        public static string chuoiketnoi = @"Data Source =GUTI14 ;Initial Catalog=QuanLyGV_HS;Integrated Security=True";
        
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static void openketnoi()
        {
            con = new SqlConnection(chuoiketnoi);
            con.Open();
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        // phuong thuc lấy 1 bảng về
        public static DataTable gettable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }
        //thực hiện lệnh sql
        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public static string read(string sql)
        {
            string kq = "";
            openketnoi();
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kq = (string)dr["ID"];
            }
            dongketnoi();
            return kq;
        }
        public static string nhanvien;
        public static int DangNhap(String tenDangNhap, String matKhau)
        {
            Connect.openketnoi();
            DataTable nd = new DataTable();
            nd = Connect.gettable("Select * from tbLOGIN where TenDN='" + tenDangNhap + "'");
            if (nd.Rows.Count == 0)
                return 0;
            String matkhau_hethong = nd.Rows[0]["MatKhau"].ToString();
            if (matkhau_hethong != matKhau)
            {
                return 1;//Sai mat khau
            }
            else
            {
                nhanvien = tenDangNhap;
                return 2;//Dang Nhap thanh cong
            }
        }
    }
}

