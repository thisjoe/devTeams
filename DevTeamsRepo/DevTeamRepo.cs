public class DevTeamRepo
{
    // List of teams
    private readonly List<DevTeam> _teams = new List<DevTeam>();

    public DevTeamRepo() {}
    public DevTeamRepo(List<DevTeam> teams) {
        _teams = teams;
    }

    public void Seed(DevRepo devRepo) {
        string teamName = "The Scuba Squad";
        AddTeam(teamName);
        DevTeam team = GetTeamByName(teamName);
        team.AddMember(devRepo.GetDev(1));
        team.AddMember(devRepo.GetDev(2));
        team.AddMember(new Dev() {Name="test", Email="test@email.com"});

        string otherTeamName = "The Mighty Ducks";
        AddTeam(otherTeamName);
        DevTeam otherTeam = GetTeamByName(otherTeamName);
        otherTeam.AddMember(devRepo.GetDev(3));
        otherTeam.AddMember(devRepo.GetDev(4));
    }

    // CRUD methods to access and edit the teams
    public List<DevTeam> GetTeams() {
        return _teams;
    }
    public DevTeam? GetTeamByName(string name) {
        return _teams.FirstOrDefault(t => t.Name == name);
    }
    public DevTeam? GetTeamById(int id) {
        return _teams.FirstOrDefault(t => t.Id == id);
    }
    // Create
    public bool AddTeam(string name) {
        if (string.IsNullOrEmpty(name)) return false;

        DevTeam team = new();
        team.Name = name;

        _teams.Add(team);
        return true;
    }
    public bool AddTeam(string name, List<Dev> members) {
        if (string.IsNullOrEmpty(name)) return false;

        DevTeam team = new();
        team.Name = name;

        foreach(Dev dev in members) {
            team.AddMember(dev);
        }

        return true;
    }
    
    // Delete
    public bool RemoveTeam(int id)
    {
        DevTeam team = GetTeamById(id);
        if(team == null) return false;

        _teams.Remove(team);
        return true;
    }

    public bool RemoveTeam(string name) 
    {
        DevTeam team = GetTeamByName(name);
        if(team == null) return false;

        _teams.Remove(team);
        return true;
    }
}