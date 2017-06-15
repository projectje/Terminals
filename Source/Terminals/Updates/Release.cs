using System;
using Newtonsoft.Json;

namespace Terminals.Updates
{
    public class Release
    {
        [JsonProperty("tag_name")]
        public string TagName { get; set; }

        [JsonProperty("name")]

        public string Name { get; set; }

        [JsonProperty("published_at")]

        public DateTime Published { get; set; }
    }
}