using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexAPI_Test.Models
{
    public class PokeList
    {
        [JsonProperty("count")]
        public long Quantity { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<PokemonL> listPokemon { get; set; }
    }
}
