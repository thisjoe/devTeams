public class Dev
{
  private static int _count = 0;
  public int Id {get; private set;}
  public string Name {get; set;}
  public string Email {get; set;}
  public bool HasPluralSightAccess {get; set;}
  // etc.
  public Dev()
  {
    Id = ++_count;
  }

    public override string ToString()
    {
        return $"{Id} -  Name: {Name, -20} Email: {Email, -20}";
    }
}