using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyDataBase.Properties;

namespace PharmacyDataBase
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
           "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
           DialogResult.Yes;
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Медянкин В.К. 571-2 , 2023", "О программе",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemsList.fd.ShowForm();
        }

        private void ToolStripMenuEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeList.fe.ShowForm();
        }

        private void ToolStripMenuReport_Click(object sender, EventArgs e)
        {
            FormReportList.fr.ShowForm();
        }

        private void ToolStripMenuOrder_Click(object sender, EventArgs e)
        {
            FormOrdersList.fo.ShowForm();
        }

        private void ToolStripMenuSQL_Click(object sender, EventArgs e)
        {
            FormSQL.fs.ShowForm();
        }
    }
}