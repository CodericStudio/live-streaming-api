﻿using System.Collections.Generic;

namespace LiteralLifeChurch.LiveStreamingApi.models.input
{
    public class StopInputModel
    {
        public List<string> LiveEvents { get; set; }

        public string StreamingEndpoint { get; set; }
    }
}