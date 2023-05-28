
namespace PharmacyDataBase
{
    partial class FormReportList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportList));
            System.Windows.Forms.Label iD_ОтчетаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label выручкаLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label iD_СотрудникаLabel;
            this.отчетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new PharmacyDataBase.PharmacyDataSet();
            this.отчетTableAdapter = new PharmacyDataBase.PharmacyDataSetTableAdapters.ОтчетTableAdapter();
            this.tableAdapterManager = new PharmacyDataBase.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.отчетBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.отчетBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.отчетBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iD_ОтчетаTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.выручкаTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.iD_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            iD_ОтчетаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            выручкаLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingNavigator)).BeginInit();
            this.отчетBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // отчетBindingSource
            // 
            this.отчетBindingSource.DataMember = "Отчет";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отчетTableAdapter
            // 
            this.отчетTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PharmacyDataBase.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ОтчетTableAdapter = this.отчетTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Товары_в_заказеTableAdapter = null;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить запись";
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
            // отчетBindingNavigatorSaveItem
            // 
            this.отчетBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отчетBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отчетBindingNavigatorSaveItem.Image")));
            this.отчетBindingNavigatorSaveItem.Name = "отчетBindingNavigatorSaveItem";
            this.отчетBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.отчетBindingNavigatorSaveItem.Text = "Сохранить";
            this.отчетBindingNavigatorSaveItem.Click += new System.EventHandler(this.отчетBindingNavigatorSaveItem_Click);
            // 
            // отчетBindingNavigator
            // 
            this.отчетBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отчетBindingNavigator.BindingSource = this.отчетBindingSource;
            this.отчетBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отчетBindingNavigator.CountItemFormat = "из {0}";
            this.отчетBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отчетBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отчетBindingNavigatorSaveItem});
            this.отчетBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отчетBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отчетBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отчетBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отчетBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отчетBindingNavigator.Name = "отчетBindingNavigator";
            this.отчетBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отчетBindingNavigator.Size = new System.Drawing.Size(314, 25);
            this.отчетBindingNavigator.TabIndex = 0;
            this.отчетBindingNavigator.Text = "bindingNavigator1";
            // 
            // отчетBindingSource1
            // 
            this.отчетBindingSource1.DataMember = "Отчет";
            this.отчетBindingSource1.DataSource = this.pharmacyDataSet;
            // 
            // iD_ОтчетаLabel
            // 
            iD_ОтчетаLabel.AutoSize = true;
            iD_ОтчетаLabel.Location = new System.Drawing.Point(12, 36);
            iD_ОтчетаLabel.Name = "iD_ОтчетаLabel";
            iD_ОтчетаLabel.Size = new System.Drawing.Size(59, 13);
            iD_ОтчетаLabel.TabIndex = 1;
            iD_ОтчетаLabel.Text = "ID Отчета:";
            // 
            // iD_ОтчетаTextBox
            // 
            this.iD_ОтчетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отчетBindingSource1, "ID_Отчета", true));
            this.iD_ОтчетаTextBox.Location = new System.Drawing.Point(101, 33);
            this.iD_ОтчетаTextBox.Name = "iD_ОтчетаTextBox";
            this.iD_ОтчетаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_ОтчетаTextBox.TabIndex = 2;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(12, 63);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.отчетBindingSource1, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(101, 59);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // выручкаLabel
            // 
            выручкаLabel.AutoSize = true;
            выручкаLabel.Location = new System.Drawing.Point(12, 88);
            выручкаLabel.Name = "выручкаLabel";
            выручкаLabel.Size = new System.Drawing.Size(53, 13);
            выручкаLabel.TabIndex = 5;
            выручкаLabel.Text = "Выручка:";
            // 
            // выручкаTextBox
            // 
            this.выручкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отчетBindingSource1, "Выручка", true));
            this.выручкаTextBox.Location = new System.Drawing.Point(101, 85);
            this.выручкаTextBox.Name = "выручкаTextBox";
            this.выручкаTextBox.Size = new System.Drawing.Size(200, 20);
            this.выручкаTextBox.TabIndex = 6;
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(12, 114);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 7;
            количествоLabel.Text = "Количество:";
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отчетBindingSource1, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(101, 111);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(200, 20);
            this.количествоTextBox.TabIndex = 8;
            // 
            // iD_СотрудникаLabel
            // 
            iD_СотрудникаLabel.AutoSize = true;
            iD_СотрудникаLabel.Location = new System.Drawing.Point(12, 140);
            iD_СотрудникаLabel.Name = "iD_СотрудникаLabel";
            iD_СотрудникаLabel.Size = new System.Drawing.Size(83, 13);
            iD_СотрудникаLabel.TabIndex = 9;
            iD_СотрудникаLabel.Text = "ID Сотрудника:";
            // 
            // iD_СотрудникаTextBox
            // 
            this.iD_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отчетBindingSource1, "ID_Сотрудника", true));
            this.iD_СотрудникаTextBox.Location = new System.Drawing.Point(101, 137);
            this.iD_СотрудникаTextBox.Name = "iD_СотрудникаTextBox";
            this.iD_СотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_СотрудникаTextBox.TabIndex = 10;
            // 
            // FormReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 175);
            this.Controls.Add(iD_ОтчетаLabel);
            this.Controls.Add(this.iD_ОтчетаTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(выручкаLabel);
            this.Controls.Add(this.выручкаTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(iD_СотрудникаLabel);
            this.Controls.Add(this.iD_СотрудникаTextBox);
            this.Controls.Add(this.отчетBindingNavigator);
            this.Name = "FormReportList";
            this.ShowIcon = false;
            this.Text = "Список отчетов";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingNavigator)).EndInit();
            this.отчетBindingNavigator.ResumeLayout(false);
            this.отчетBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отчетBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource отчетBindingSource;
        private PharmacyDataSet pharmacyDataSet;
        private PharmacyDataSetTableAdapters.ОтчетTableAdapter отчетTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton отчетBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator отчетBindingNavigator;
        private System.Windows.Forms.BindingSource отчетBindingSource1;
        private System.Windows.Forms.TextBox iD_ОтчетаTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox выручкаTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox iD_СотрудникаTextBox;
    }
}