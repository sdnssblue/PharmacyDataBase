using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDataBase
{
    public partial class FormReportList : Form
    {
        public FormReportList()
        {
            InitializeComponent();
        }

        private void отчетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.отчетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'pharmacyDataSet.Отчет' table.You can move, or remove it, as needed.
            this.отчетTableAdapter.Fill(this.pharmacyDataSet.Отчет);
        }

        private static FormReportList f;

        public static FormReportList fr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormReportList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
