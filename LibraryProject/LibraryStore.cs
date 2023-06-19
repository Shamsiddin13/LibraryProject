namespace LibraryProject
{
    public class LibraryStore
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }

        public LibraryStore()
        {
            Books = new List<Book>();
            Users = new List<User>();
        }


        public LibraryStore(List<Book> books, List<User> users)
        {
            Books = books;
            Users = users;
        }

    }
}
