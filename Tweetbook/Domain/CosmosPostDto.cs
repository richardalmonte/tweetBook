﻿using Cosmonaut.Attributes;
using Newtonsoft.Json;

namespace Tweetbook.Domain
{
    public class CosmosPostDto
    {
        [CosmosPartitionKey]
        [JsonProperty("id")]
        public string Id { get; set; }

        public string Name { get; set; }

    }
}
