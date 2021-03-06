﻿using LiteralLifeChurch.LiveStreamingApi.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiteralLifeChurch.LiveStreamingApi.Models.Output
{
    public class WebhookOutputModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("action")]
        public ActionEnum Action { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public ResourceStatusEnum Status { get; set; }
    }
}
