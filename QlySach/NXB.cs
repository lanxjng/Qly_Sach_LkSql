using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QlySach
{
    class NXB
    {
        private string MaNXB;
        private string TenNXB;
        private string DiaChi;
        private string DienThoai;
        public NXB() { }
        public NXB(string MaNXB, string TenNXB, string DiaChi, string DienThoai)
        {
            this.MaNXB = MaNXB;
            this.TenNXB = TenNXB;
            this.DiaChi = DiaChi;
            this.DienThoai = DienThoai;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_NXB()
        {
            string sql = "select * from NhaXuatBan";
            return ob.Load(sql);
        }
        public void Insert(NXB ob1)
        {
            string sql = "Insert into NhaXuatBan values('" + ob1.MaNXB + "','" + ob1.TenNXB + "','" + ob1.DiaChi + "' , '" + ob1.DienThoai +"')";
            ob.Execute(sql);
        }
        public void Update(NXB ob1)
        {
            string sql = "Update NhaXuatBan set TenNxb='" + ob1.TenNXB + "'" +
                " where MaNxb='" + ob1.MaNXB + "'";
            ob.Execute(sql);
        }
        public void Delete(NXB ob1)
        {
            string sql = "Delete from NhaXuatBan where MaNxb='" + ob1.MaNXB + "'";
            ob.Execute(sql);
        }
    }
}
