namespace LibraryApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnOpenAddBook;
        private System.Windows.Forms.Button btnRefreshAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnOpenAddBook = new System.Windows.Forms.Button();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            // dgvAuthors
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Location = new System.Drawing.Point(30, 20);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.Size = new System.Drawing.Size(500, 150);
            this.dgvAuthors.TabIndex = 0;

            // dgvBooks
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(30, 190);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(500, 150);
            this.dgvBooks.TabIndex = 1;

            // btnAddAuthor
            this.btnAddAuthor.Location = new System.Drawing.Point(560, 30);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(120, 30);
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);

            // btnOpenAddBook
            this.btnOpenAddBook.Location = new System.Drawing.Point(560, 80);
            this.btnOpenAddBook.Name = "btnOpenAddBook";
            this.btnOpenAddBook.Size = new System.Drawing.Size(120, 30);
            this.btnOpenAddBook.Text = "Add Book";
            this.btnOpenAddBook.UseVisualStyleBackColor = true;
            this.btnOpenAddBook.Click += new System.EventHandler(this.btnOpenAddBook_Click);

            // btnRefreshAll
            this.btnRefreshAll.Location = new System.Drawing.Point(560, 130);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(120, 30);
            this.btnRefreshAll.Text = "Refresh All";
            this.btnRefreshAll.UseVisualStyleBackColor = true;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 370);
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnOpenAddBook);
            this.Controls.Add(this.btnRefreshAll);
            this.Name = "MainForm";
            this.Text = "Library Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
