using HashTest.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTest
{
    public partial class frmStep2 : Form
    {
        private readonly Data.DsDati.NomiDataTable _dt;
        public frmStep2()
        {
            InitializeComponent();
            _dt = new Data.DsDati.NomiDataTable();
            //MockData();
            FillData();

        }

        private void FillData()
        {
            Data.DsDatiTableAdapters.NomiTableAdapter ta = new Data.DsDatiTableAdapters.NomiTableAdapter();

            ta.Fill(_dt);

            if(_dt.Count > 0)
            {
                // aggiungo una colonna per lo stato del record
                _dt.Columns.Add("IsValid", typeof(bool));
                CheckIntegrity();

                grdDati.DataSource = _dt;
            }
        }

        private void CheckIntegrity()
        {
            
            foreach(Data.DsDati.NomiRow row in _dt.Rows)
            {
                var hash = $"{row.Nome}{row.Testo}".ToHash();
                row["IsValid"] = row.CheckSum == hash.ToMD5();
            }
        }

        private void MockData()
        {
            Data.DsDatiTableAdapters.NomiTableAdapter ta = new Data.DsDatiTableAdapters.NomiTableAdapter();
            
            
            for (int i = 0; i < 1000; i++)
            {
                string nome = $"Nome {i}";
                string testo = "a".Repeat(4000 - i);
                var hash = $"{nome}{testo}".ToHash();

                ta.Insert(nome, hash.ToMD5(), testo);
            }
        }
    }
}
