/*
 * ten: le thanh thien
 * lop: cd16tt2
 * ma so: 16211tt0473
 * giao vien: Le Tho
 * ten do an: quan ly cua hang dien may
 * phan duoc giao: quan ly ban hang
 * */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiDienMay.DTO
{
    public static class DataProvider
    {

        private static string ConnectString = @"Data Source=.\SQLExpress;Initial Catalog=QL_CUAHANG_DIENMAY;Integrated Security=True";

        /// <summary>
        /// Trả về DataTable khi thực hiện câu query (SELECT)
        /// </summary>
        /// <param name="query">Câu truy vấn cần thực thi</param>
        /// <param name="Parametters">Danh sách tham số nếu có</param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string query, object[] Parametters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection Connection = new SqlConnection(ConnectString))
            {
                try
                {
                    Connection.Open();
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại!\nVui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                SqlCommand command = new SqlCommand(query, Connection);

                if (Parametters != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item[0] == '@')
                        {
                            command.Parameters.AddWithValue(item, Parametters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                
                Connection.Close();
            }
            
            return data;
        }

        /// <summary>
        /// Trả về số dòng ảnh hưởng khi thực thi query (Insert, Update, Delete)
        /// </summary>
        /// <param name="query">Câu truy vấn thêm, xoá, sửa</param>
        /// <param name="Parametters">Danh sách tham số nếu có</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string query, object[] Parametters = null)
        {
            int data = 0;

            using (SqlConnection Connection = new SqlConnection(ConnectString))
            {
                Connection.Open();

                SqlCommand command = new SqlCommand(query, Connection);

                if (Parametters != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item[0] == '@') 
                        {
                            command.Parameters.AddWithValue(item, Parametters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                Connection.Close();
            }

            return data;
        }

        /// <summary>
        /// Trả về 1 object là giá trị của ô đầu tiên trong bảng kết quả.
        /// Thường dùng để lấy kết quả tính toán.
        /// </summary>
        /// <param name="query">Câu truy vấn cần thực thi</param>
        /// <param name="Parametters">Danh sách tham số nếu có</param>
        /// <returns></returns>
        public static object ExecuteScalar(string query, object[] Parametters = null)
        {
            object data = null;

            using (SqlConnection Connection = new SqlConnection(ConnectString))
            {
                Connection.Open();

                SqlCommand command = new SqlCommand(query, Connection);

                if (Parametters != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item[0] == '@')
                        {
                            command.Parameters.AddWithValue(item, Parametters[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                    
                Connection.Close();
            }
            
            return data;
        }
    }


}
