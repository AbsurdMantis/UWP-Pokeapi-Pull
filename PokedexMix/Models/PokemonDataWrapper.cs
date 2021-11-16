using Newtonsoft.Json;
using PokedexAPI_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMix.Models
{
    public class PokemonDataWrapper
    {
        public class Pokemon
        {
            [JsonProperty("name")]
            public string NamePokemonT { get; set; }
            //[JsonProperty("sprites")]
            //public Sprites Sprites { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            
        }

        [JsonProperty("data")]
        public Pokemon data { get; set; }






    }
}
