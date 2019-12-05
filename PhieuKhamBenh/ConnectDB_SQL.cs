/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 09/11/2019
 * Time: 13:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;
using System.Data;
namespace PhieuKhamBenh
{
    /// <summary>
    /// Description of ConnectDB_SQL.
    /// </summary>
    public class ConnectDB_SQL
    {
        public static string StringConnectDB_SQL = null;
        private SqlConnection conn = null;
        private SqlCommand SQLcommand = null;
        public SqlDataAdapter da = null;
        public string[] x = new string[2];
        public string[] fail = new string[1];
        private SqlCommand sqlCommand;


        public ConnectDB_SQL()
        {
            conn = new SqlConnection();
        }

        public bool Fun_ConnectDB(string userName, string password)
        {
            fail[0] = "Fail";
            string connectionString = @"server=DESKTOP-19EPU5O\SQLEXPRESS; database=Kham_benh; user id=sa; password=123";
            conn.ConnectionString = connectionString;
            conn.Open();
            StringConnectDB_SQL = String.Copy(connectionString);

            string query = "select id, isadmin from tai_khoan where user1='" + userName + "' and password1='" + password + "'";
            SQLcommand = new SqlCommand(query, conn);
            SqlDataReader reader = SQLcommand.ExecuteReader();
            while (reader.Read())
            {
                x[0] = reader.GetValue(0).ToString();
                x[1] = reader.GetValue(1).ToString();
            }
            if (x[0] != null)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public object Fun_ConnectDB()
        {
            string connectionString = @"server=DESKTOP-19EPU5O\SQLEXPRESS; database=Kham_benh; user id=sa; password=123";
            conn.ConnectionString = connectionString;
            conn.Open();
            return conn;
        }

        public void closeconnect()
        {
            conn.Close();
            conn.Dispose();
        }

        public bool Fun_Register(string sFisrtName, string sLastName, string sStreet, string sPhone, string sUser, string sPass, string sEmail, string sNote, bool bAdmin)
        {
            string connectionString = @"server=DESKTOP-19EPU5O\SQLEXPRESS; database=Kham_benh; user id=sa; password=123";
            conn.ConnectionString = connectionString;
            //       conn.Open();
            StringConnectDB_SQL = String.Copy(connectionString);
            string query = "select id from tai_khoan where user1='" + sUser + "'";
            SQLcommand = new SqlCommand(query, conn);
            SqlDataReader reader = SQLcommand.ExecuteReader();
            if (reader != null)
            {
                conn.Close();
                return false;
            }
            else
            {
                query = "INSERT INTO tai_khoan (fname, lname, street1, phone, login, password, email, note, isadmin) VALUES ('" + sFisrtName + "','" + sLastName + "','" + sStreet + "','" + sPhone + "','" + sUser + "','" + sPass + "','" + sEmail + "','" + sNote + "','" + bAdmin + "')";
                SQLcommand = new SqlCommand(query, conn);
                SQLcommand.ExecuteNonQuery();
                conn.Close();
                return true;
            }




        }
        public DataTable getalluser()
        {
            string chuoiconnect = @"server=DESKTOP-19EPU5O\SQLEXPRESS; database=Kham_benh; user id=sa; password=123";
            conn.ConnectionString = chuoiconnect;
            conn.Open();


            string sql = "SELECT * FROM Item";
            //b2: tạo kết nối đến sql //
            sqlCommand = new SqlCommand(sql, conn);
            //truyền câu truy vấn vào sqladapter//
            da = new SqlDataAdapter(sql, conn);
            //mo ket noi//
            // mở dữ liệu từ sqlcommand vào datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            // dong kết nối//
            conn.Close();
            return dt;
        }
    }
}
