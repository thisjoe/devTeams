public class DevTeam {
    private readonly List<Developer> _members = new List<Developer>();

    public int Id { get; private set; }
    public string Name { get; set; } = "";
    public List<Developer> Members { get { return _members; } }

    public bool AddMember(Developer dev) {
        if (dev == null)
            return false;

        _members.Add(dev);
        return true;
    }

    public bool RemoveMember(Developer dev) {
        if (dev == null)
            return false;

        _members.Remove(dev);
        return true;
    }

    public bool HasMember(Developer dev) {
        return _members.Contains(dev);
    }

    public bool HasMember(int id) {
        return _members.Any(d => d.Id == id);
    }

    public bool HasMember(string email) {
        return _members.Any(d => d.Email == email);
    }

}

/*
public class TeamRepo  
{


  public Team GetTeamById(int id)
  {
    return _teams.FirstOrDefault(t => t.Id == id);
  }

  public void AddTeam(Team team)
  {
    if (team == null)
      throw new ArgumentNullException(nameof(team));
    
    _teams.Add(team);
  }

  public void RemoveTeam(Team team) 
  {
    _teams.Remove(team);
  }

  public void AddDeveloperToTeam(int teamId, Developer developer)
  {
    Team team = GetTeamById(teamId);
    team.AddMember(developer);
  }

  public void RemoveDeveloperFromTeam(int teamId, Developer developer)
  {
    Team team = GetTeamById(teamId);
    team.RemoveMember(developer);
  }

  public void Seed()
  {
    //...create teams 
    
    _teams.Add(team1);
    _teams.Add(team2);
  }
}
*/