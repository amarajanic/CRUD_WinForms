namespace UI.Forme
{
    partial class frmUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.nudUserId = new System.Windows.Forms.NumericUpDown();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.epUserId = new System.Windows.Forms.ErrorProvider(this.components);
            this.epId = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBody = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBody)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(87, 133);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(120, 96);
            this.rtbBody.TabIndex = 18;
            this.rtbBody.Text = "";
            this.rtbBody.Validating += new System.ComponentModel.CancelEventHandler(this.rtbBody_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Id:";
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(87, 56);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(120, 23);
            this.nudId.TabIndex = 13;
            this.nudId.Validating += new System.ComponentModel.CancelEventHandler(this.nudId_Validating);
            // 
            // nudUserId
            // 
            this.nudUserId.Location = new System.Drawing.Point(87, 12);
            this.nudUserId.Name = "nudUserId";
            this.nudUserId.Size = new System.Drawing.Size(120, 23);
            this.nudUserId.TabIndex = 12;
            this.nudUserId.Validating += new System.ComponentModel.CancelEventHandler(this.nudUserId_Validating);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 91);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(120, 23);
            this.tbTitle.TabIndex = 11;
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 44);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // epUserId
            // 
            this.epUserId.ContainerControl = this;
            // 
            // epId
            // 
            this.epId.ContainerControl = this;
            // 
            // epTitle
            // 
            this.epTitle.ContainerControl = this;
            // 
            // epBody
            // 
            this.epBody.ContainerControl = this;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 313);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.nudUserId);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdate";
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbBody;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nudId;
        private NumericUpDown nudUserId;
        private TextBox tbTitle;
        private Button btnUpdate;
        private ErrorProvider epUserId;
        private ErrorProvider epId;
        private ErrorProvider epTitle;
        private ErrorProvider epBody;
    }
}