namespace Library
{
    partial class LoanHistory
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
            this.lbLoanHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterBy = new System.Windows.Forms.Button();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLoanHistory
            // 
            this.lbLoanHistory.FormattingEnabled = true;
            this.lbLoanHistory.HorizontalScrollbar = true;
            this.lbLoanHistory.Location = new System.Drawing.Point(12, 74);
            this.lbLoanHistory.Name = "lbLoanHistory";
            this.lbLoanHistory.Size = new System.Drawing.Size(661, 355);
            this.lbLoanHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By:";
            // 
            // btnFilterBy
            // 
            this.btnFilterBy.Location = new System.Drawing.Point(589, 27);
            this.btnFilterBy.Name = "btnFilterBy";
            this.btnFilterBy.Size = new System.Drawing.Size(84, 28);
            this.btnFilterBy.TabIndex = 3;
            this.btnFilterBy.Text = "Search";
            this.btnFilterBy.UseVisualStyleBackColor = true;
            this.btnFilterBy.Click += new System.EventHandler(this.btnFilterBy_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "LoanID",
            "Condition",
            "Book Title",
            "MemberID",
            "Member Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(74, 32);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(202, 21);
            this.cbFilterBy.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(559, 449);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnNewLoan_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(282, 32);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(301, 20);
            this.txtFilterBy.TabIndex = 9;
            // 
            // LoanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 500);
            this.Controls.Add(this.lbLoanHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.btnBack);
            this.Name = "LoanHistory";
            this.Text = "LoanHistory";
            this.Load += new System.EventHandler(this.LoanHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLoanHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtFilterBy;
    }
}