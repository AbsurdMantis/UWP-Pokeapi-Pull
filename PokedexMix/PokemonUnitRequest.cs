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

namespace PokedexMix
{
    
        public class UnitRequest
        {
            public string url { get; set; }
            private int actual = 0;
            ApiRequest api = new ApiRequest();

            public UnitRequest()
            {
                
                PokeList test = api.GetList();

            //url = test.listPokemon[1].link.ToString();

            for (int i = 0; i < 10; i++)
            {
               url = test.listPokemon[i].link.ToString();
            }

            }

            public PokemonDataWrapper.Pokemon GetPokey()
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

                                PokemonDataWrapper.Pokemon pokelist = JsonConvert.DeserializeObject<PokemonDataWrapper.Pokemon>(responseText);
                                //actual = +10;

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

