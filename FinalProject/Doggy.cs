using System;
using Newtonsoft.Json;

namespace FinalProject
{
    public class Doggy
    {
        public string Status { get; set; }

        [JsonProperty("Message")]
        public string DogPhotoUrl { get; set; }
    }
}
