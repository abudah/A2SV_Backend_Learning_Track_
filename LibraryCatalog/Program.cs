public class Program
{
	public static void Main(string[] args)
	{
		Library library = new Library("Central Library" , "Adama ASTU");
		
		// Book Objects
		Book book1 = new Book("Book 1", "Albert", "HDFHAS23423432", 1993);
		Book book2 = new Book("Book 2", "Albert", "HDFHAS23423432", 1993);
		Book book3 = new Book("Book 3", "Albert", "HDFHAS23423432", 1993);
		Book book4 = new Book("Book 4", "Albert", "HDFHAS23423432", 1993);

		// MediaItem Objects
		MediaItem media1 = new MediaItem("Media 1", "CD", 72);
		MediaItem media2 = new MediaItem("Media 2", "CD", 72);
		MediaItem media3 = new MediaItem("Media 3", "CD", 72);
		MediaItem media4 = new MediaItem("Media 4", "CD", 72);
		MediaItem media5 = new MediaItem("Media 5", "CD", 72);

		// Add Books into the Library
		library.AddBook(book1);
		library.AddBook(book2);
		library.AddBook(book3);
		library.AddBook(book4);

		// Add Medias into the Library

		library.AddMediaItem(media1);
		library.AddMediaItem(media2);
		library.AddMediaItem(media3);
		library.AddMediaItem(media4);
		library.AddMediaItem(media5);

		library.PrintCatalog();
		library.RemoveBook(book1);
		library.RemoveBook(book2);
		library.RemoveMediaItem(media3);
		library.RemoveMediaItem(media4);
		library.PrintCatalog();
		library.RemoveMediaItem(media4);


		// Search Book and Media using Title

		library.SearchBook("Book 3");
		library.SearchMedia("Meid 2");		
	}
	
}