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
    public partial class Form_ChuDe : Form
    {
        public Form_ChuDe()
        {
            InitializeComponent();
        }

        private void Form_ChuDe_Load(object sender, EventArgs e)
        {
            ChuDe ob = new ChuDe();
            dataGridView1.DataSource = ob.Load_ChuDe();
        }

        private void Danh_STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChuDe ob = new ChuDe(txtMaCD.Text, txtTenCD.Text);
            ob.Insert(ob);
            Form_ChuDe_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChuDe ob = new ChuDe(txtMaCD.Text, txtTenCD.Text);
            ob.Update(ob);
            Form_ChuDe_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChuDe ob = new ChuDe(txtMaCD.Text, txtTenCD.Text);
            ob.Delete(ob);
            Form_ChuDe_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chon_CD(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //Cells[0] là số thứ tự
            txtMaCD.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtTenCD.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

        }


    }
}
