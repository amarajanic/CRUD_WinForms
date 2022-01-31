namespace UI.Forme
{
    partial class frmRead
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
            this.dgvPostovi = new System.Windows.Forms.DataGridView();
            this.btnGetById = new System.Windows.Forms.Button();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPostovi
            // 
            this.dgvPostovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostovi.Location = new System.Drawing.Point(12, 12);
            this.dgvPostovi.Name = "dgvPostovi";
            this.dgvPostovi.RowTemplate.Height = 25;
            this.dgvPostovi.Size = new System.Drawing.Size(632, 263);
            this.dgvPostovi.TabIndex = 0;
            this.dgvPostovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPostovi_CellContentClick);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(164, 294);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(75, 23);
            this.btnGetById.TabIndex = 1;
            this.btnGetById.Text = "Get by Id";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(12, 294);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(120, 23);
            this.nudId.TabIndex = 2;
            // 
            // frmRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 327);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.dgvPostovi);
            this.Name = "frmRead";
            this.Text = "frmRead";
            this.Load += new System.EventHandler(this.frmRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPostovi;
        private Button btnGetById;
        private NumericUpDown nudId;
    }
}