using LibraryProject;

var LibraryManagment = new LibraryManagmentCore(DataSource.Books, DataSource.Users);

LibraryManagment.DisplayAllBooks();
LibraryManagment.DisplayAllUsers();


