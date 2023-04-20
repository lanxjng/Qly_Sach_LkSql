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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhậpBảngChủĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ChuDe f = new Form_ChuDe();
            f.Show();
        }

        private void nhậpBảngNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NXB f = new Form_NXB();
            f.Show();
        }

        private void nhậpBảngSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sach f = new Form_Sach();
            f.Show();
        }
    }
}
