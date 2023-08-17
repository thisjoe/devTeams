public class DevRepo {
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
      _devs.Remove(dev);
    }

    public void Seed()
    {
      Dev dev = new Dev();
      dev.Email = "someone@email.com";
      dev.Name = "someone";
      _devs.Add(dev);

      Dev deb = new Dev();
      deb.Email = "deb@company.com";
      deb.Name = "Deb";
      deb.HasPluralSightAccess = true;
      _devs.Add(deb);

      Dev roy = new Dev();
      roy.Email = "roy@company.com";
      roy.Name = "Roy";
      roy.HasPluralSightAccess = true;
      _devs.Add(roy);

      Dev david = new Dev();
      david.Email = "dh@company.com";
      david.Name = "David";
      _devs.Add(david);
    }
}