## What Is This API?
The In-Game API is used by the Valorant Client to communicate with Riot's servers. It is almost the same as Riot's official API except that it uses the player's Riot credentials rather than a Key given by Riot. Use of this API is strictly unofficial with no support given by Riot at all. However, as long as you [do the right thing](https://github.com/Soneliem/Useful-ValorantAPI-Info/blob/main/unspokenrules.md), you should be fine.

#### Local APIs (`https://127.0.0.1:{lockfile port}`)
In addition to the direct communications to Riot's Servers, the Game runs a websocket that you can connect to. These require lockfile access and cannot be written to.

#### Authentication
There are two ways of getting credentials to use the API both of these are used to generate Authentication Headers: a Riot Token and Riot Entitlement. The first one is using a username and password which is only recommended if the user needs to sign in from an external device or if the game is not running. If the game is running and the app is running on the same machine, you can instead get Headers from the local endpoints. This requires getting a password and port from the lockfile which is generated when the game is running. 

#### Regions
Each URL changes depending on the region. Additionally they are separated into sub-regions. Below is a table will all known regions and shards:

| Name          | Region | Shard | Example Countries       |
|---------------|:------:|:-----:|-------------------------|
| North America |   NA   |   NA  | Canada, USA             |
| Asia Pacific  |   AP   |   AP  | India, China, Australia |
| Europe        |   EU   |   EU  | Russia, UK              |
| Korea         |   KO   |   KO  | Korea                   |
| LATAM         |  LATAM |   NA  | Mexico, Argentina       |
| Brazil        |   BR   |   NA  | Brazil                  |

For GLZ URLs: `glz-{region}-1.{shard}`
For PVP URLs: `pd.{shard}.a.pvp.net`
