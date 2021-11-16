using Newtonsoft.Json;
using PokedexAPI_Test;
using PokedexAPI_Test.Models;
using PokedexMix.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static PokedexAPI_Test.ApiRequest;
using static PokedexMix.Models.PokemonDataWrapper;

namespace PokedexMix
{
    
        public class UnitRequest
        {
            public string url { get; set; }
            public int actual = 0;
            ApiRequest api = new ApiRequest();

            public UnitRequest()
            {
            PokeList test = api.GetList();

            

            url = test.listPokemon[actual].link.ToString();
            

            }

            public Pokemon GetPokey()
            {
                var query = (HttpWebRequest)WebRequest.Create(url);
                query.Method = "GET";
                query.ContentType = "application/json";
                query.Accept = "application/json";

                try
                {
                    using (WebResponse response = query.GetResponse())
                    {
                        using (Stream stream = response.GetResponseStream())
                        {
                            if (stream == null)
                            {
                                return null;
                            }

                            using (StreamReader Reader = new StreamReader(stream))
                            {
                                string responseText = Reader.ReadToEnd();

                                Pokemon pokelist = JsonConvert.DeserializeObject<Pokemon>(responseText);

                                actual =+ 1;

                            return pokelist;
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }


    }

