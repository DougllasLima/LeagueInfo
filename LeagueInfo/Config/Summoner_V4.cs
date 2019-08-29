﻿using LeagueInfo.Summoner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueInfo.Config
{
    public class Summoner_V4 : ConfigAPI
    {
        public Summoner_V4(string region) : base(region)
        {
        }

        public SummonerDTO GetSummonerByName(string SummonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + SummonerName;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}