
namespace LibraryApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Authors: {GlobalData.AuthorsList?.Count}, Books: {GlobalData.BooksList?.Count}");

            dgvBooks.AutoGenerateColumns = true; // force default columns
            DisplayData();
        }


      


            private void DisplayData()
        {
            dgvAuthors.AutoGenerateColumns = true;
            dgvAuthors.DataSource = null;
            dgvAuthors.DataSource = GlobalData.AuthorsList.ToList();

            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = GlobalData.BooksList.ToList();
        }

        

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm addAuthorForm = new AddAuthorForm();
            addAuthorForm.ShowDialog();
            DisplayData(); 
        }

        private void btnOpenAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
            DisplayData();
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            GlobalData.RefreshAuthorsList();
            GlobalData.RefreshBooksList();
            DisplayData();
            MessageBox.Show("تم تحديث البيانات.", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
