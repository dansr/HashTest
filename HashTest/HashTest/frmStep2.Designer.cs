namespace HashTest
{
    partial class frmStep2
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
            this.grdDati = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDati)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDati
            // 
            this.grdDati.AllowUserToAddRows = false;
            this.grdDati.AllowUserToDeleteRows = false;
            this.grdDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.CheckSum,
            this.IsValid});
            this.grdDati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDati.Location = new System.Drawing.Point(0, 0);
            this.grdDati.Name = "grdDati";
            this.grdDati.ReadOnly = true;
            this.grdDati.RowHeadersWidth = 51;
            this.grdDati.RowTemplate.Height = 24;
            this.grdDati.Size = new System.Drawing.Size(800, 450);
            this.grdDati.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // CheckSum
            // 
            this.CheckSum.DataPropertyName = "CheckSum";
            this.CheckSum.Frozen = true;
            this.CheckSum.HeaderText = "CheckSum";
            this.CheckSum.MinimumWidth = 6;
            this.CheckSum.Name = "CheckSum";
            this.CheckSum.ReadOnly = true;
            this.CheckSum.Width = 125;
            // 
            // IsValid
            // 
            this.IsValid.DataPropertyName = "IsValid";
            this.IsValid.Frozen = true;
            this.IsValid.HeaderText = "IsValid";
            this.IsValid.MinimumWidth = 6;
            this.IsValid.Name = "IsValid";
            this.IsValid.ReadOnly = true;
            this.IsValid.Width = 125;
            // 
            // frmStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdDati);
            this.Name = "frmStep2";
            this.Text = "Step2";
            ((System.ComponentModel.ISupportInitialize)(this.grdDati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdDati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsValid;
    }
}