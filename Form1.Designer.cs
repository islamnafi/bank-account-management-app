namespace bank_account_management_app
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            ownerText = new TextBox();
            amountNumerical = new NumericUpDown();
            bankAccountGrid = new DataGridView();
            dipositBtn = new Button();
            withdrawBtn = new Button();
            createAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)amountNumerical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(30, 54);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(30, 364);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            label2.Click += label2_Click;
            // 
            // ownerText
            // 
            ownerText.Location = new Point(130, 61);
            ownerText.Name = "ownerText";
            ownerText.Size = new Size(188, 23);
            ownerText.TabIndex = 2;
            // 
            // amountNumerical
            // 
            amountNumerical.Location = new Point(130, 371);
            amountNumerical.Name = "amountNumerical";
            amountNumerical.Size = new Size(188, 23);
            amountNumerical.TabIndex = 3;
            // 
            // bankAccountGrid
            // 
            bankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bankAccountGrid.Location = new Point(354, 61);
            bankAccountGrid.Name = "bankAccountGrid";
            bankAccountGrid.Size = new Size(409, 246);
            bankAccountGrid.TabIndex = 4;
            // 
            // dipositBtn
            // 
            dipositBtn.Location = new Point(411, 343);
            dipositBtn.Name = "dipositBtn";
            dipositBtn.Size = new Size(129, 42);
            dipositBtn.TabIndex = 5;
            dipositBtn.Text = "Deposit";
            dipositBtn.UseVisualStyleBackColor = true;
            dipositBtn.Click += button1_Click;
            // 
            // withdrawBtn
            // 
            withdrawBtn.Location = new Point(591, 343);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(129, 42);
            withdrawBtn.TabIndex = 6;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = true;
            // 
            // createAccountBtn
            // 
            createAccountBtn.Location = new Point(130, 111);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(188, 38);
            createAccountBtn.TabIndex = 7;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createAccountBtn);
            Controls.Add(withdrawBtn);
            Controls.Add(dipositBtn);
            Controls.Add(bankAccountGrid);
            Controls.Add(amountNumerical);
            Controls.Add(ownerText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)amountNumerical).EndInit();
            ((System.ComponentModel.ISupportInitialize)bankAccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ownerText;
        private NumericUpDown amountNumerical;
        private DataGridView bankAccountGrid;
        private Button dipositBtn;
        private Button withdrawBtn;
        private Button createAccountBtn;
    }
}
