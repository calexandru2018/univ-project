namespace Library
{
    partial class MemberList
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
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterBy = new System.Windows.Forms.Button();
            this.btnShowLoanHistory = new System.Windows.Forms.Button();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnNewLoan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLoanHistory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(12, 79);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(528, 355);
            this.lbMembers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By:";
            // 
            // btnFilterBy
            // 
            this.btnFilterBy.Location = new System.Drawing.Point(336, 32);
            this.btnFilterBy.Name = "btnFilterBy";
            this.btnFilterBy.Size = new System.Drawing.Size(84, 28);
            this.btnFilterBy.TabIndex = 3;
            this.btnFilterBy.Text = "Search";
            this.btnFilterBy.UseVisualStyleBackColor = true;
            this.btnFilterBy.Click += new System.EventHandler(this.btnFilterBy_Click);
            // 
            // btnShowLoanHistory
            // 
            this.btnShowLoanHistory.Location = new System.Drawing.Point(426, 32);
            this.btnShowLoanHistory.Name = "btnShowLoanHistory";
            this.btnShowLoanHistory.Size = new System.Drawing.Size(114, 28);
            this.btnShowLoanHistory.TabIndex = 4;
            this.btnShowLoanHistory.Text = "Show Loan History";
            this.btnShowLoanHistory.UseVisualStyleBackColor = true;
            this.btnShowLoanHistory.Click += new System.EventHandler(this.btnShowLoanHistory_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Social Number"});
            this.cbFilterBy.Location = new System.Drawing.Point(74, 37);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(96, 21);
            this.cbFilterBy.TabIndex = 5;
            // 
            // btnNewLoan
            // 
            this.btnNewLoan.Location = new System.Drawing.Point(564, 454);
            this.btnNewLoan.Name = "btnNewLoan";
            this.btnNewLoan.Size = new System.Drawing.Size(114, 28);
            this.btnNewLoan.TabIndex = 6;
            this.btnNewLoan.Text = "Create New Loan";
            this.btnNewLoan.UseVisualStyleBackColor = true;
            this.btnNewLoan.Click += new System.EventHandler(this.btnNewLoan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(970, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lbLoanHistory
            // 
            this.lbLoanHistory.FormattingEnabled = true;
            this.lbLoanHistory.Location = new System.Drawing.Point(564, 79);
            this.lbLoanHistory.Name = "lbLoanHistory";
            this.lbLoanHistory.Size = new System.Drawing.Size(490, 355);
            this.lbLoanHistory.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Loan History";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create new Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLoanHistory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewLoan);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnShowLoanHistory);
            this.Controls.Add(this.btnFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMembers);
            this.Name = "MemberList";
            this.Text = "MemberList";
            this.Load += new System.EventHandler(this.MemberList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterBy;
        private System.Windows.Forms.Button btnShowLoanHistory;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnNewLoan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbLoanHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}