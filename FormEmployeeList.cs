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
    public partial class FormEmployeeList : Form
    {
        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void сотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet1.Сотрудник' table. You can move, or remove it, as needed.
            this.сотрудникTableAdapter.Fill(this.pharmacyDataSet.Сотрудник);
        }

        private static FormEmployeeList f;

        public static FormEmployeeList fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormEmployeeList();
                return f;
            }
        }

        private void сотрудникDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((сотрудникDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value == null) ||
                (сотрудникDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() == "")) e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if (сотрудникDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() == "Мужской") e.CellStyle.BackColor = Color.SkyBlue;
                else e.CellStyle.BackColor = Color.Pink;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = сотрудникBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                сотрудникBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                сотрудникBindingSource.Position = 0;
            }
        }

        string GetSelectedFieldName()
        {
            return сотрудникDataGridView.Columns[сотрудникDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        сотрудникBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                    }
                }
            }
            else { сотрудникBindingSource.Filter = ""; }
            if (сотрудникBindingSource.Count == 0)
            {
                MessageBox.Show("Таких сотрудников не существует.");
                сотрудникBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;

        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
            {
                return (int)((DataRowView)сотрудникBindingSource.Current)["ID Сотрудника"];
            }
            else { return -1; }
        }

        private void FormEmployeeList_Shown(object sender, EventArgs e)
        {
            сотрудникBindingSource.Position = сотрудникBindingSource.Find("ID Сотрудника", idCurrent);
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            сотрудникBindingSource.Position = 0;
            Show();
            Activate();
        }
    }
}
