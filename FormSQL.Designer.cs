
namespace PharmacyDataBase
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonItems = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployee = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_Select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Orders = new System.Windows.Forms.RadioButton();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            this.groupBoxSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(853, 495);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(845, 469);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(839, 363);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonOrders);
            this.groupBoxSelect.Controls.Add(this.radioButtonItems);
            this.groupBoxSelect.Controls.Add(this.radioButtonEmployee);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(839, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonOrders
            // 
            this.radioButtonOrders.AutoSize = true;
            this.radioButtonOrders.Location = new System.Drawing.Point(166, 19);
            this.radioButtonOrders.Name = "radioButtonOrders";
            this.radioButtonOrders.Size = new System.Drawing.Size(64, 17);
            this.radioButtonOrders.TabIndex = 2;
            this.radioButtonOrders.TabStop = true;
            this.radioButtonOrders.Text = "Заказы";
            this.radioButtonOrders.UseVisualStyleBackColor = true;
            this.radioButtonOrders.CheckedChanged += new System.EventHandler(this.radioButtonOrders_CheckedChanged);
            // 
            // radioButtonItems
            // 
            this.radioButtonItems.AutoSize = true;
            this.radioButtonItems.Location = new System.Drawing.Point(96, 19);
            this.radioButtonItems.Name = "radioButtonItems";
            this.radioButtonItems.Size = new System.Drawing.Size(64, 17);
            this.radioButtonItems.TabIndex = 1;
            this.radioButtonItems.TabStop = true;
            this.radioButtonItems.Text = "Товары";
            this.radioButtonItems.UseVisualStyleBackColor = true;
            this.radioButtonItems.CheckedChanged += new System.EventHandler(this.radioButtonItems_CheckedChanged);
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Location = new System.Drawing.Point(6, 19);
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Size = new System.Drawing.Size(84, 17);
            this.radioButtonEmployee.TabIndex = 0;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Сотрудники";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            this.radioButtonEmployee.CheckedChanged += new System.EventHandler(this.radioButtonEmployee_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(845, 469);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 155);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(839, 311);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_Select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxEmployee);
            this.groupBoxFSelect.Controls.Add(this.labelEmployee);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(839, 152);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Прибыль сотрудников";
            // 
            // buttonF_Select
            // 
            this.buttonF_Select.Location = new System.Drawing.Point(295, 123);
            this.buttonF_Select.Name = "buttonF_Select";
            this.buttonF_Select.Size = new System.Drawing.Size(215, 23);
            this.buttonF_Select.TabIndex = 6;
            this.buttonF_Select.Text = "Прибыль сотрудника";
            this.buttonF_Select.UseVisualStyleBackColor = true;
            this.buttonF_Select.Click += new System.EventHandler(this.buttonF_Select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 80);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(247, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Выбрать сортировку по убыванию прибыли";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(295, 60);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(215, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 60);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(150, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать прибыль более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Orders);
            this.groupBoxDet.Location = new System.Drawing.Point(542, 28);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(291, 87);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли сотрудников";
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(15, 42);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDet_NO.TabIndex = 2;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Нет детализации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Orders
            // 
            this.radioButtonDet_Orders.AutoSize = true;
            this.radioButtonDet_Orders.Location = new System.Drawing.Point(15, 19);
            this.radioButtonDet_Orders.Name = "radioButtonDet_Orders";
            this.radioButtonDet_Orders.Size = new System.Drawing.Size(202, 17);
            this.radioButtonDet_Orders.TabIndex = 0;
            this.radioButtonDet_Orders.TabStop = true;
            this.radioButtonDet_Orders.Text = "Прибыль сотрудника по продажам";
            this.radioButtonDet_Orders.UseVisualStyleBackColor = true;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Location = new System.Drawing.Point(295, 34);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(215, 20);
            this.textBoxEmployee.TabIndex = 1;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(6, 37);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(117, 13);
            this.labelEmployee.TabIndex = 0;
            this.labelEmployee.Text = "Фамилия сотрудника";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(845, 469);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(839, 152);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(114, 37);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(322, 37);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(131, 72);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(88, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер продажи";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(225, 72);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(285, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(295, 123);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(215, 23);
            this.buttonSubquery.TabIndex = 7;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 155);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(839, 311);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 495);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonEmployee;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.RadioButton radioButtonOrders;
        private System.Windows.Forms.RadioButton radioButtonItems;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_Orders;
        private System.Windows.Forms.TextBox textBoxEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.Button buttonF_Select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
    }
}