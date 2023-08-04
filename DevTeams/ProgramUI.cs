public class ProgramUI
{
	private DevRepo _devRepo;
	private DevTeamRepo _teamRepo;

	public ProgramUI(DevRepo devRepo, DevTeamRepo teamRepo)
	{
		// Dependency Injection
		_devRepo = devRepo;
		_teamRepo = teamRepo;
	}

	public void Run()
	{
		// Login? That could go here if we had it.
		Menu();
	}
	private void Menu()
	{
		bool continueToRun = true;

		while (continueToRun)
		{
			Console.Clear();
			Console.WriteLine("Please select an option:\n" +
				"1. List all Devs\n" +
				"2. List all Teams\n" +
				"3. Add Dev to Team\n" +
				"0. Exit\n");

			Console.Write("Selection: ");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					ListAllDevs();
					break;
				case "2":
					ListAllTeams();
					break;
				case "3":
					AddDevToTeam();
					break;
				case "0":
					continueToRun = false;
					Exit();
					break;
				default:
					break;
			}
		}
	}

	private void ListAllDevs()
	{
		Console.Clear();
		ListDevs();
		PauseAndContinue();
	}
	private void ListDevs()
	{
		foreach (Dev dev in _devRepo.GetAllDevs())
			Console.WriteLine(dev);
	}
	private void ListAllTeams()
	{
		Console.Clear();
		ListTeams();
		PauseAndContinue();
	}
	private void ListTeams()
	{
		foreach (DevTeam team in _teamRepo.GetTeams())
		{
			Console.WriteLine($"{team.Id} - {team.Name}");
			foreach (Dev member in team.GetTeamMembers())
			{
				Console.WriteLine("   " + member);
			}
		}
	}

	private void AddDevToTeam()
	{
		// Which team do you want to add a member to
		Console.Clear();
		Console.WriteLine("Which team would you like to add to?");
		ListTeams();
		Console.Write("\nID: ");
		string teamChoice = Console.ReadLine();

		// BONUS: isValidId? = takes in a string, returns bool whether that ID exists
		// WITHOUT THROWING AN ERROR - HANDLE IT COMPLETELY

		DevTeam team = _teamRepo.GetTeamById(Convert.ToInt32(teamChoice));
		if (team == null)
		{
			ShowError("Invalid Team ID!");
			PauseAndContinue();
			return;
		}

		// Which dev to add?
		Console.WriteLine("Which dev would you like to add to this team?");

		foreach (Dev dev in _devRepo.GetAllDevs())
			if (!team.IsDevOnTeam(dev))
				Console.WriteLine(dev);

		// ListDevs();
		Console.Write("\nID: ");
		string devChoice = Console.ReadLine();
		int devID = Convert.ToInt32(devChoice);
		Dev developer = _devRepo.GetDev(devID);
		if (developer == null)
		{
			ShowError("Invalid Developer ID!");
			PauseAndContinue();
			return;
		}
		// Add dev to team
		team.AddMember(developer);
		// Pause and continue
		PauseAndContinue();
	}

	private void Exit()
	{
		Console.Clear();
		Console.WriteLine("\n\n      Goodbye!\n\n");
		Thread.Sleep(2000);
	}
	private void PauseAndContinue()
	{
		System.Console.WriteLine("Press any key to continue...");
		Console.ReadKey();
	}
	private void ShowError(string message)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"## Error: {message}");
		Console.ResetColor();
	}
}