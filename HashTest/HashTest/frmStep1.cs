using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashTest.Extensions;

namespace HashTest
{
    public partial class frmStep1 : Form
    {
        public frmStep1()
        {
            InitializeComponent();

            lblStep1.Text = "Step1: Creazione dell'ash di una stringa e comparazione";
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTesto1.Text) || string.IsNullOrWhiteSpace(txtTesto1.Text))
            {
                MessageBox.Show("inserire dei valori");
                return;
            }

            // hash delle stringhe
            var hash1 = txtTesto1.Text.ToHash();
            var hash2 = txtTesto2.Text.ToHash();

            //comparazione
            bool result = hash1.Compare(hash2);

            StringBuilder stringBuilder = new StringBuilder()
                .Append($"testo1: {txtTesto1.Text} => {Convert.ToBase64String(hash1)}")
                .AppendLine()
                .AppendLine()
                .Append($"testo2: {txtTesto2.Text} => {Convert.ToBase64String(hash2)}")
                .AppendLine()
                .AppendLine()
                .Append($"I valori sono {result.ToYesNo()}");

            txtResult.Text = stringBuilder.ToString();
        }
    }
}
