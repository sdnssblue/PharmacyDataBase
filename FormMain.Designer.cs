namespace PharmacyDataBase
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DrugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonItem = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonEmployee = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonOrder = new System.Windows.Forms.ToolStripButton();
            this.MenuStripMain.SuspendLayout();
            this.ContextMenuStripMain.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ManualToolStripMenuItem,
            this.документыToolStripMenuItem});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStripMain.Size = new System.Drawing.Size(686, 24);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::PharmacyDataBase.Properties.Resources.exit_icon;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Image = global::PharmacyDataBase.Properties.Resources.info_icon;
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.InfoToolStripMenuItem.Text = "О программе";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // ManualToolStripMenuItem
            // 
            this.ManualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemsToolStripMenuItem,
            this.EmployeeToolStripMenuItem});
            this.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem";
            this.ManualToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ManualToolStripMenuItem.Text = "Справочники";
            // 
            // ItemsToolStripMenuItem
            // 
            this.ItemsToolStripMenuItem.Image = global::PharmacyDataBase.Properties.Resources.drug_icon;
            this.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem";
            this.ItemsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.ItemsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ItemsToolStripMenuItem.Text = "Товары";
            this.ItemsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // EmployeeToolStripMenuItem
            // 
            this.EmployeeToolStripMenuItem.Image = global::PharmacyDataBase.Properties.Resources.employee_icon;
            this.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            this.EmployeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.EmployeeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.EmployeeToolStripMenuItem.Text = "Сотрудники";
            this.EmployeeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuEmployee_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdersToolStripMenuItem,
            this.ReportsToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Image = global::PharmacyDataBase.Properties.Resources.order;
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrdersToolStripMenuItem.Text = "Заказы";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuOrder_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.Image = global::PharmacyDataBase.Properties.Resources.report;
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReportsToolStripMenuItem.Text = "Отчеты";
            this.ReportsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuReport_Click);
            // 
            // ContextMenuStripMain
            // 
            this.ContextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1,
            this.ManualToolStripMenuItem1});
            this.ContextMenuStripMain.Name = "ContextMenuStripMain";
            this.ContextMenuStripMain.Size = new System.Drawing.Size(150, 48);
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem1,
            this.InfoToolStripMenuItem1});
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.FileToolStripMenuItem1.Text = "Файл";
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Image = global::PharmacyDataBase.Properties.Resources.exit_icon;
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.ExitToolStripMenuItem1.Text = "Выход";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem1
            // 
            this.InfoToolStripMenuItem1.Image = global::PharmacyDataBase.Properties.Resources.info_icon;
            this.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1";
            this.InfoToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.InfoToolStripMenuItem1.Text = "О программе";
            this.InfoToolStripMenuItem1.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // ManualToolStripMenuItem1
            // 
            this.ManualToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrugToolStripMenuItem1,
            this.EmployeeToolStripMenuItem1});
            this.ManualToolStripMenuItem1.Name = "ManualToolStripMenuItem1";
            this.ManualToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.ManualToolStripMenuItem1.Text = "Справочники";
            // 
            // DrugToolStripMenuItem1
            // 
            this.DrugToolStripMenuItem1.Image = global::PharmacyDataBase.Properties.Resources.drug_icon;
            this.DrugToolStripMenuItem1.Name = "DrugToolStripMenuItem1";
            this.DrugToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.DrugToolStripMenuItem1.Text = "Лекарства";
            // 
            // EmployeeToolStripMenuItem1
            // 
            this.EmployeeToolStripMenuItem1.Image = global::PharmacyDataBase.Properties.Resources.employee_icon;
            this.EmployeeToolStripMenuItem1.Name = "EmployeeToolStripMenuItem1";
            this.EmployeeToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.EmployeeToolStripMenuItem1.Text = "Сотрудники";
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonExit,
            this.ToolStripButtonInfo,
            this.ToolStripButtonItem,
            this.ToolStripButtonEmployee,
            this.ToolStripButtonReport,
            this.ToolStripButtonOrder});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 24);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(686, 25);
            this.ToolStripMain.TabIndex = 1;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ToolStripButtonExit
            // 
            this.ToolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonExit.Image = global::PharmacyDataBase.Properties.Resources.exit_icon;
            this.ToolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonExit.Name = "ToolStripButtonExit";
            this.ToolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonExit.Text = "toolStripButton1";
            this.ToolStripButtonExit.ToolTipText = "Выход";
            this.ToolStripButtonExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ToolStripButtonInfo
            // 
            this.ToolStripButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonInfo.Image = global::PharmacyDataBase.Properties.Resources.info_icon;
            this.ToolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonInfo.Name = "ToolStripButtonInfo";
            this.ToolStripButtonInfo.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonInfo.Text = "О программе";
            this.ToolStripButtonInfo.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // ToolStripButtonItem
            // 
            this.ToolStripButtonItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonItem.Image = global::PharmacyDataBase.Properties.Resources.drug_icon;
            this.ToolStripButtonItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonItem.Name = "ToolStripButtonItem";
            this.ToolStripButtonItem.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonItem.Text = "Товары";
            this.ToolStripButtonItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripButtonEmployee
            // 
            this.ToolStripButtonEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonEmployee.Image = global::PharmacyDataBase.Properties.Resources.employee_icon;
            this.ToolStripButtonEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonEmployee.Name = "ToolStripButtonEmployee";
            this.ToolStripButtonEmployee.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonEmployee.Text = "Сотрудники";
            this.ToolStripButtonEmployee.Click += new System.EventHandler(this.ToolStripMenuEmployee_Click);
            // 
            // ToolStripButtonReport
            // 
            this.ToolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonReport.Image = global::PharmacyDataBase.Properties.Resources.report;
            this.ToolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonReport.Name = "ToolStripButtonReport";
            this.ToolStripButtonReport.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonReport.Text = "Отчеты";
            this.ToolStripButtonReport.Click += new System.EventHandler(this.ToolStripMenuReport_Click);
            // 
            // ToolStripButtonOrder
            // 
            this.ToolStripButtonOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonOrder.Image = global::PharmacyDataBase.Properties.Resources.order;
            this.ToolStripButtonOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonOrder.Name = "ToolStripButtonOrder";
            this.ToolStripButtonOrder.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonOrder.Text = "Заказы";
            this.ToolStripButtonOrder.Click += new System.EventHandler(this.ToolStripMenuOrder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.ContextMenuStrip = this.ContextMenuStripMain;
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.MenuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::PharmacyDataBase.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::PharmacyDataBase.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "FormMain";
            this.Text = "Pharmacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ContextMenuStripMain.ResumeLayout(false);
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ManualToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DrugToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton ToolStripButtonExit;
        private System.Windows.Forms.ToolStripButton ToolStripButtonInfo;
        private System.Windows.Forms.ToolStripButton ToolStripButtonItem;
        private System.Windows.Forms.ToolStripButton ToolStripButtonEmployee;
        private System.Windows.Forms.ToolStripButton ToolStripButtonReport;
        private System.Windows.Forms.ToolStripButton ToolStripButtonOrder;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
    }
}