
namespace PharmacyDataBase
{
    partial class FormItemsList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItemsList));
            System.Windows.Forms.Label фотоLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label iD_ТовараLabel;
            this.pharmacyDataSet = new PharmacyDataBase.PharmacyDataSet();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new PharmacyDataBase.PharmacyDataSetTableAdapters.ТоварTableAdapter();
            this.tableAdapterManager = new PharmacyDataBase.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.товарBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.товарBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.iD_ТовараTextBox = new System.Windows.Forms.TextBox();
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            фотоLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            iD_ТовараLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).BeginInit();
            this.товарBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PharmacyDataBase.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ОтчетTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = this.товарTableAdapter;
            this.tableAdapterManager.Товары_в_заказеTableAdapter = null;
            // 
            // товарBindingNavigator
            // 
            this.товарBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.товарBindingNavigator.BindingSource = this.товарBindingSource;
            this.товарBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.товарBindingNavigator.CountItemFormat = "из {0}";
            this.товарBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.товарBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.товарBindingNavigatorSaveItem});
            this.товарBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарBindingNavigator.Name = "товарBindingNavigator";
            this.товарBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарBindingNavigator.Size = new System.Drawing.Size(296, 25);
            this.товарBindingNavigator.TabIndex = 0;
            this.товарBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить запись";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить запись";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Первая запись, в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Предыдущая запись, назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Следующая запись, вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Последняя запись, в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // товарBindingNavigatorSaveItem
            // 
            this.товарBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарBindingNavigatorSaveItem.Image")));
            this.товарBindingNavigatorSaveItem.Name = "товарBindingNavigatorSaveItem";
            this.товарBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.товарBindingNavigatorSaveItem.Text = "Сохранить";
            this.товарBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарBindingNavigatorSaveItem_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(79, 126);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(200, 23);
            this.buttonOpenPhoto.TabIndex = 11;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(12, 126);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(38, 13);
            фотоLabel.TabIndex = 9;
            фотоLabel.Text = "Фото:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(79, 74);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(200, 20);
            this.ценаTextBox.TabIndex = 6;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(12, 77);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 5;
            ценаLabel.Text = "Цена:";
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(79, 48);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(200, 20);
            this.названиеTextBox.TabIndex = 4;
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(12, 51);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "Название:";
            // 
            // iD_ТовараTextBox
            // 
            this.iD_ТовараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "ID Товара", true));
            this.iD_ТовараTextBox.Location = new System.Drawing.Point(79, 22);
            this.iD_ТовараTextBox.Name = "iD_ТовараTextBox";
            this.iD_ТовараTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ТовараTextBox.TabIndex = 2;
            // 
            // iD_ТовараLabel
            // 
            iD_ТовараLabel.AutoSize = true;
            iD_ТовараLabel.Location = new System.Drawing.Point(12, 25);
            iD_ТовараLabel.Name = "iD_ТовараLabel";
            iD_ТовараLabel.Size = new System.Drawing.Size(61, 13);
            iD_ТовараLabel.TabIndex = 1;
            iD_ТовараLabel.Text = "ID Товара:";
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.товарBindingSource, "Фото", true));
            this.фотоPictureBox.Location = new System.Drawing.Point(12, 155);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(272, 137);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотоPictureBox.TabIndex = 10;
            this.фотоPictureBox.TabStop = false;
            // 
            // FormItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 304);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(iD_ТовараLabel);
            this.Controls.Add(this.iD_ТовараTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоPictureBox);
            this.Controls.Add(this.товарBindingNavigator);
            this.Name = "FormItemsList";
            this.ShowIcon = false;
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.FormItemsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).EndInit();
            this.товарBindingNavigator.ResumeLayout(false);
            this.товарBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private PharmacyDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator товарBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton товарBindingNavigatorSaveItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox iD_ТовараTextBox;
        private System.Windows.Forms.PictureBox фотоPictureBox;
    }
}