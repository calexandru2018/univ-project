namespace Library
{
    partial class CreateNewBook
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
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chckAddNewAuthor = new System.Windows.Forms.CheckBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNewBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbAuthor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Location = new System.Drawing.Point(10, 61);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(202, 20);
            this.txtBookISBN.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(12, 103);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(200, 20);
            this.txtBookTitle.TabIndex = 1;
            // 
            // txtBookDesc
            // 
            this.txtBookDesc.Location = new System.Drawing.Point(12, 144);
            this.txtBookDesc.Name = "txtBookDesc";
            this.txtBookDesc.Size = new System.Drawing.Size(202, 20);
            this.txtBookDesc.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Description";
            // 
            // chckAddNewAuthor
            // 
            this.chckAddNewAuthor.AutoSize = true;
            this.chckAddNewAuthor.Location = new System.Drawing.Point(132, 187);
            this.chckAddNewAuthor.Name = "chckAddNewAuthor";
            this.chckAddNewAuthor.Size = new System.Drawing.Size(82, 17);
            this.chckAddNewAuthor.TabIndex = 3;
            this.chckAddNewAuthor.Text = "New Author";
            this.chckAddNewAuthor.UseVisualStyleBackColor = true;
            this.chckAddNewAuthor.CheckedChanged += new System.EventHandler(this.chckAddNewAuthor_CheckedChanged);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Enabled = false;
            this.txtAuthorName.Location = new System.Drawing.Point(12, 227);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(202, 20);
            this.txtAuthorName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author List:";
            // 
            // btnCreateNewBook
            // 
            this.btnCreateNewBook.Location = new System.Drawing.Point(10, 293);
            this.btnCreateNewBook.Name = "btnCreateNewBook";
            this.btnCreateNewBook.Size = new System.Drawing.Size(75, 28);
            this.btnCreateNewBook.TabIndex = 6;
            this.btnCreateNewBook.Text = "Add Book";
            this.btnCreateNewBook.UseVisualStyleBackColor = true;
            this.btnCreateNewBook.Click += new System.EventHandler(this.btnCreateNewBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(387, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.FormattingEnabled = true;
            this.lbAuthor.Location = new System.Drawing.Point(235, 61);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(227, 186);
            this.lbAuthor.TabIndex = 8;
            // 
            // CreateNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 359);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateNewBook);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.chckAddNewAuthor);
            this.Controls.Add(this.txtBookDesc);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "CreateNewBook";
            this.Text = "CreateNewBook";
            this.Load += new System.EventHandler(this.CreateNewBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chckAddNewAuthor;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNewBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbAuthor;
    }
}