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
    public partial class Form_NXB : Form
    {
        public Form_NXB()
        {
            InitializeComponent();
        }

        private void Form_NXB_Load(object sender, EventArgs e)
        {
            NXB ob = new NXB();
            dataGridView1.DataSource = ob.Load_NXB();
        }

        private void Danh_STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void Chon_NXB(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //Cells[0] là số thứ tự
            txtMaNXB.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtTenNXB.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtSdt.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NXB ob = new NXB(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtSdt.Text);
            ob.Insert(ob);
            Form_NXB_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NXB ob = new NXB(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtSdt.Text);
            ob.Update(ob);
            Form_NXB_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NXB ob = new NXB(txtMaNXB.Text, txtTenNXB.Text, txtDiaChi.Text, txtSdt.Text);
            ob.Delete(ob);
            Form_NXB_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
