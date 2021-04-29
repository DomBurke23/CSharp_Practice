namespace LearnReferences
{
  interface IFlippable // interface 
  {
    int CurrentPage { get; set; }
    void Flip();
  }
}