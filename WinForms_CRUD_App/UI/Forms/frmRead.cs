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
    public partial class frmRead : Form
    {
        PostProcessor postProcessor;
        public frmRead()
        {
            InitializeComponent();
            postProcessor = new PostProcessor();
        }

        private async void frmRead_Load(object sender, EventArgs e)
        {
            var post = await postProcessor.LoadAllPosts();

            if (post != null)
            {
                dgvPostovi.DataSource = post;
            }
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(nudId.Value.ToString());
            var post = await postProcessor.GetById(id);

            MessageBox.Show(post.ToString());
        }

        private void dgvPostovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPostovi.Rows[e.RowIndex];

                PostModel post = new PostModel()
                {
                    Id = (int)row.Cells[0].Value,
                    userId = (int)row.Cells[1].Value,
                    title = (string)row.Cells[2].Value,
                    body = (string)row.Cells[3].Value

                };

                frmUpdate frm = new frmUpdate(post);

                frm.Show();
            }
        }
    }
}
