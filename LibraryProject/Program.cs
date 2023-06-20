using LibraryProject;

var LibraryManagment = new LibraryManagment();
LibraryManagment.RegisterUser("Umarov", "Shamsiddin");

var emailService = new EmailService();
emailService.SendEmail("shamsiddinumarov0013@gmail.com");


