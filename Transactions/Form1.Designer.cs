namespace Transactions
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonDeleteTransaction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonDeleteTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сумму:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(20, 31);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(265, 22);
            this.textBoxAmount.TabIndex = 1;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(20, 166);
            this.buttonAddTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(267, 28);
            this.buttonAddTransaction.TabIndex = 2;
            this.buttonAddTransaction.Text = "Добавить транзакцию";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(20, 246);
            this.dataGridViewTransactions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(735, 246);
            this.dataGridViewTransactions.TabIndex = 3;
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.comboBoxTransactionType.Location = new System.Drawing.Point(20, 80);
            this.comboBoxTransactionType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(265, 24);
            this.comboBoxTransactionType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(20, 129);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 22);
            this.textBoxDescription.TabIndex = 6;
            // 
            // buttonDeleteTransaction
            // 
            this.buttonDeleteTransaction.Location = new System.Drawing.Point(20, 209);
            this.buttonDeleteTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            this.buttonDeleteTransaction.Size = new System.Drawing.Size(267, 28);
            this.buttonDeleteTransaction.TabIndex = 7;
            this.buttonDeleteTransaction.Text = "Удалить запись";
            this.buttonDeleteTransaction.UseVisualStyleBackColor = true;
            this.buttonDeleteTransaction.Click += new System.EventHandler(this.buttonDeleteTransaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 506);
            this.Controls.Add(this.buttonDeleteTransaction);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTransactionType);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Учет финансов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
