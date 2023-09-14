public class Library
{
	private String Name;
	private String Address;
	public List<Book> BookList = new List<Book>();	
	public List<MediaItem> MediaList = new List<MediaItem>();	

	public Library(String name, String address)
	{
		this.Name = name;
		this.Address = address;
	}


	// Book methods in Library
	public void AddBook(Book book)
	{
		BookList.Add(book);
	}

	public void RemoveBook(Book book)
	{
		if(BookList.Count == 0){
			Console.WriteLine("There is no Books in the Library to remove.");
		}
		else if (!BookList.Contains(book))
		{
			Console.WriteLine("The Book You are refering to is not in the Library.");	
		}
		else
		{
			BookList.Remove(book);
		}
	}



	// MediaITem methods in Library
	public void AddMediaItem(MediaItem mediaItem)
	{
		MediaList.Add(mediaItem);
	}
	public void RemoveMediaItem(MediaItem mediaItem)
	{
		if(MediaList.Count == 0){
			Console.WriteLine("There is no Media item in the Library to remove.");
		}
		else if (!MediaList.Contains(mediaItem))
		{
			Console.WriteLine("The Media item You are refering to is not in the Library.");	
		}
		else
		{
			MediaList.Remove(mediaItem);	
		}		
	}


	public void PrintCatalog()
	{
		Console.WriteLine("List of Books in the Library");

		// Display Books in the BookList
		foreach (Book book in BookList)
		{
			Console.WriteLine($"Book Name: {book.Title}, Book Author: {book.Author}, Book ISBN: {book.ISBN}, Book Publication Year: {book.PublicationYear}");
	
		}
		Console.WriteLine();
		
		Console.WriteLine("Media items in the Library");		

		// Display MediaItem in the MediaItemList
		foreach (MediaItem mediaItem in MediaList)
		{
			Console.WriteLine($"Media Name: {mediaItem.Title}, Media Type: {mediaItem.MediaType} , Media Duration: {mediaItem.Duration}");
		}
		

	}
	public void SearchBook(string title)
	{
		Book book = BookList.Find(b => b.Title == title);

		if (book != null)
		{
			Console.WriteLine("Book Found");
			Console.WriteLine($"Book Name: {book.Title}, Book Author: {book.Author}, Book ISBN: {book.ISBN}, Book Publication Year: {book.PublicationYear}");
		}
		else
		{
			Console.WriteLine("Book not Found");
		}
	}
	public void SearchMedia(string title)
	{
		MediaItem mediaItem = MediaList.Find(b => b.Title == title);

		if (mediaItem != null)
		{
			Console.WriteLine("Media Found");
			Console.WriteLine($"Media Name: {mediaItem.Title}, Media Type: {mediaItem.MediaType} , Media Duration: {mediaItem.Duration}");
		}
		else
		{
			Console.WriteLine("Media not Found");
		}
	}


}