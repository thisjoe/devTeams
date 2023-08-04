public class DevRepo {
    // List of developers

    // CRUD methods to access developers

    public List<Dev> GetAllDevs()
    {

    }
}



/*
public class DevRepo
{
  private readonly List<Dev> _devs = new List<Dev>();

  public List<Dev> GetAllDevs()
  {
    return _devs;
  }

  public Dev GetDev(int id)
  {
    return _devs.FirstOrDefault(d => d.Id == id);
  }

  public Dev GetDev(string email)
  {
    if (string.IsNullOrEmpty(email))
      throw new ArgumentException("Email is required");

    return _devs.FirstOrDefault(d => d.Email == email); 
  }

  public bool AddDev(Dev dev)
  {
    if (dev == null)
      throw new ArgumentNullException(nameof(dev));

    if (string.IsNullOrEmpty(dev.Email))
      return false;

    _devs.Add(dev);
    return true;
  }

  public void RemoveDev(Dev dev)
  {
    foreach (DevTeam team in _teamRepo.GetAllTeams()) {
        if (team.HasDev(dev)) {
            team.RemoveMember(dev);
        }
    }

    _devs.Remove(dev);
  }

  public void Seed()
  {
    Developer dev1 = new Developer();
  dev1.Id = 1;
  dev1.Name = "John Doe";
  dev1.Email = "john@email.com";

  Developer dev2 = new Developer();
  dev2.Id = 2; 
  dev2.Name = "Jane Smith";
  dev2.Email = "jane@email.com";

  Developer dev3 = new Developer();
  dev3.Id = 3;
  dev3.Name = "Bob Johnson";
  dev3.Email = "bob@email.com";

  _developers.Add(dev1);
  _developers.Add(dev2);
  _developers.Add(dev3);
  }
}
*/