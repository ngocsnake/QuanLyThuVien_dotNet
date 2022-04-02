using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace ThuVien
{
    internal class Database
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=NOTHING\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True");

        public static DataTable getData(string query, Boolean coHinh)
        {
            try
            {
                connection.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dt);

                if (coHinh)
                {
                    dt.Columns.Add("hinh", Type.GetType("System.Byte[]"));

                    int a = dt.Rows.Count;

                    for (int i = 0; i < a; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        dr["hinh"] = File.ReadAllBytes(dr["hinhanh"].ToString());
                    }
                }

                connection.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static void execQuery(string query)
        {
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            connection.Close();
        }

    }
}