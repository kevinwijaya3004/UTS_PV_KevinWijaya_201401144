using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KasirBaru_Pertemuan7
{
    class Koneksi
    {
		public SqlConnection GetConn()
		{
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=LAPTOP-TV5R5C98\\SQLEXPRESS; initial catalog=Kasir; integrated security=true";
			return Conn;
		}
	}
}
