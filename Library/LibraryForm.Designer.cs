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
            this.BTNChangeBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBookCopies = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.Loans = new System.Windows.Forms.Label();
            this.addBookISBN = new System.Windows.Forms.TextBox();
            this.addBookTitle = new System.Windows.Forms.TextBox();
            this.addBookDesc = new System.Windows.Forms.TextBox();
            this.addAuthorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addMemberSocialNum = new System.Windows.Forms.TextBox();
            this.addMemberName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addNewBook = new System.Windows.Forms.Button();
            this.addNewMember = new System.Windows.Forms.Button();
            this.newAuthor = new System.Windows.Forms.CheckBox();
            this.bookCopyCondition = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addNewBookCopy = new System.Windows.Forms.Button();
            this.loanBook = new System.Windows.Forms.Button();
            this.listByAuthor = new System.Windows.Forms.Button();
            this.lbShowFilteredContent = new System.Windows.Forms.ListBox();
            this.lbAvailCopies = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.removeMember = new System.Windows.Forms.ListBox();
            this.showUserHistory = new System.Windows.Forms.Button();
            this.returnLoad = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(237, 11);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(218, 95);
            this.lbBooks.TabIndex = 0;
            // 
            // BTNChangeBook
            // 
            this.BTNChangeBook.Location = new System.Drawing.Point(-16, 309);
            this.BTNChangeBook.Margin = new System.Windows.Forms.Padding(2);
            this.BTNChangeBook.Name = "BTNChangeBook";
            this.BTNChangeBook.Size = new System.Drawing.Size(101, 39);
            this.BTNChangeBook.TabIndex = 1;
            this.BTNChangeBook.Text = "TEST: Change the book title";
            this.BTNChangeBook.UseVisualStyleBackColor = true;
            this.BTNChangeBook.Click += new System.EventHandler(this.BTNChangeBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Books";
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(237, 126);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(218, 95);
            this.lbAuthors.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Authors";
            // 
            // lbBookCopies
            // 
            this.lbBookCopies.FormattingEnabled = true;
            this.lbBookCopies.HorizontalScrollbar = true;
            this.lbBookCopies.Location = new System.Drawing.Point(503, 30);
            this.lbBookCopies.Name = "lbBookCopies";
            this.lbBookCopies.Size = new System.Drawing.Size(251, 238);
            this.lbBookCopies.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "All book copies";
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(12, 394);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(312, 212);
            this.lbMembers.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Members";
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.HorizontalScrollbar = true;
            this.lbLoans.Location = new System.Drawing.Point(330, 394);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(660, 212);
            this.lbLoans.TabIndex = 6;
            // 
            // Loans
            // 
            this.Loans.AutoSize = true;
            this.Loans.Location = new System.Drawing.Point(566, 366);
            this.Loans.Name = "Loans";
            this.Loans.Size = new System.Drawing.Size(36, 13);
            this.Loans.TabIndex = 2;
            this.Loans.Text = "Loans";
            // 
            // addBookISBN
            // 
            this.addBookISBN.Location = new System.Drawing.Point(72, 27);
            this.addBookISBN.Name = "addBookISBN";
            this.addBookISBN.Size = new System.Drawing.Size(100, 20);
            this.addBookISBN.TabIndex = 7;
            // 
            // addBookTitle
            // 
            this.addBookTitle.Location = new System.Drawing.Point(72, 53);
            this.addBookTitle.Name = "addBookTitle";
            this.addBookTitle.Size = new System.Drawing.Size(100, 20);
            this.addBookTitle.TabIndex = 7;
            // 
            // addBookDesc
            // 
            this.addBookDesc.Location = new System.Drawing.Point(72, 79);
            this.addBookDesc.Name = "addBookDesc";
            this.addBookDesc.Size = new System.Drawing.Size(100, 20);
            this.addBookDesc.TabIndex = 7;
            // 
            // addAuthorName
            // 
            this.addAuthorName.Enabled = false;
            this.addAuthorName.Location = new System.Drawing.Point(47, 143);
            this.addAuthorName.Name = "addAuthorName";
            this.addAuthorName.Size = new System.Drawing.Size(100, 20);
            this.addAuthorName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Author data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Add new book";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add new member";
            // 
            // addMemberSocialNum
            // 
            this.addMemberSocialNum.Location = new System.Drawing.Point(100, 635);
            this.addMemberSocialNum.Name = "addMemberSocialNum";
            this.addMemberSocialNum.Size = new System.Drawing.Size(100, 20);
            this.addMemberSocialNum.TabIndex = 7;
            // 
            // addMemberName
            // 
            this.addMemberName.Location = new System.Drawing.Point(100, 661);
            this.addMemberName.Name = "addMemberName";
            this.addMemberName.Size = new System.Drawing.Size(100, 20);
            this.addMemberName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Add new copy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 638);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Social Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 664);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Name";
            // 
            // addNewBook
            // 
            this.addNewBook.Location = new System.Drawing.Point(42, 169);
            this.addNewBook.Name = "addNewBook";
            this.addNewBook.Size = new System.Drawing.Size(113, 30);
            this.addNewBook.TabIndex = 8;
            this.addNewBook.Text = "Add new book";
            this.addNewBook.UseVisualStyleBackColor = true;
            this.addNewBook.Click += new System.EventHandler(this.addNewBook_Click_1);
            // 
            // addNewMember
            // 
            this.addNewMember.Location = new System.Drawing.Point(88, 690);
            this.addNewMember.Name = "addNewMember";
            this.addNewMember.Size = new System.Drawing.Size(107, 23);
            this.addNewMember.TabIndex = 9;
            this.addNewMember.Text = "Add new member";
            this.addNewMember.UseVisualStyleBackColor = true;
            this.addNewMember.Click += new System.EventHandler(this.addNewMember_Click);
            // 
            // newAuthor
            // 
            this.newAuthor.AutoSize = true;
            this.newAuthor.Location = new System.Drawing.Point(153, 145);
            this.newAuthor.Name = "newAuthor";
            this.newAuthor.Size = new System.Drawing.Size(77, 17);
            this.newAuthor.TabIndex = 10;
            this.newAuthor.Text = "Add new ?";
            this.newAuthor.UseVisualStyleBackColor = true;
            this.newAuthor.CheckedChanged += new System.EventHandler(this.newAuthor_CheckedChanged);
            // 
            // bookCopyCondition
            // 
            this.bookCopyCondition.Location = new System.Drawing.Point(584, 297);
            this.bookCopyCondition.Name = "bookCopyCondition";
            this.bookCopyCondition.Size = new System.Drawing.Size(100, 20);
            this.bookCopyCondition.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(500, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Condition(1-10)";
            // 
            // addNewBookCopy
            // 
            this.addNewBookCopy.Location = new System.Drawing.Point(584, 323);
            this.addNewBookCopy.Name = "addNewBookCopy";
            this.addNewBookCopy.Size = new System.Drawing.Size(91, 23);
            this.addNewBookCopy.TabIndex = 12;
            this.addNewBookCopy.Text = "Add new copy";
            this.addNewBookCopy.UseVisualStyleBackColor = true;
            this.addNewBookCopy.Click += new System.EventHandler(this.addNewBookCopy_Click);
            // 
            // loanBook
            // 
            this.loanBook.Location = new System.Drawing.Point(426, 619);
            this.loanBook.Name = "loanBook";
            this.loanBook.Size = new System.Drawing.Size(118, 23);
            this.loanBook.TabIndex = 13;
            this.loanBook.Text = "Loan Book";
            this.loanBook.UseVisualStyleBackColor = true;
            this.loanBook.Click += new System.EventHandler(this.loanBook_Click);
            // 
            // listByAuthor
            // 
            this.listByAuthor.Location = new System.Drawing.Point(82, 243);
            this.listByAuthor.Name = "listByAuthor";
            this.listByAuthor.Size = new System.Drawing.Size(117, 23);
            this.listByAuthor.TabIndex = 14;
            this.listByAuthor.Text = "List By Author";
            this.listByAuthor.UseVisualStyleBackColor = true;
            this.listByAuthor.Click += new System.EventHandler(this.listByAuthor_Click);
            // 
            // lbShowFilteredContent
            // 
            this.lbShowFilteredContent.FormattingEnabled = true;
            this.lbShowFilteredContent.Location = new System.Drawing.Point(237, 243);
            this.lbShowFilteredContent.Name = "lbShowFilteredContent";
            this.lbShowFilteredContent.Size = new System.Drawing.Size(218, 95);
            this.lbShowFilteredContent.TabIndex = 15;
            // 
            // lbAvailCopies
            // 
            this.lbAvailCopies.FormattingEnabled = true;
            this.lbAvailCopies.HorizontalScrollbar = true;
            this.lbAvailCopies.Location = new System.Drawing.Point(769, 30);
            this.lbAvailCopies.Name = "lbAvailCopies";
            this.lbAvailCopies.Size = new System.Drawing.Size(221, 238);
            this.lbAvailCopies.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(820, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Available Copies";
            // 
            // removeMember
            // 
            this.removeMember.FormattingEnabled = true;
            this.removeMember.HorizontalScrollbar = true;
            this.removeMember.Location = new System.Drawing.Point(607, 664);
            this.removeMember.Name = "removeMember";
            this.removeMember.Size = new System.Drawing.Size(383, 160);
            this.removeMember.TabIndex = 17;
            // 
            // showUserHistory
            // 
            this.showUserHistory.Location = new System.Drawing.Point(469, 690);
            this.showUserHistory.Name = "showUserHistory";
            this.showUserHistory.Size = new System.Drawing.Size(118, 23);
            this.showUserHistory.TabIndex = 18;
            this.showUserHistory.Text = "Show user history";
            this.showUserHistory.UseVisualStyleBackColor = true;
            this.showUserHistory.Click += new System.EventHandler(this.showUserHistory_Click);
            // 
            // returnLoad
            // 
            this.returnLoad.Location = new System.Drawing.Point(866, 619);
            this.returnLoad.Name = "returnLoad";
            this.returnLoad.Size = new System.Drawing.Size(124, 23);
            this.returnLoad.TabIndex = 19;
            this.returnLoad.Text = "Return Loaned Book";
            this.returnLoad.UseVisualStyleBackColor = true;
            this.returnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(660, 622);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 20;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(88, 761);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveMember.TabIndex = 21;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 844);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.returnLoad);
            this.Controls.Add(this.showUserHistory);
            this.Controls.Add(this.removeMember);
            this.Controls.Add(this.lbAvailCopies);
            this.Controls.Add(this.lbShowFilteredContent);
            this.Controls.Add(this.listByAuthor);
            this.Controls.Add(this.loanBook);
            this.Controls.Add(this.addNewBookCopy);
            this.Controls.Add(this.bookCopyCondition);
            this.Controls.Add(this.newAuthor);
            this.Controls.Add(this.addNewMember);
            this.Controls.Add(this.addNewBook);
            this.Controls.Add(this.addAuthorName);
            this.Controls.Add(this.addBookDesc);
            this.Controls.Add(this.addMemberName);
            this.Controls.Add(this.addBookTitle);
            this.Controls.Add(this.addMemberSocialNum);
            this.Controls.Add(this.addBookISBN);
            this.Controls.Add(this.lbLoans);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.lbBookCopies);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.Loans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNChangeBook);
            this.Controls.Add(this.lbBooks);
            this.Name = "LibraryForm";
            this.Text = "Add new copy";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button BTNChangeBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBookCopies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbLoans;
        private System.Windows.Forms.Label Loans;
        private System.Windows.Forms.TextBox addBookISBN;
        private System.Windows.Forms.TextBox addBookTitle;
        private System.Windows.Forms.TextBox addBookDesc;
        private System.Windows.Forms.TextBox addAuthorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addMemberSocialNum;
        private System.Windows.Forms.TextBox addMemberName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button addNewBook;
        private System.Windows.Forms.Button addNewMember;
        private System.Windows.Forms.CheckBox newAuthor;
        private System.Windows.Forms.TextBox bookCopyCondition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button addNewBookCopy;
        private System.Windows.Forms.Button loanBook;
        private System.Windows.Forms.Button listByAuthor;
        private System.Windows.Forms.ListBox lbShowFilteredContent;
        private System.Windows.Forms.ListBox lbAvailCopies;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox removeMember;
        private System.Windows.Forms.Button showUserHistory;
        private System.Windows.Forms.Button returnLoad;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button button1;
    }
}

