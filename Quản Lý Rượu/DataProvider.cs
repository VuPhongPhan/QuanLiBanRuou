using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Rượu
{
    class DataProvider
    {
        private string connectionSTR = "Data Source=.\\sqlexpress02;Initial Catalog = QLRuou; Integrated Security = True";

        public DataTable ExecQuery(string query)
        {
            DataTable data = new DataTable();
            
            SqlConnection conn = new SqlConnection(connectionSTR);

            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            adapter.Fill(data);
            
            conn.Close();

            return data;
        }
         public int ExecuteNon(string query, object[] parameter = null)
         {
             int data = 0;
            using (SqlConnection con = new SqlConnection(connectionSTR))
            {
             con.Open();

             SqlCommand command = new SqlCommand(query, con);

            if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                        }
                    }
                }
             data = command.ExecuteNonQuery();

             con.Close();
            }
            return data;
        }
    }
}
