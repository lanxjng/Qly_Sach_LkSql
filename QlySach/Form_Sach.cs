using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QlySach
{
    public partial class Form_Sach : Form
    {
        public Form_Sach()
        {
            InitializeComponent();
        }

        private void Form_Sach_Load(object sender, EventArgs e)
        {
            Sach ob = new Sach();
            dataGridView1.DataSource = ob.Load_Sach();
            cbbMaCD.DataSource = ob.Load_ChuDe();
            cbbMaCD.ValueMember = "MaChuDe";
            cbbMaCD.DisplayMember = "TenChuDe";
            cbbMaNXB.DataSource = ob.Load_NXB();
            cbbMaNXB.ValueMember = "MaNxb";
            cbbMaNXB.DisplayMember = "TenNxb";
        }

        private void Chon_Sach(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //Cells[0] là số thứ tự
            txtMaSach.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtTenSach.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtGiaBan.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtMoTa.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtAnhBia.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            txtSoLgTon.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            cbbMaNXB.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
            cbbMaCD.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
        }

        private void Danh_STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach ob = new Sach(txtMaSach.Text, txtTenSach.Text,float.Parse(txtGiaBan.Text), txtMoTa.Text,
                txtAnhBia.Text, dateTimePicker1.Value,float.Parse(txtSoLgTon.Text),cbbMaNXB.Text,cbbMaCD.Text);
            ob.Insert(ob);
            Form_Sach_Load(sender, e);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach ob = new Sach(txtMaSach.Text, txtTenSach.Text, float.Parse(txtGiaBan.Text), txtMoTa.Text,
                txtAnhBia.Text, dateTimePicker1.Value, float.Parse(txtSoLgTon.Text), cbbMaNXB.Text, cbbMaCD.Text);
            ob.Update(ob);
            Form_Sach_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sach ob = new Sach(txtMaSach.Text, txtTenSach.Text, float.Parse(txtGiaBan.Text), txtMoTa.Text,
                txtAnhBia.Text, dateTimePicker1.Value, float.Parse(txtSoLgTon.Text), cbbMaNXB.Text, cbbMaCD.Text);
            ob.Delete(ob);
            Form_Sach_Load(sender, e);

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
