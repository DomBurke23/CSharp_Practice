using System;

namespace BasicClasses
{
  class Forest // defining a class 
  {
    // defining fields (class members)
    // common practice is to use all lowercase for fields 
    public string name; 
    /* Go back to ForestMain and change the field from f.name to f.Name */
    public string Name // property
    {
      get { return name; }
      set { name = value; }
    }

    //public int trees; 
    public int Trees
    {
        /*
        * get { return trees; }
        * set { trees = value; } 
        * The following is the same as above but written as an 
        * automatic property. 
        * must remove field trees */
        get; set; 
    }

    public int age; 
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
    
    private string biome; 
    public string Biome
    {
        get{return biome;}
        set{
          if(value == "Tropical" || value == "Temperate" || value == "Boreal"){
              Console.WriteLine(value); biome = value; }
          else{
              Console.WriteLine("Unknown"); biome="Unknown"; }
        }
    }
    
    /* Properties - validation for values */
    public int area;
    public int Area // Area property is associated with the area field. 
    {
        get { return area; } // called when the property is accessed
        /* The set() method above uses the keyword value, which 
         * represents the value we assign to the property. */
        //set { area = value; } // no validation here 
        set { //  called when the property is assigned a value
            if (value < 0) { area = 0; }
            else { area = value; }
        }
    }
    
    /* By applying public and private, we can also use properties to control access to fields. 
     * The following allows us to get the value but not set the value of circumference. */
    public int circumference;
    public int Circumference
    {
        get {return circumference;}
        private set {circumference = value;}
    }
    
    /* The third type of member in classes is methods. */
    public int IncreaseArea(int growth)
    {
        Area = Area + growth;
        return Area;
    }
    
    public int Grow(){
      Trees =+ 30;
      Age =+ 1;
      return Trees;
    }
    public int Burn(){
      Trees =- 20;
      Age =+ 1; 
      return Trees; 
    }
    
	private static int forestsCreated;
	public static int ForestsCreated
	{ 
	    get{return forestsCreated; }
	    private set {forestsCreated=value;}  
	}
	
    /* Constructors - look like a method but have no return type and name is the same as the class name */
    public int Radius; 
    public Forest(int radius,string name, string biome)
    {
        /* to make the following instance of the class more explicit using the word this.
         * means “when this constructor is used to make a new instance, use the argument 
         * area to set the value of this new instance’s Area field” */
        this.Radius = radius; // set value to fields 
        this.Name = name;
        this.Biome = biome; 
        this.Age = 0; 
		ForestsCreated++;
    }
    
    /* Overloading Constructors */
    /*public Forest(int radius)
    {
        this.Radius = area; 
        this.Name = "Unknown"; 
    }*/
    /* Reduce duplicate code when using Overloading Constructors */
    public Forest(int radius):this(radius,"Unknown2","Unknown3")
    {
        Console.WriteLine("Country property not specified. Value defaulted to 'Unknown'.");
    }
	
	/* static means “associated with the class, not an instance”. Thus any 
	 * static member is accessed from the class, not an instance */
	private static string definition;
	public static string Definition
	{ 
    	get { return definition; }
    	set { definition = value; }
	}
	
	private static string treeFacts;
    public static string TreeFacts{
      get;
      //set; 
    }
    public static void PrintTreeFacts(){
      Console.WriteLine($"TreeFacts = {TreeFacts} ");
    }

    /* Static constructor */
    static Forest(){
      treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      ForestsCreated = 0;
    }
  }
}
