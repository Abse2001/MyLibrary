namespace LibraryApp.Forms
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Button btnAddBook;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            cmbAuthors = new ComboBox();
            lblYear = new Label();
            numYear = new NumericUpDown();
            btnAddBook = new Button();

            ((System.ComponentModel.ISupportInitialize)(numYear)).BeginInit();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(30, 30);
            lblTitle.Text = "Title:";

            // txtTitle
            txtTitle.Location = new Point(120, 25);
            txtTitle.Size = new Size(200, 23);

            // lblAuthor
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(30, 70);
            lblAuthor.Text = "Author:";

            // cmbAuthors
            cmbAuthors.Location = new Point(120, 65);
            cmbAuthors.Size = new Size(200, 23);

            // lblYear
            lblYear.AutoSize = true;
            lblYear.Location = new Point(30, 110);
            lblYear.Text = "Year:";

            // numYear
            numYear.Location = new Point(120, 105);
            numYear.Maximum = 2100;
            numYear.Minimum = 1800;
            numYear.Value = 2000;

            // btnAddBook
            btnAddBook.Text = "Add Book";
            btnAddBook.Location = new Point(120, 150);
            btnAddBook.Click += new EventHandler(this.btnAddBook_Click);

            // AddBookForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 220);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblAuthor);
            Controls.Add(cmbAuthors);
            Controls.Add(lblYear);
            Controls.Add(numYear);
            Controls.Add(btnAddBook);
            Name = "AddBookForm";
            Text = "Add Book";
            Load += new EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(numYear)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
