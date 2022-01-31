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
    public partial class frmUpdate : Form
    {
        PostProcessor postProcessor;
        PostModel postModel;
        public frmUpdate(PostModel p)
        {
            InitializeComponent();
            postProcessor = new PostProcessor();
            postModel = p;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                postModel.Id = (int)nudId.Value;
                postModel.userId = (int)nudUserId.Value;
                postModel.body = rtbBody.Text;
                postModel.title = tbTitle.Text;

                var response = postProcessor.UpdatePost(postModel);

                MessageBox.Show(response.Result);
            }
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            nudId.Value = postModel.Id;
            nudUserId.Value = postModel.userId;
            rtbBody.Text = postModel.body;
            tbTitle.Text = postModel.title;
        }

        private void nudUserId_Validating(object sender, CancelEventArgs e)
        {
            if (nudUserId.Value == 0)
            {
                e.Cancel = true;
                nudUserId.Focus();
                epId.SetError(nudUserId, "Id can not be 0!");
            }
            else
            {
                e.Cancel = false;
                epId.SetError(nudUserId, "");
            }
        }

        private void nudId_Validating(object sender, CancelEventArgs e)
        {
            if (nudId.Value == 0)
            {
                e.Cancel = true;
                nudId.Focus();
                epId.SetError(nudId, "Id can not be 0!");
            }
            else
            {
                e.Cancel = false;
                epId.SetError(nudId, "");
            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbTitle.Text))
            {
                e.Cancel = true;
                tbTitle.Focus();
                epTitle.SetError(tbTitle, "Title can not be empty!");
            }
            else
            {
                e.Cancel = false;
                epTitle.SetError(tbTitle, "");
            }
        }

        private void rtbBody_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(rtbBody.Text))
            {
                e.Cancel = true;
                rtbBody.Focus();
                epBody.SetError(rtbBody, "Body can not be empty!");
            }
            else
            {
                e.Cancel = false;
                epBody.SetError(rtbBody, "");
            }
        }
    }
}
