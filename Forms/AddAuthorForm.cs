using LibraryApp.DAL;
using LibraryApp.Models;

namespace LibraryApp.Forms
{
    public partial class AddAuthorForm : Form
    {
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("تنبيه: يرجى إدخال الاسم الأول واسم العائلة للمؤلف.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Author newAuthor = new Author
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Age = (int)numAge.Value
            };

            using (AuthorDAL dal = new AuthorDAL())
            {
                if (dal.AddAuthor(newAuthor))
                {
                    MessageBox.Show("تمت إضافة المؤلف بنجاح.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalData.RefreshAuthorsList(); // تحديث القائمة الخاصة بالمؤلفين
                    this.Close(); // إغلاق النافذة بعد الإضافة
                }
                else
                {
                    MessageBox.Show("فشل عملية إضافة المؤلف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddAuthorForm_Load(object sender, EventArgs e)
        {
            // Optional: Initialization code
        }

    }
}
