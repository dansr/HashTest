
namespace HashTest
{
    partial class frmStep1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTesto1 = new System.Windows.Forms.Label();
            this.txtTesto1 = new System.Windows.Forms.TextBox();
            this.txtTesto2 = new System.Windows.Forms.TextBox();
            this.lblTesto2 = new System.Windows.Forms.Label();
            this.btnCompara = new System.Windows.Forms.Button();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTesto1
            // 
            this.lblTesto1.AutoSize = true;
            this.lblTesto1.Location = new System.Drawing.Point(31, 47);
            this.lblTesto1.Name = "lblTesto1";
            this.lblTesto1.Size = new System.Drawing.Size(40, 13);
            this.lblTesto1.TabIndex = 0;
            this.lblTesto1.Text = "Testo1";
            // 
            // txtTesto1
            // 
            this.txtTesto1.Location = new System.Drawing.Point(34, 63);
            this.txtTesto1.Name = "txtTesto1";
            this.txtTesto1.Size = new System.Drawing.Size(190, 20);
            this.txtTesto1.TabIndex = 1;
            // 
            // txtTesto2
            // 
            this.txtTesto2.Location = new System.Drawing.Point(34, 130);
            this.txtTesto2.Name = "txtTesto2";
            this.txtTesto2.Size = new System.Drawing.Size(190, 20);
            this.txtTesto2.TabIndex = 3;
            // 
            // lblTesto2
            // 
            this.lblTesto2.AutoSize = true;
            this.lblTesto2.Location = new System.Drawing.Point(31, 114);
            this.lblTesto2.Name = "lblTesto2";
            this.lblTesto2.Size = new System.Drawing.Size(40, 13);
            this.lblTesto2.TabIndex = 2;
            this.lblTesto2.Text = "Testo2";
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(149, 197);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(75, 23);
            this.btnCompara.TabIndex = 4;
            this.btnCompara.Text = "Compara";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(31, 13);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(38, 13);
            this.lblStep1.TabIndex = 5;
            this.lblStep1.Text = "lblText";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(261, 63);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(404, 157);
            this.txtResult.TabIndex = 6;
            // 
            // frmStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 254);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtTesto1);
            this.Controls.Add(this.lblTesto1);
            this.Controls.Add(this.txtTesto2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.lblTesto2);
            this.Name = "frmStep1";
            this.Text = "Step1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTesto1;
        private System.Windows.Forms.TextBox txtTesto1;
        private System.Windows.Forms.TextBox txtTesto2;
        private System.Windows.Forms.Label lblTesto2;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.TextBox txtResult;
    }
}

