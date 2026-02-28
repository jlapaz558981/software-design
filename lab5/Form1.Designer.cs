namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            lblAuthorName = new Label();
            lblTitle = new Label();
            btnShowBooks = new Button();
            txtBookID = new TextBox();
            lblBookID = new Label();
            btnUpdateBook = new Button();
            btnDelete = new Button();
            btnSearchAuthor = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(495, 113);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(140, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(495, 151);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(140, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(495, 209);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(140, 23);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(35, 71);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(303, 214);
            listBoxBooks.TabIndex = 3;
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Location = new Point(429, 113);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(50, 15);
            lblAuthorName.TabIndex = 4;
            lblAuthorName.Text = "Author :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(443, 151);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(36, 15);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title :";
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(495, 247);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(140, 23);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(495, 71);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(140, 23);
            txtBookID.TabIndex = 7;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Location = new Point(455, 71);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(24, 15);
            lblBookID.TabIndex = 8;
            lblBookID.Text = "ID :";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(495, 292);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(140, 23);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(495, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(656, 113);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(75, 23);
            btnSearchAuthor.TabIndex = 11;
            btnSearchAuthor.Text = "Search";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchAuthor);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdateBook);
            Controls.Add(lblBookID);
            Controls.Add(txtBookID);
            Controls.Add(btnShowBooks);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Label lblAuthorName;
        private Label lblTitle;
        private Button btnShowBooks;
        private TextBox txtBookID;
        private Label lblBookID;
        private Button btnUpdateBook;
        private Button btnDelete;
        private Button btnSearchAuthor;
    }
}
