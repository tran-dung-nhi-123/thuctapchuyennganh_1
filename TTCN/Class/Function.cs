using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCN.Class
{
    internal class Function
    {
        public static SqlConnection Conn;
        public static string connString;
        public static void Connect()
        {
            connString = "Data Source=DESKTOP-6P2TSJE\\SQLEXPRESS;Initial Catalog=Thuctapchuyennganh;Integrated Security=True;Encrypt=False";
            Conn = new SqlConnection();
            Conn.ConnectionString = connString;
            Conn.Open();
        }
        public static void Disconnect()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;

            }
        }
        public static DataTable Getdatatotable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter();
            mydata.SelectCommand = new SqlCommand();
            mydata.SelectCommand.Connection = Class.Function.Conn;
            mydata.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            mydata.Fill(table);
            return table;
        }
        public static bool checkkey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Class.Function.Conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        //viet cau lenh runsql de thuc thi cua lenh sql
        public static void runsql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Class.Function.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
