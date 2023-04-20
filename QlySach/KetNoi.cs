using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QlySach
{
    class KetNoi
    {
        public SqlConnection conn = new SqlConnection("Data Source=TRUONGJAE\\SQLEXPRESS;Initial Catalog=QlySach;Integrated Security=True");
        public void Execute(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ad.Update(dt);
            dt.AcceptChanges();
        }
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = comSelect;
            ad.Fill(dt);
            dt.AcceptChanges();
            return dt;

        }


    }
}
