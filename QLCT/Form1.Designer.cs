namespace QLCT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmdAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAddExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAddIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAddType = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEditExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdEditIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdd,
            this.cmdEdit,
            this.cmdHistory});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmdAdd
            // 
            this.cmdAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAddExpense,
            this.cmdAddIncome,
            this.cmdAddType});
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(50, 20);
            this.cmdAdd.Text = "Add...";
            // 
            // cmdAddExpense
            // 
            this.cmdAddExpense.Name = "cmdAddExpense";
            this.cmdAddExpense.Size = new System.Drawing.Size(117, 22);
            this.cmdAddExpense.Text = "Expense";
            this.cmdAddExpense.Click += new System.EventHandler(this.cmdAddExpense_Click);
            // 
            // cmdAddIncome
            // 
            this.cmdAddIncome.Name = "cmdAddIncome";
            this.cmdAddIncome.Size = new System.Drawing.Size(117, 22);
            this.cmdAddIncome.Text = "Income";
            this.cmdAddIncome.Click += new System.EventHandler(this.cmdAddIncome_Click);
            // 
            // cmdAddType
            // 
            this.cmdAddType.Name = "cmdAddType";
            this.cmdAddType.Size = new System.Drawing.Size(117, 22);
            this.cmdAddType.Text = "Type";
            this.cmdAddType.Click += new System.EventHandler(this.cmdAddType_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEditExpense,
            this.cmdEditIncome});
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(48, 20);
            this.cmdEdit.Text = "Edit...";
            // 
            // cmdEditExpense
            // 
            this.cmdEditExpense.Name = "cmdEditExpense";
            this.cmdEditExpense.Size = new System.Drawing.Size(117, 22);
            this.cmdEditExpense.Text = "Expense";
            // 
            // cmdEditIncome
            // 
            this.cmdEditIncome.Name = "cmdEditIncome";
            this.cmdEditIncome.Size = new System.Drawing.Size(117, 22);
            this.cmdEditIncome.Text = "Income";
            // 
            // cmdHistory
            // 
            this.cmdHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expensesToolStripMenuItem,
            this.incomesToolStripMenuItem});
            this.cmdHistory.Name = "cmdHistory";
            this.cmdHistory.Size = new System.Drawing.Size(53, 20);
            this.cmdHistory.Text = "View...";
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expensesToolStripMenuItem.Text = "Expenses";
            this.expensesToolStripMenuItem.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // incomesToolStripMenuItem
            // 
            this.incomesToolStripMenuItem.Name = "incomesToolStripMenuItem";
            this.incomesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incomesToolStripMenuItem.Text = "Incomes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 359);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmdAdd;
        private System.Windows.Forms.ToolStripMenuItem cmdAddExpense;
        private System.Windows.Forms.ToolStripMenuItem cmdAddIncome;
        private System.Windows.Forms.ToolStripMenuItem cmdAddType;
        private System.Windows.Forms.ToolStripMenuItem cmdEdit;
        private System.Windows.Forms.ToolStripMenuItem cmdEditExpense;
        private System.Windows.Forms.ToolStripMenuItem cmdEditIncome;
        private System.Windows.Forms.ToolStripMenuItem cmdHistory;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomesToolStripMenuItem;
    }
}

