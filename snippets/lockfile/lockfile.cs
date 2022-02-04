var lockfileLocation = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Riot Games\Riot Client\Config\lockfile";
if (File.Exists(lockfileLocation)) {
  using (FileStream fileStream = new(lockfileLocation, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
  using (StreamReader sr = new(fileStream))
  {
    string[] parts = sr.ReadToEnd().Split(":");
    Port = parts[2];
    LocalPassword = parts[3];
    Protocol = parts[4];
  }
}
