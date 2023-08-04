DevRepo repo = new();
DevTeamRepo teamRepo = new();

// Create a list of devs
repo.Seed();
// Add those devs to teams
teamRepo.Seed();

Console.WriteLine("What");

ProgramUI ui = new(repo, teamRepo);
ui.Run();