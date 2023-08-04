public class Dev
{
  public int Id {get; private set;}
  public string Name {get; set;}
  public string Email {get; set;}
  public bool HasPluralSightAccess {get; set;}
}


/*

public class DeveloperRepository
{
  private readonly List<Developer> _developers = new List<Developer>();

  public List<Developer> GetAll()
  {
    return _developers;
  }

  public Developer GetById(int id)
  {
    return _developers.FirstOrDefault(d => d.Id == id);
  }

  public void Add(Developer dev)
  {
    if (dev == null)
      throw new ArgumentNullException(nameof(dev));
    
    _developers.Add(dev);
  }

  public void Remove(Developer dev)
  {
    _developers.Remove(dev);
  }
}
*/