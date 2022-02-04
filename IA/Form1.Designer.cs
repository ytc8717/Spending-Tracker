namespace IA
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.numericUpDownExpense = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIncome = new System.Windows.Forms.NumericUpDown();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxTExpense = new System.Windows.Forms.TextBox();
            this.textBoxTIncome = new System.Windows.Forms.TextBox();
            this.labelTotalExpense = new System.Windows.Forms.Label();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.buttonDeleteTransaction = new System.Windows.Forms.Button();
            this.radioButtonExpense = new System.Windows.Forms.RadioButton();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.comboBoxExpense = new System.Windows.Forms.ComboBox();
            this.labelExpense = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxIncome = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newExpenseCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIncomeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeExpenseCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeIncomeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 170);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 29);
            this.dateTimePicker1.TabIndex = 57;
            this.dateTimePicker1.Value = new System.DateTime(2017, 3, 27, 9, 59, 49, 0);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(501, 57);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(426, 29);
            this.textBoxSearch.TabIndex = 56;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(433, 60);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(60, 18);
            this.labelSearch.TabIndex = 55;
            this.labelSearch.Text = "Search:";
            // 
            // numericUpDownExpense
            // 
            this.numericUpDownExpense.Enabled = false;
            this.numericUpDownExpense.Location = new System.Drawing.Point(308, 134);
            this.numericUpDownExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownExpense.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.numericUpDownExpense.Name = "numericUpDownExpense";
            this.numericUpDownExpense.Size = new System.Drawing.Size(104, 29);
            this.numericUpDownExpense.TabIndex = 54;
            // 
            // numericUpDownIncome
            // 
            this.numericUpDownIncome.Enabled = false;
            this.numericUpDownIncome.Location = new System.Drawing.Point(308, 96);
            this.numericUpDownIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownIncome.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.numericUpDownIncome.Name = "numericUpDownIncome";
            this.numericUpDownIncome.Size = new System.Drawing.Size(104, 29);
            this.numericUpDownIncome.TabIndex = 53;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(130, 377);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(166, 29);
            this.textBoxBalance.TabIndex = 52;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(14, 382);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(69, 18);
            this.labelBalance.TabIndex = 51;
            this.labelBalance.Text = "Balance:";
            // 
            // textBoxTExpense
            // 
            this.textBoxTExpense.Location = new System.Drawing.Point(130, 343);
            this.textBoxTExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTExpense.Name = "textBoxTExpense";
            this.textBoxTExpense.ReadOnly = true;
            this.textBoxTExpense.Size = new System.Drawing.Size(166, 29);
            this.textBoxTExpense.TabIndex = 50;
            // 
            // textBoxTIncome
            // 
            this.textBoxTIncome.Location = new System.Drawing.Point(130, 312);
            this.textBoxTIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTIncome.Name = "textBoxTIncome";
            this.textBoxTIncome.ReadOnly = true;
            this.textBoxTIncome.Size = new System.Drawing.Size(166, 29);
            this.textBoxTIncome.TabIndex = 49;
            // 
            // labelTotalExpense
            // 
            this.labelTotalExpense.AutoSize = true;
            this.labelTotalExpense.Location = new System.Drawing.Point(14, 348);
            this.labelTotalExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalExpense.Name = "labelTotalExpense";
            this.labelTotalExpense.Size = new System.Drawing.Size(111, 18);
            this.labelTotalExpense.TabIndex = 48;
            this.labelTotalExpense.Text = "Total Expense:";
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Location = new System.Drawing.Point(14, 314);
            this.labelTotalIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(105, 18);
            this.labelTotalIncome.TabIndex = 47;
            this.labelTotalIncome.Text = "Total Income:";
            // 
            // buttonDeleteTransaction
            // 
            this.buttonDeleteTransaction.Location = new System.Drawing.Point(106, 263);
            this.buttonDeleteTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            this.buttonDeleteTransaction.Size = new System.Drawing.Size(208, 32);
            this.buttonDeleteTransaction.TabIndex = 46;
            this.buttonDeleteTransaction.Text = "Delete Transaction";
            this.buttonDeleteTransaction.UseVisualStyleBackColor = true;
            this.buttonDeleteTransaction.Click += new System.EventHandler(this.buttonDeleteTransaction_Click);
            // 
            // radioButtonExpense
            // 
            this.radioButtonExpense.AutoSize = true;
            this.radioButtonExpense.Location = new System.Drawing.Point(243, 58);
            this.radioButtonExpense.Name = "radioButtonExpense";
            this.radioButtonExpense.Size = new System.Drawing.Size(90, 22);
            this.radioButtonExpense.TabIndex = 45;
            this.radioButtonExpense.TabStop = true;
            this.radioButtonExpense.Text = "Expense";
            this.radioButtonExpense.UseVisualStyleBackColor = true;
            this.radioButtonExpense.CheckedChanged += new System.EventHandler(this.radioButtonExpense_CheckedChanged);
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(122, 58);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(84, 22);
            this.radioButtonIncome.TabIndex = 44;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            this.radioButtonIncome.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(550, 348);
            this.dataGridView1.TabIndex = 43;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(106, 220);
            this.buttonAddTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(208, 32);
            this.buttonAddTransaction.TabIndex = 42;
            this.buttonAddTransaction.Text = "Add Transaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // comboBoxExpense
            // 
            this.comboBoxExpense.Enabled = false;
            this.comboBoxExpense.FormattingEnabled = true;
            this.comboBoxExpense.Location = new System.Drawing.Point(124, 132);
            this.comboBoxExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxExpense.Name = "comboBoxExpense";
            this.comboBoxExpense.Size = new System.Drawing.Size(170, 26);
            this.comboBoxExpense.Sorted = true;
            this.comboBoxExpense.TabIndex = 41;
            // 
            // labelExpense
            // 
            this.labelExpense.AutoSize = true;
            this.labelExpense.Enabled = false;
            this.labelExpense.Location = new System.Drawing.Point(14, 137);
            this.labelExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(70, 18);
            this.labelExpense.TabIndex = 40;
            this.labelExpense.Text = "Expense:";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Enabled = false;
            this.labelIncome.Location = new System.Drawing.Point(14, 98);
            this.labelIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(64, 18);
            this.labelIncome.TabIndex = 39;
            this.labelIncome.Text = "Income:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(14, 179);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 18);
            this.labelDate.TabIndex = 38;
            this.labelDate.Text = "Date:";
            // 
            // comboBoxIncome
            // 
            this.comboBoxIncome.Enabled = false;
            this.comboBoxIncome.FormattingEnabled = true;
            this.comboBoxIncome.Location = new System.Drawing.Point(124, 96);
            this.comboBoxIncome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxIncome.Name = "comboBoxIncome";
            this.comboBoxIncome.Size = new System.Drawing.Size(170, 26);
            this.comboBoxIncome.Sorted = true;
            this.comboBoxIncome.TabIndex = 37;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 35);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newExpenseCategoryToolStripMenuItem,
            this.newIncomeCategoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.removeExpenseCategoryToolStripMenuItem,
            this.removeIncomeCategoryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // newExpenseCategoryToolStripMenuItem
            // 
            this.newExpenseCategoryToolStripMenuItem.Name = "newExpenseCategoryToolStripMenuItem";
            this.newExpenseCategoryToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.newExpenseCategoryToolStripMenuItem.Text = "New Ex&pense Category";
            this.newExpenseCategoryToolStripMenuItem.Click += new System.EventHandler(this.newExpenseCategoryToolStripMenuItem_Click);
            // 
            // newIncomeCategoryToolStripMenuItem
            // 
            this.newIncomeCategoryToolStripMenuItem.Name = "newIncomeCategoryToolStripMenuItem";
            this.newIncomeCategoryToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.newIncomeCategoryToolStripMenuItem.Text = "New &Income Category";
            this.newIncomeCategoryToolStripMenuItem.Click += new System.EventHandler(this.newIncomeCategoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(304, 6);
            // 
            // removeExpenseCategoryToolStripMenuItem
            // 
            this.removeExpenseCategoryToolStripMenuItem.Name = "removeExpenseCategoryToolStripMenuItem";
            this.removeExpenseCategoryToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.removeExpenseCategoryToolStripMenuItem.Text = "Remove Expense Category";
            this.removeExpenseCategoryToolStripMenuItem.Click += new System.EventHandler(this.removeExpenseCategoryToolStripMenuItem_Click);
            // 
            // removeIncomeCategoryToolStripMenuItem
            // 
            this.removeIncomeCategoryToolStripMenuItem.Name = "removeIncomeCategoryToolStripMenuItem";
            this.removeIncomeCategoryToolStripMenuItem.Size = new System.Drawing.Size(307, 30);
            this.removeIncomeCategoryToolStripMenuItem.Text = "Remove Income Category";
            this.removeIncomeCategoryToolStripMenuItem.Click += new System.EventHandler(this.removeIncomeCategoryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 458);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.numericUpDownExpense);
            this.Controls.Add(this.numericUpDownIncome);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxTExpense);
            this.Controls.Add(this.textBoxTIncome);
            this.Controls.Add(this.labelTotalExpense);
            this.Controls.Add(this.labelTotalIncome);
            this.Controls.Add(this.buttonDeleteTransaction);
            this.Controls.Add(this.radioButtonExpense);
            this.Controls.Add(this.radioButtonIncome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.comboBoxExpense);
            this.Controls.Add(this.labelExpense);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxIncome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spending Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownExpense;
        private System.Windows.Forms.NumericUpDown numericUpDownIncome;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxTExpense;
        private System.Windows.Forms.TextBox textBoxTIncome;
        private System.Windows.Forms.Label labelTotalExpense;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Button buttonDeleteTransaction;
        private System.Windows.Forms.RadioButton radioButtonExpense;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.ComboBox comboBoxExpense;
        private System.Windows.Forms.Label labelExpense;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxIncome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newExpenseCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIncomeCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem removeExpenseCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeIncomeCategoryToolStripMenuItem;
    }
}

