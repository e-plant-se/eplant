using System;
using Newtonsoft.Json;

namespace eplant.Models
{
    public class Counters
    {
        [JsonProperty("idPlanta")]
        public string IdPlanta { get; set; }

        [JsonProperty("seq")]
        public int Seq { get; set; }

        internal bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
