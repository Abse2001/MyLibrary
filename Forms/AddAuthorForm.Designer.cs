namespace LibraryApp.Forms
{
    partial class AddAuthorForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblAge;
        private NumericUpDown numAge;
        private Button btnAddAuthor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblAge = new Label();
            numAge = new NumericUpDown();
            btnAddAuthor = new Button();

            SuspendLayout();

            // lblFirstName
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 30);
            lblFirstName.Text = "First Name:";

            // txtFirstName
            txtFirstName.Location = new Point(120, 25);
            txtFirstName.Size = new Size(200, 23);

            // lblLastName
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 70);
            lblLastName.Text = "Last Name:";

            // txtLastName
            txtLastName.Location = new Point(120, 65);
            txtLastName.Size = new Size(200, 23);

            // lblAge
            lblAge.AutoSize = true;
            lblAge.Location = new Point(30, 110);
            lblAge.Text = "Age:";

            // numAge
            numAge.Location = new Point(120, 105);
            numAge.Minimum = 1;
            numAge.Maximum = 120;
            numAge.Value = 30;

            // btnAddAuthor
            btnAddAuthor.Text = "Add Author";
            btnAddAuthor.Location = new Point(120, 150);
            btnAddAuthor.Click += new EventHandler(btnAddAuthor_Click);

            // AddAuthorForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 220);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblAge);
            Controls.Add(numAge);
            Controls.Add(btnAddAuthor);
            Name = "AddAuthorForm";
            Text = "Add Author";
            Load += AddAuthorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
