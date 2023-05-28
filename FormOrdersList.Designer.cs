
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
            System.Windows.Forms.Label сотрудникLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdersList));
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
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButtonAddItem = new System.Windows.Forms.ToolStripButton();
            this.товары_в_заказеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabelCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxPostionItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMoveNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMoveLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.заказTableAdapter = new PharmacyDataBase.PharmacyDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new PharmacyDataBase.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.товары_в_заказеTableAdapter = new PharmacyDataBase.PharmacyDataSetTableAdapters.Товары_в_заказеTableAdapter();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new PharmacyDataBase.PharmacyDataSetTableAdapters.СотрудникTableAdapter();
            this.сотрудникLabel1 = new System.Windows.Forms.Label();
            this.товары_в_заказеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_ЗаказаLabel = new System.Windows.Forms.Label();
            дата_и_времяLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            сотрудникLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingNavigator)).BeginInit();
            this.OrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.groupBoxItemsInOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
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
            // сотрудникLabel
            // 
            сотрудникLabel.AutoSize = true;
            сотрудникLabel.Location = new System.Drawing.Point(15, 141);
            сотрудникLabel.Name = "сотрудникLabel";
            сотрудникLabel.Size = new System.Drawing.Size(63, 13);
            сотрудникLabel.TabIndex = 13;
            сотрудникLabel.Text = "Сотрудник:";
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
            this.OrderBindingNavigator.Size = new System.Drawing.Size(801, 25);
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
            this.iD_ЗаказаTextBox.Size = new System.Drawing.Size(468, 20);
            this.iD_ЗаказаTextBox.TabIndex = 2;
            // 
            // дата_и_времяDateTimePicker
            // 
            this.дата_и_времяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказBindingSource, "Дата и время", true));
            this.дата_и_времяDateTimePicker.Location = new System.Drawing.Point(101, 55);
            this.дата_и_времяDateTimePicker.Name = "дата_и_времяDateTimePicker";
            this.дата_и_времяDateTimePicker.Size = new System.Drawing.Size(468, 20);
            this.дата_и_времяDateTimePicker.TabIndex = 4;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(101, 81);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(468, 20);
            this.ценаTextBox.TabIndex = 6;
            // 
            // iD_СотрудникаTextBox
            // 
            this.iD_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "ID Сотрудника", true));
            this.iD_СотрудникаTextBox.Location = new System.Drawing.Point(101, 107);
            this.iD_СотрудникаTextBox.Name = "iD_СотрудникаTextBox";
            this.iD_СотрудникаTextBox.Size = new System.Drawing.Size(468, 20);
            this.iD_СотрудникаTextBox.TabIndex = 8;
            // 
            // groupBoxItemsInOrder
            // 
            this.groupBoxItemsInOrder.Controls.Add(this.товары_в_заказеDataGridView);
            this.groupBoxItemsInOrder.Controls.Add(this.bindingNavigator1);
            this.groupBoxItemsInOrder.Location = new System.Drawing.Point(15, 206);
            this.groupBoxItemsInOrder.Name = "groupBoxItemsInOrder";
            this.groupBoxItemsInOrder.Size = new System.Drawing.Size(554, 281);
            this.groupBoxItemsInOrder.TabIndex = 9;
            this.groupBoxItemsInOrder.TabStop = false;
            this.groupBoxItemsInOrder.Text = "Товары в заказе";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButtonAddItem;
            this.bindingNavigator1.BindingSource = this.товары_в_заказеBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabelCountItem;
            this.bindingNavigator1.CountItemFormat = "из {0}";
            this.bindingNavigator1.DeleteItem = this.toolStripButtonDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMoveFirstItem,
            this.toolStripButtonMovePreviousItem,
            this.toolStripSeparator,
            this.toolStripTextBoxPostionItem,
            this.toolStripLabelCountItem,
            this.toolStripSeparator1,
            this.toolStripButtonMoveNext,
            this.toolStripButtonMoveLast,
            this.toolStripSeparator2,
            this.toolStripButtonAddItem,
            this.toolStripButtonDeleteItem,
            this.toolStripButtonSaveItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButtonMoveNext;
            this.bindingNavigator1.MoveLastItem = this.toolStripButtonMoveLast;
            this.bindingNavigator1.MoveNextItem = this.toolStripButtonMoveNext;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButtonMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBoxPostionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(548, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButtonAddItem
            // 
            this.toolStripButtonAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddItem.Image")));
            this.toolStripButtonAddItem.Name = "toolStripButtonAddItem";
            this.toolStripButtonAddItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonAddItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddItem.Text = "Добавить запись";
            // 
            // товары_в_заказеBindingSource
            // 
            this.товары_в_заказеBindingSource.DataMember = "FK_Товары в заказе_Заказ";
            this.товары_в_заказеBindingSource.DataSource = this.заказBindingSource;
            // 
            // toolStripLabelCountItem
            // 
            this.toolStripLabelCountItem.Name = "toolStripLabelCountItem";
            this.toolStripLabelCountItem.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabelCountItem.Text = "из {0}";
            this.toolStripLabelCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripButtonDeleteItem
            // 
            this.toolStripButtonDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteItem.Image")));
            this.toolStripButtonDeleteItem.Name = "toolStripButtonDeleteItem";
            this.toolStripButtonDeleteItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteItem.Text = "Удалить запись";
            // 
            // toolStripButtonMoveFirstItem
            // 
            this.toolStripButtonMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveFirstItem.Image")));
            this.toolStripButtonMoveFirstItem.Name = "toolStripButtonMoveFirstItem";
            this.toolStripButtonMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveFirstItem.Text = "Первая запись, в начало";
            // 
            // toolStripButtonMovePreviousItem
            // 
            this.toolStripButtonMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMovePreviousItem.Image")));
            this.toolStripButtonMovePreviousItem.Name = "toolStripButtonMovePreviousItem";
            this.toolStripButtonMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMovePreviousItem.Text = "Предыдущая запись, назад";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxPostionItem
            // 
            this.toolStripTextBoxPostionItem.AccessibleName = "Position";
            this.toolStripTextBoxPostionItem.AutoSize = false;
            this.toolStripTextBoxPostionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxPostionItem.Name = "toolStripTextBoxPostionItem";
            this.toolStripTextBoxPostionItem.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBoxPostionItem.Text = "0";
            this.toolStripTextBoxPostionItem.ToolTipText = "Current position";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMoveNext
            // 
            this.toolStripButtonMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveNext.Image")));
            this.toolStripButtonMoveNext.Name = "toolStripButtonMoveNext";
            this.toolStripButtonMoveNext.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonMoveNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveNext.Text = "Следующая запись, вперед";
            // 
            // toolStripButtonMoveLast
            // 
            this.toolStripButtonMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMoveLast.Image")));
            this.toolStripButtonMoveLast.Name = "toolStripButtonMoveLast";
            this.toolStripButtonMoveLast.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonMoveLast.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMoveLast.Text = "Последняя запись, в конец";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveItem
            // 
            this.toolStripButtonSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveItem.Image")));
            this.toolStripButtonSaveItem.Name = "toolStripButtonSaveItem";
            this.toolStripButtonSaveItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveItem.Text = "Сохранить";
            this.toolStripButtonSaveItem.Click += new System.EventHandler(this.toolStripButtonSaveItem_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Image = global::PharmacyDataBase.Properties.Resources.employee_icon;
            this.buttonEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployee.Location = new System.Drawing.Point(586, 81);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(154, 46);
            this.buttonEmployee.TabIndex = 10;
            this.buttonEmployee.Text = "Сотрудник";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
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
            this.tableAdapterManager.Товары_в_заказеTableAdapter = this.товары_в_заказеTableAdapter;
            // 
            // товары_в_заказеTableAdapter
            // 
            this.товары_в_заказеTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникLabel1
            // 
            this.сотрудникLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Сотрудник", true));
            this.сотрудникLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.сотрудникLabel1.Location = new System.Drawing.Point(98, 141);
            this.сотрудникLabel1.Name = "сотрудникLabel1";
            this.сотрудникLabel1.Size = new System.Drawing.Size(100, 23);
            this.сотрудникLabel1.TabIndex = 14;
            this.сотрудникLabel1.Text = "label1";
            // 
            // товары_в_заказеDataGridView
            // 
            this.товары_в_заказеDataGridView.AutoGenerateColumns = false;
            this.товары_в_заказеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товары_в_заказеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.товары_в_заказеDataGridView.DataSource = this.товары_в_заказеBindingSource;
            this.товары_в_заказеDataGridView.Location = new System.Drawing.Point(3, 44);
            this.товары_в_заказеDataGridView.Name = "товары_в_заказеDataGridView";
            this.товары_в_заказеDataGridView.Size = new System.Drawing.Size(545, 231);
            this.товары_в_заказеDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Заказа";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Заказа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Товара";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Товара";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn6.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn7.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // FormOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 505);
            this.Controls.Add(сотрудникLabel);
            this.Controls.Add(this.сотрудникLabel1);
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
            this.Text = "Список заказов";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingNavigator)).EndInit();
            this.OrderBindingNavigator.ResumeLayout(false);
            this.OrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.groupBoxItemsInOrder.ResumeLayout(false);
            this.groupBoxItemsInOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товары_в_заказеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCountItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveFirstItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPostionItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveNext;
        private System.Windows.Forms.ToolStripButton toolStripButtonMoveLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveItem;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private PharmacyDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.Label сотрудникLabel1;
        private System.Windows.Forms.DataGridView товары_в_заказеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}