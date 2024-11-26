using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241126
{
    public partial class Formchose : Form
    {
        public Formchose()
        {
            InitializeComponent();
        }

        private void 類別管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 forn = new Form1();
           forn.MdiParent = this;
            forn.Show();
        }

        private void 資料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 forn2 = new Form2();
            forn2.MdiParent = this;
            forn2.Show();
        }
    }
}
