Code Snippets that might be useful. For ones I have added myself, I have made different ways of acheving the same thing.

#### Authentication
Standard authentication flow using username and password
- [**C#**](https://github.com/RumbleMike/ValorantAuth/blob/master/Program.cs)
- [**Python**](https://github.com/RumbleMike/ValorantClientAPI/blob/master/Docs/RSO_AuthFlow.py)
- [**PHP**](https://gist.github.com/BurakDev/fa802dfb9866f34b90fa7502ef11291b)

#### Authentication from LockFile
Get Authentication Headers from local files if Valorant is running
- [**C#**](https://github.com/Soneliem/Useful-ValorantAPI-Info/blob/main/snippets/lockfile/lockfile.cs)

#### Re-Authentication
Generate new Authentication Headers using saved cookies from an initial authentication request
- [**JS**](https://github.com/ev3nvy/valorant-reauth-script/blob/master/index.js)
- [**PHP**](https://github.com/weedeej/authspace/blob/master/src/Authentication.php#L38)

#### IGN from PUUID
Get Valorant In Game Username from PUUID without requiring authentication of any kind. These can be sent in bulk through a single request.
- [**Python**](https://github.com/Soneliem/Useful-ValorantAPI-Info/blob/main/snippets/ign/ign.py)
- [**JavaScript**](https://github.com/Soneliem/Useful-ValorantAPI-Info/blob/main/snippets/ign/ign.js)
- [**C#**](https://github.com/Soneliem/Useful-ValorantAPI-Info/blob/main/snippets/ign/ign.cs)
