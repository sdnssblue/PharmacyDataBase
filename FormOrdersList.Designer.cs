
namespace PharmacyDataBase
{
    partial class FormOrdersList
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
            System.Windows.Forms.Label iD_ЗаказаLabel;
            System.Windows.Forms.Label дата_и_времяLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label iD_СотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdersList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new PharmacyDataBase.PharmacyDataSet();
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
            this.заказBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ЗаказаTextBox = new System.Windows.Forms.TextBox();
            this.дата_и_времяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.iD_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxItemsInOrder = new System.Windows.Forms.GroupBox();
            this.товары_в_заказеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new PharmacyDataBase.PharmacyDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new PharmacyDataBase.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.товары_в_заказеTableAdapter = new PharmacyDataBase.PharmacyDataSetTableAdapters.Товары_в_заказеTableAdapter();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.товары_в_заказеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.товары_в_заказеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товары_в_заказеDataGridView = new System.Windows.Forms.DataGridView();
            iD_ЗаказаLabel = new System.Windows.Forms.Label();
            дата_и_времяLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingNavigator)).BeginInit();
            this.OrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.groupBoxItemsInOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеBindingNavigator)).BeginInit();
            this.товары_в_заказеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ЗаказаLabel
            // 
            iD_ЗаказаLabel.AutoSize = true;
            iD_ЗаказаLabel.Location = new System.Drawing.Point(12, 29);
            iD_ЗаказаLabel.Name = "iD_ЗаказаLabel";
            iD_ЗаказаLabel.Size = new System.Drawing.Size(61, 13);
            iD_ЗаказаLabel.TabIndex = 1;
            iD_ЗаказаLabel.Text = "ID Заказа:";
            // 
            // дата_и_времяLabel
            // 
            дата_и_времяLabel.AutoSize = true;
            дата_и_времяLabel.Location = new System.Drawing.Point(12, 55);
            дата_и_времяLabel.Name = "дата_и_времяLabel";
            дата_и_времяLabel.Size = new System.Drawing.Size(80, 13);
            дата_и_времяLabel.TabIndex = 3;
            дата_и_времяLabel.Text = "Дата и время:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(12, 81);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 5;
            ценаLabel.Text = "Цена:";
            // 
            // iD_СотрудникаLabel
            // 
            iD_СотрудникаLabel.AutoSize = true;
            iD_СотрудникаLabel.Location = new System.Drawing.Point(12, 107);
            iD_СотрудникаLabel.Name = "iD_СотрудникаLabel";
            iD_СотрудникаLabel.Size = new System.Drawing.Size(83, 13);
            iD_СотрудникаLabel.TabIndex = 7;
            iD_СотрудникаLabel.Text = "ID Сотрудника:";
            // 
            // OrderBindingNavigator
            // 
            this.OrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.OrderBindingNavigator.BindingSource = this.заказBindingSource;
            this.OrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.OrderBindingNavigator.CountItemFormat = "из {0}";
            this.OrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.OrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказBindingNavigatorSaveItem});
            this.OrderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.OrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveNextItem;
            this.OrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.OrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.OrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.OrderBindingNavigator.Name = "OrderBindingNavigator";
            this.OrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.OrderBindingNavigator.Size = new System.Drawing.Size(752, 25);
            this.OrderBindingNavigator.TabIndex = 0;
            this.OrderBindingNavigator.Text = "bindingNavigator1";
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
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // заказBindingNavigatorSaveItem
            // 
            this.заказBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказBindingNavigatorSaveItem.Image")));
            this.заказBindingNavigatorSaveItem.Name = "заказBindingNavigatorSaveItem";
            this.заказBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказBindingNavigatorSaveItem.Text = "Сохранить";
            this.заказBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказBindingNavigatorSaveItem_Click);
            // 
            // iD_ЗаказаTextBox
            // 
            this.iD_ЗаказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "ID Заказа", true));
            this.iD_ЗаказаTextBox.Location = new System.Drawing.Point(101, 29);
            this.iD_ЗаказаTextBox.Name = "iD_ЗаказаTextBox";
            this.iD_ЗаказаTextBox.Size = new System.Drawing.Size(363, 20);
            this.iD_ЗаказаTextBox.TabIndex = 2;
            // 
            // дата_и_времяDateTimePicker
            // 
            this.дата_и_времяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказBindingSource, "Дата и время", true));
            this.дата_и_времяDateTimePicker.Location = new System.Drawing.Point(101, 55);
            this.дата_и_времяDateTimePicker.Name = "дата_и_времяDateTimePicker";
            this.дата_и_времяDateTimePicker.Size = new System.Drawing.Size(363, 20);
            this.дата_и_времяDateTimePicker.TabIndex = 4;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(101, 81);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(363, 20);
            this.ценаTextBox.TabIndex = 6;
            // 
            // iD_СотрудникаTextBox
            // 
            this.iD_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "ID Сотрудника", true));
            this.iD_СотрудникаTextBox.Location = new System.Drawing.Point(101, 107);
            this.iD_СотрудникаTextBox.Name = "iD_СотрудникаTextBox";
            this.iD_СотрудникаTextBox.Size = new System.Drawing.Size(363, 20);
            this.iD_СотрудникаTextBox.TabIndex = 8;
            // 
            // groupBoxItemsInOrder
            // 
            this.groupBoxItemsInOrder.Controls.Add(this.товары_в_заказеDataGridView);
            this.groupBoxItemsInOrder.Controls.Add(this.товары_в_заказеBindingNavigator);
            this.groupBoxItemsInOrder.Location = new System.Drawing.Point(15, 144);
            this.groupBoxItemsInOrder.Name = "groupBoxItemsInOrder";
            this.groupBoxItemsInOrder.Size = new System.Drawing.Size(449, 300);
            this.groupBoxItemsInOrder.TabIndex = 9;
            this.groupBoxItemsInOrder.TabStop = false;
            this.groupBoxItemsInOrder.Text = "Товары в заказе";
            // 
            // товары_в_заказеBindingSource
            // 
            this.товары_в_заказеBindingSource.DataMember = "FK_Товары в заказе_Заказ";
            this.товары_в_заказеBindingSource.DataSource = this.заказBindingSource;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PharmacyDataBase.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.ОтчетTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            this.tableAdapterManager.Товары_в_заказеTableAdapter = null;
            // 
            // товары_в_заказеTableAdapter
            // 
            this.товары_в_заказеTableAdapter.ClearBeforeFill = true;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Image = global::PharmacyDataBase.Properties.Resources.employee_icon;
            this.buttonEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployee.Location = new System.Drawing.Point(481, 81);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(154, 46);
            this.buttonEmployee.TabIndex = 10;
            this.buttonEmployee.Text = "Сотрудник";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Первая запись, в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Предыдущая запись, назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Следующая запись, вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Последняя запись, в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить запись";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить запись";
            // 
            // товары_в_заказеBindingNavigatorSaveItem
            // 
            this.товары_в_заказеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товары_в_заказеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товары_в_заказеBindingNavigatorSaveItem.Image")));
            this.товары_в_заказеBindingNavigatorSaveItem.Name = "товары_в_заказеBindingNavigatorSaveItem";
            this.товары_в_заказеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.товары_в_заказеBindingNavigatorSaveItem.Text = "Сохранить";
            this.товары_в_заказеBindingNavigatorSaveItem.Click += new System.EventHandler(this.товары_в_заказеBindingNavigatorSaveItem_Click);
            // 
            // товары_в_заказеBindingNavigator
            // 
            this.товары_в_заказеBindingNavigator.AddNewItem = this.toolStripButton1;
            this.товары_в_заказеBindingNavigator.BindingSource = this.товары_в_заказеBindingSource;
            this.товары_в_заказеBindingNavigator.CountItem = this.toolStripLabel1;
            this.товары_в_заказеBindingNavigator.CountItemFormat = "из {0}";
            this.товары_в_заказеBindingNavigator.DeleteItem = this.toolStripButton2;
            this.товары_в_заказеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.товары_в_заказеBindingNavigatorSaveItem});
            this.товары_в_заказеBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.товары_в_заказеBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.товары_в_заказеBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.товары_в_заказеBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.товары_в_заказеBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.товары_в_заказеBindingNavigator.Name = "товары_в_заказеBindingNavigator";
            this.товары_в_заказеBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.товары_в_заказеBindingNavigator.Size = new System.Drawing.Size(443, 25);
            this.товары_в_заказеBindingNavigator.TabIndex = 1;
            this.товары_в_заказеBindingNavigator.Text = "bindingNavigator1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Цена товара";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена товара";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID Товара";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Товара";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID Заказа";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // товары_в_заказеDataGridView
            // 
            this.товары_в_заказеDataGridView.AutoGenerateColumns = false;
            this.товары_в_заказеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товары_в_заказеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.товары_в_заказеDataGridView.DataSource = this.товары_в_заказеBindingSource;
            this.товары_в_заказеDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.товары_в_заказеDataGridView.Location = new System.Drawing.Point(3, 41);
            this.товары_в_заказеDataGridView.Name = "товары_в_заказеDataGridView";
            this.товары_в_заказеDataGridView.Size = new System.Drawing.Size(443, 256);
            this.товары_в_заказеDataGridView.TabIndex = 0;
            // 
            // FormOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.groupBoxItemsInOrder);
            this.Controls.Add(iD_ЗаказаLabel);
            this.Controls.Add(this.iD_ЗаказаTextBox);
            this.Controls.Add(дата_и_времяLabel);
            this.Controls.Add(this.дата_и_времяDateTimePicker);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(iD_СотрудникаLabel);
            this.Controls.Add(this.iD_СотрудникаTextBox);
            this.Controls.Add(this.OrderBindingNavigator);
            this.Name = "FormOrdersList";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingNavigator)).EndInit();
            this.OrderBindingNavigator.ResumeLayout(false);
            this.OrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.groupBoxItemsInOrder.ResumeLayout(false);
            this.groupBoxItemsInOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеBindingNavigator)).EndInit();
            this.товары_в_заказеBindingNavigator.ResumeLayout(false);
            this.товары_в_заказеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private PharmacyDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator OrderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ЗаказаTextBox;
        private System.Windows.Forms.DateTimePicker дата_и_времяDateTimePicker;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox iD_СотрудникаTextBox;
        private System.Windows.Forms.GroupBox groupBoxItemsInOrder;
        private System.Windows.Forms.BindingSource товары_в_заказеBindingSource;
        private PharmacyDataSetTableAdapters.Товары_в_заказеTableAdapter товары_в_заказеTableAdapter;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.DataGridView товары_в_заказеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingNavigator товары_в_заказеBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton товары_в_заказеBindingNavigatorSaveItem;
    }
}