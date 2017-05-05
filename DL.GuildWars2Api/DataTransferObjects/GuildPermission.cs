﻿using Newtonsoft.Json;

namespace DL.GuildWars2Api.DataTransferObjects
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GuildPermission
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}