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
    public partial class FormOrdersList : Form
    {
        public FormOrdersList()
        {
            InitializeComponent();
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Товары_в_заказе' table. You can move, or remove it, as needed.
            this.товары_в_заказеTableAdapter.Fill(this.pharmacyDataSet.Товары_в_заказе);
            // TODO: This line of code loads data into the 'pharmacyDataSet.Заказ' table. You can move, or remove it, as needed.
            this.заказTableAdapter.Fill(this.pharmacyDataSet.Заказ);
        }

        private static FormOrdersList f;

        public static FormOrdersList fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormOrdersList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void товары_в_заказеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товары_в_заказеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            pharmacyDataSet.Заказ.Columns["Дата и время"].DefaultValue = DateTime.Now;
        }


        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)заказBindingSource.Current)["ID Сотрудника"].ToString() !="")
            {
                id = (int)(((DataRowView)заказBindingSource.Current)["ID Сотрудника"]);
            }

            id = FormEmployeeList.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)заказBindingSource.Current)["ID Сотрудника"] = id;
                заказBindingSource.EndEdit();
            }
        }
    }
}
