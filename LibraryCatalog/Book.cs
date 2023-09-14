public class Book
{
	private String _Title;
	private String _Author;
	private String _ISBN;
	private int  _PublicationYear;
	
	// Constructors for setting values for class
	
	public Book(String title, String author, String iSBN, int publicationYear)
	{
		this._Title = title;
		this._Author = author;
		this._ISBN = iSBN;
		this._PublicationYear = publicationYear;
	}


	// Creating setter and getters for our class

	public String Title {
		get {return _Title; }
		set {_Title = value; }
	}

	public String Author {
		get {return _Author; }
		set {_Author = value; }
	}
	public String ISBN {
		get {return _ISBN; }
		set {_ISBN = value; }
	}
	public int PublicationYear {
		get {return _PublicationYear; }
		set {_PublicationYear = value; }
	}

}