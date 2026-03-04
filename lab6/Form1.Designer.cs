namespace lab6
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
            pgBar = new ProgressBar();
            btnFetchBooks = new Button();
            btnAddBook = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            txtBookID = new TextBox();
            txtBookTitle = new TextBox();
            txtSearchTitle = new TextBox();
            lblAuthor = new Label();
            lblTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // pgBar
            // 
            pgBar.Location = new Point(312, 323);
            pgBar.Name = "pgBar";
            pgBar.Size = new Size(338, 23);
            pgBar.TabIndex = 0;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(449, 285);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(75, 23);
            btnFetchBooks.TabIndex = 1;
            btnFetchBooks.Text = "Fetch";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(172, 146);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 8F);
            btnUpdate.Location = new Point(172, 208);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 8F);
            btnDelete.Location = new Point(172, 237);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(575, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Font = new Font("Segoe UI", 10F);
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 17;
            listBoxBooks.Location = new Point(312, 87);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(338, 174);
            listBoxBooks.TabIndex = 6;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("Segoe UI", 11F);
            txtAuthorName.Location = new Point(108, 80);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(139, 27);
            txtAuthorName.TabIndex = 7;
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 12F);
            txtBookID.Location = new Point(108, 211);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(49, 29);
            txtBookID.TabIndex = 8;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI", 11F);
            txtBookTitle.Location = new Point(108, 113);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(139, 27);
            txtBookTitle.TabIndex = 9;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(312, 46);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.PlaceholderText = "Enter Title";
            txtSearchTitle.Size = new Size(257, 23);
            txtSearchTitle.TabIndex = 10;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F);
            lblAuthor.Location = new Point(31, 86);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(61, 21);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(50, 115);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(66, 210);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 13;
            label1.Text = "Id:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 450);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(txtSearchTitle);
            Controls.Add(txtBookTitle);
            Controls.Add(txtBookID);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddBook);
            Controls.Add(btnFetchBooks);
            Controls.Add(pgBar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pgBar;
        private Button btnFetchBooks;
        private Button btnAddBook;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private TextBox txtBookID;
        private TextBox txtBookTitle;
        private TextBox txtSearchTitle;
        private Label lblAuthor;
        private Label lblTitle;
        private Label label1;
    }
}
