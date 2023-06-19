namespace LibraryProject
{
    public abstract class LibraryManagmentCore
    {
        public LibraryStore Store { get; set; }

        public LibraryManagmentCore()
        {
            Store = new LibraryStore();
        }

        public LibraryManagmentCore(List<Book> books, List<User> users)
        {
            Store = new LibraryStore(books, users);
        }

        public void DisplayAllUsers()
        {
            foreach (var user in Store.Users)
                Console.WriteLine(user.ToString());
        }

        public void DisplayAllBooks()
        {
            foreach (var book in Store.Books)
                Console.WriteLine(book.ToString());
        }
    }
}
