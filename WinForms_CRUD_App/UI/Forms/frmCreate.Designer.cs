namespace UI.Forme
{
    partial class frmCreate
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.nudUserId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.epId = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBody = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTitle = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 224);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(195, 44);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Send data";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(87, 61);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(120, 23);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // nudUserId
            // 
            this.nudUserId.Location = new System.Drawing.Point(87, 19);
            this.nudUserId.Name = "nudUserId";
            this.nudUserId.Size = new System.Drawing.Size(120, 23);
            this.nudUserId.TabIndex = 3;
            this.nudUserId.Validating += new System.ComponentModel.CancelEventHandler(this.nudUserId_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Body:";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(87, 103);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(120, 96);
            this.rtbBody.TabIndex = 9;
            this.rtbBody.Text = "";
            this.rtbBody.Validating += new System.ComponentModel.CancelEventHandler(this.rtbBody_Validating);
            // 
            // epId
            // 
            this.epId.ContainerControl = this;
            // 
            // epBody
            // 
            this.epBody.ContainerControl = this;
            // 
            // epTitle
            // 
            this.epTitle.ContainerControl = this;
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 282);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudUserId);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmCreate";
            this.Text = "frmCreate";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreate;
        private TextBox tbTitle;
        private NumericUpDown nudUserId;
        private Label label1;
        private Label label3;
        private Label label4;
        private RichTextBox rtbBody;
        private ErrorProvider epId;
        private ErrorProvider epBody;
        private ErrorProvider epTitle;
    }
}