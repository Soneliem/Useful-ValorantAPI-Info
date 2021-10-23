## What Is This API?
The In-Game API is used by the Valorant Client to communicate with Riot's servers. It is almost the same as Riot's official API except that it uses the player's Riot credentials rather than a Key given by Riot. Use of this API is strictly unofficial with no support given by Riot at all. However, as long as you [do the right thing](), you should be fine.

#### Local APIs (`https://127.0.0.1:{lockfile port}`)
In addition to the direct communications to Riot's Servers, the Game runs a websocket that you can connect to. These require lockfile access and cannot be written to.

#### Regions
Each url changes depending on the region. Additionally they are separated into sub-regions. Below is a table will all known regions and shards:

| Name          | Region | Shard | Example Countries       |
|---------------|:------:|:-----:|-------------------------|
| North America |   NA   |   NA  | Canada, USA             |
| Asia Pacific  |   AP   |   AP  | India, China, Australia |
| Europe        |   EU   |   EU  | Russia, UK              |
| Korea         |   KO   |   KO  | Korea                   |
| LATAM         |  LATAM |   NA  | Mexico, Argentina       |
| Brazil        |   BR   |   NA  | Brazil                  |

For glz URLs: `glz-{region}-1.{shard}`
For pd URLs: `pd.{shard}.a.pvp.net`
