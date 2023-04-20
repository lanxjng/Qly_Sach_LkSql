using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QlySach
{
    class Sach
    {
        private string MaSach;
        private string TenSach;
        private float GiaBan;
        private string MoTa;
        private string AnhBia;
        private DateTime NgayCapNhat;
        private float SoLuongTon;
        private string MaNXB;
        private string MaCD;

        public Sach() { }
        public Sach(string MaSach, string TenSach, float GiaBan, string MoTa, string AnhBia, DateTime NgayCapNhat, float SoLuongTon, string MaNXB, string MaCD)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.GiaBan = GiaBan;
            this.MoTa = MoTa;
            this.AnhBia = AnhBia;
            this.NgayCapNhat = NgayCapNhat;
            this.SoLuongTon = SoLuongTon;
            this.MaNXB = MaNXB;
            this.MaCD = MaCD;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_Sach()
        {
            string sql = "select * from Sach";
            return ob.Load(sql);
        }
        public DataTable Load_ChuDe()
        {
            string sql = "select * from ChuDe";
            return ob.Load(sql);
        }
        public DataTable Load_NXB()
        {
            string sql = "select * from NhaXuatBan";
            return ob.Load(sql);
        }
        public void Insert(Sach ob1)
        {
            string sql = "Insert into Sach values('" + ob1.MaSach + "','" + ob1.TenSach + "','" + ob1.GiaBan 
                + "' , '" + ob1.MoTa + "', '" + ob1.AnhBia + "', '" + ob1.NgayCapNhat + "', '" + ob1.SoLuongTon + "', '" + ob1.MaNXB + "', '" + ob1.MaCD + "')";
            ob.Execute(sql);
        }
        public void Update(Sach ob1)
        {
            string sql = "Update Sach set TenSach='" + ob1.TenSach + "'" +
                " where MaSach='" + ob1.MaSach + "'";
            ob.Execute(sql);
        }
        public void Delete(Sach ob1)
        {
            string sql = "Delete from Sach where MaSach='" + ob1.MaSach + "'";
            ob.Execute(sql);
        }

    }
}
