using LibraryApp.DAL;
using LibraryApp.Models;

namespace LibraryApp.Forms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            LoadAuthorsComboBox();
        }

        private void LoadAuthorsComboBox()
        {
            cmbAuthors.DataSource = null;

            var authorDisplayList = GlobalData.AuthorsList
                .Select(a => new
                {
                    a.AuthorID,
                    Display = $"{a.AuthorID} - {a.FirstName} {a.LastName}"
                })
                .ToList();

            cmbAuthors.DataSource = authorDisplayList;
            cmbAuthors.DisplayMember = "Display";    // what is shown in dropdown
            cmbAuthors.ValueMember = "AuthorID";     // what is returned by SelectedValue

            if (cmbAuthors.Items.Count > 0)
                cmbAuthors.SelectedIndex = 0;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || cmbAuthors.SelectedItem == null)
            {
                MessageBox.Show("يرجى إدخال عنوان الكتاب واختيار المؤلف.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book newBook = new Book
            {
                Title = txtTitle.Text.Trim(),
                AuthorID = (int)cmbAuthors.SelectedValue,
                PublicationYear = (int)numYear.Value
            };

            using (BookDAL dal = new BookDAL())
            {
                if (dal.AddBook(newBook))
                {
                    MessageBox.Show("تمت إضافة الكتاب بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalData.RefreshBooksList(); 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("فشلت عملية إضافة الكتاب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        }
    }
