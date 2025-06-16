using LibraryApp.DAL;
using LibraryApp.Models;

public static class GlobalData
{
    public static List<Author> AuthorsList { get; private set; } = new();
    public static List<Book> BooksList { get; private set; } = new();

    static GlobalData()
    {
    
            RefreshAuthorsList();
            RefreshBooksList();
     
    }

    public static void RefreshAuthorsList()
    {
        using (var dal = new AuthorDAL())
            AuthorsList = dal.GetAll();
    }

    public static void RefreshBooksList()
    {
        using (var dal = new BookDAL())
            BooksList = dal.GetAll();
    }
}
