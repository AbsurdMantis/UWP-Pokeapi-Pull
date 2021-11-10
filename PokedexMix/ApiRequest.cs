using Newtonsoft.Json;
using PokedexAPI_Test.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokedexAPI_Test
{
    public class ApiRequest
    {
        public string url { get; set; }
        private int actual = 0;

        public ApiRequest()
        {
            url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=0";

        }

        public PokeList GetList()
        {
            var query = (HttpWebRequest)WebRequest.Create(url + actual);
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

                            PokeList pokelist = JsonConvert.DeserializeObject<PokeList>(responseText);
                            actual =+ 10;

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
