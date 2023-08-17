public class DevTeam
{
  private static int _count = 0;
  // Team name, Members (list of devs), etc
  private readonly List<Dev> _members =  new List<Dev>();
  public int Id { get; private set; }
  public string Name { get; set; } = "The Nobodies";

  public DevTeam() {
    Id = ++_count;
  }

  // CRUD (access methods)
  public List<Dev> GetTeamMembers()
  {
    return _members;
  }

  public bool AddMember(Dev dev)
  {
    if (dev == null) return false;
    // no email? etc.
    _members.Add(dev);
    return true;
  }

  public bool RemoveMember(Dev dev)
  {
    _members.Remove(dev);
    return true;
  }
  public bool IsDevOnTeam(Dev dev) {
    return _members.Contains(dev);
  }

  // Remove member
  // Change name?
}