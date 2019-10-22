namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewBookCopy = new System.Windows.Forms.Button();
            this.btnByAuthor = new System.Windows.Forms.Button();
            this.lbAvailCopies = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bookCopyCondition = new System.Windows.Forms.TextBox();
            this.btnShowLoanHistory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(273, 85);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.ScrollAlwaysVisible = true;
            this.lbBooks.Size = new System.Drawing.Size(436, 342);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books List";
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(12, 85);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.ScrollAlwaysVisible = true;
            this.lbAuthors.Size = new System.Drawing.Size(237, 342);
            this.lbAuthors.TabIndex = 3;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Authors";
            // 
            // addNewBookCopy
            // 
            this.addNewBookCopy.Enabled = false;
            this.addNewBookCopy.Location = new System.Drawing.Point(730, 433);
            this.addNewBookCopy.Name = "addNewBookCopy";
            this.addNewBookCopy.Size = new System.Drawing.Size(91, 30);
            this.addNewBookCopy.TabIndex = 12;
            this.addNewBookCopy.Text = "New Copy";
            this.addNewBookCopy.UseVisualStyleBackColor = true;
            this.addNewBookCopy.Click += new System.EventHandler(this.addNewBookCopy_Click);
            // 
            // btnByAuthor
            // 
            this.btnByAuthor.Enabled = false;
            this.btnByAuthor.Location = new System.Drawing.Point(592, 433);
            this.btnByAuthor.Name = "btnByAuthor";
            this.btnByAuthor.Size = new System.Drawing.Size(117, 30);
            this.btnByAuthor.TabIndex = 14;
            this.btnByAuthor.Text = "Search by Author";
            this.btnByAuthor.UseVisualStyleBackColor = true;
            this.btnByAuthor.Click += new System.EventHandler(this.listByAuthor_Click);
            // 
            // lbAvailCopies
            // 
            this.lbAvailCopies.FormattingEnabled = true;
            this.lbAvailCopies.HorizontalScrollbar = true;
            this.lbAvailCopies.Location = new System.Drawing.Point(730, 85);
            this.lbAvailCopies.Name = "lbAvailCopies";
            this.lbAvailCopies.ScrollAlwaysVisible = true;
            this.lbAvailCopies.Size = new System.Drawing.Size(364, 342);
            this.lbAvailCopies.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(727, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "All Available Copies";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Manage Members";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add New Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(496, 433);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "(Select author first)";
            // 
            // bookCopyCondition
            // 
            this.bookCopyCondition.Enabled = false;
            this.bookCopyCondition.Location = new System.Drawing.Point(827, 439);
            this.bookCopyCondition.Name = "bookCopyCondition";
            this.bookCopyCondition.Size = new System.Drawing.Size(132, 20);
            this.bookCopyCondition.TabIndex = 11;
            // 
            // btnShowLoanHistory
            // 
            this.btnShowLoanHistory.Location = new System.Drawing.Point(981, 433);
            this.btnShowLoanHistory.Name = "btnShowLoanHistory";
            this.btnShowLoanHistory.Size = new System.Drawing.Size(113, 30);
            this.btnShowLoanHistory.TabIndex = 26;
            this.btnShowLoanHistory.Text = "Loan History";
            this.btnShowLoanHistory.UseVisualStyleBackColor = true;
            this.btnShowLoanHistory.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(957, 604);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 56);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1106, 675);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowLoanHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAvailCopies);
            this.Controls.Add(this.btnByAuthor);
            this.Controls.Add(this.addNewBookCopy);
            this.Controls.Add(this.bookCopyCondition);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBooks);
            this.Name = "LibraryForm";
            this.Text = "Library Manager";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewBookCopy;
        private System.Windows.Forms.Button btnByAuthor;
        private System.Windows.Forms.ListBox lbAvailCopies;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookCopyCondition;
        private System.Windows.Forms.Button btnShowLoanHistory;
        private System.Windows.Forms.Button btnClose;
    }
}

