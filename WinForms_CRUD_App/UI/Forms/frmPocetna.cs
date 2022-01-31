using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forme
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            frmRead frm = new frmRead();

            frm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreate frm = new frmCreate();

            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frm = new frmUpdate(new PostModel());

            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete frm = new frmDelete();

            frm.Show();
        }
    }
}
