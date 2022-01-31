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
    public partial class frmCreate : Form
    {
        PostProcessor postProcessor;
        public frmCreate()
        {
            InitializeComponent();
            postProcessor = new PostProcessor();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                PostModel p = new PostModel()
                {
                    userId = (int)nudUserId.Value,
                    body = rtbBody.Text,
                    title = tbTitle.Text
                };

                var response = postProcessor.SendPost(p);

                MessageBox.Show(response.Result);

            }
            
        }

        private void nudUserId_Validating(object sender, CancelEventArgs e)
        {
            if(nudUserId.Value == 0)
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

        private void rtbBody_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(rtbBody.Text))
            {
                e.Cancel = true;
                rtbBody.Focus();
                epBody.SetError(rtbBody, "Body can not be empty!");
            }
            else
            {
                e.Cancel= false;
                epBody.SetError(rtbBody, "");
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
    }
}
