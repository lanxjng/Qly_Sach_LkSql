using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QlySach
{
    internal class ChuDe
    {
        private string MaCD;
        private string TenCD;
        public ChuDe() { }
        public ChuDe(string MaCD, string TenCD)
        {
            this.MaCD = MaCD;
            this.TenCD = TenCD;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_ChuDe()
        {
            string sql = "select * from ChuDe";
            return ob.Load(sql);
        }
        public void Insert(ChuDe ob1)
        {
            string sql = "Insert into ChuDe values('" + ob1.MaCD + "','" + ob1.TenCD + "')";
            ob.Execute(sql);
        }
        public void Update(ChuDe ob1)
        {
            string sql = "Update ChuDe set TenChuDe='" + ob1.TenCD + "'" +
                " where MaChuDe='" + ob1.MaCD + "'";
            ob.Execute(sql);

        }
        public void Delete(ChuDe ob1)
        {
            string sql = "Delete from ChuDe where MaChuDe='" + ob1.MaCD + "'";
            ob.Execute(sql);
        }




    }
}
