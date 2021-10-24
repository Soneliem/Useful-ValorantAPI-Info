var client = new RestClient("https://pd.{Shard}.a.pvp.net/name-service/v2/players");
var request = new RestRequest(Method.PUT);
request.AddHeader("Content-Type", "application/json");
request.AddParameter("application/json", "[\"PUUID\", \"OTHERPUUID\"]", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
