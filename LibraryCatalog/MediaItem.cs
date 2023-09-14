public class MediaItem
{
	private String _Title;
	private String _MediaType;
	private int _Duration;

	// Constructors for taking default values for the item

	public MediaItem(String title, String mediaType, int duration)
	{
		this._Title = title;
		this._MediaType = mediaType;
		this._Duration = duration;
	}

	// Getters and setters for class

	public String Title
	{
		get {return _Title; }
		set {_Title = value; }
	}
	public String MediaType
	{
		get {return _MediaType; }
		set {_MediaType = value; }
	}
	public int Duration
	{
		get {return _Duration; }
		set {_Duration = value; }
	}
	
}