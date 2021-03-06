namespace LearnReferences
{
  class Diary : Book, IFlippable // extends base class and implements the interface 
  {
    public int CurrentPage
    { get; set; }

    public Diary(int page = 0) : base()
    {
		CurrentPage = page;
    }

    public void Flip()
    {
		CurrentPage++;
    }

    public string SpillSecret()
    {
		return "OMG kerry loves kris <3";
    }

    public override string Stringify() 
    {
		return "This is a Diary object!";
    }
	
	public override string ToString()
	{
		return $"This Diary is currently on page {CurrentPage}."; 
	}
  }
}