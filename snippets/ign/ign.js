// Axios

import axios from "axios";

const options = {
  method: 'PUT',
  url: 'https://pd.{Shard}.a.pvp.net/name-service/v2/players',
  headers: {'Content-Type': 'application/json'},
  data: ['PUUID', 'OTHERPUUID']
};

axios.request(options).then(function (response) {
  console.log(response.data);
}).catch(function (error) {
  console.error(error);
});

//Fetch

fetch("https://pd.{Shard}.a.pvp.net/name-service/v2/players", {
  "method": "PUT",
  "headers": {
    "Content-Type": "application/json"
  },
  "body": "[\"PUUID\",\"OTHERPUUID\"]"
})
.then(response => {
  console.log(response);
})
.catch(err => {
  console.error(err);
});
