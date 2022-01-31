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
using Library.Interfaces;

namespace UI.Forme
{
    public partial class frmDelete : Form
    {
        
        PostProcessor postProcessor;
        public frmDelete()
        {
            InitializeComponent();
            postProcessor = new PostProcessor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(nudId.Value.ToString());

            var response = postProcessor.DeletePost(id);

            MessageBox.Show(response.Result);
        }
    }
}
