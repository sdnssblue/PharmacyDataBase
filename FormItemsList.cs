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
    public partial class FormItemsList : Form
    {
        public FormItemsList()
        {
            InitializeComponent();
        }

        private void товарBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void FormItemsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Товар' table. You can move, or remove it, as needed.
            this.товарTableAdapter.Fill(this.pharmacyDataSet.Товар);

        }

        string fileImage = "";

        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    фотоPictureBox.Image = new
                   Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        private static FormItemsList f;
        public static FormItemsList fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormItemsList();
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
