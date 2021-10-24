#Requests

import requests

url = "https://pd.{Shard}.a.pvp.net/name-service/v2/players"

payload = ["{PUUID}", "{OtherPUUID}}"]
headers = {"Content-Type": "application/json"}

response = requests.request("PUT", url, json=payload, headers=headers)

print(response.text)

#HTTP client
import http.client

conn = http.client.HTTPSConnection("pd.{Shard}.a.pvp.net")

payload = "[\"PUUID\", \"OTHERPUUID\"]"

headers = { 'Content-Type': "application/json" }

conn.request("PUT", "/name-service/v2/players", payload, headers)

res = conn.getresponse()
data = res.read()

print(data.decode("utf-8"))
