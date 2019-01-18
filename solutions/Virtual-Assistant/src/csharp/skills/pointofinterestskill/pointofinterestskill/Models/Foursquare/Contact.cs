﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfInterestSkill.Models.Foursquare
{
    public class Contact
    {
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "formattedPhone")]
        public string FormattedPhone { get; set; }

        [JsonProperty(PropertyName = "twitter")]
        public string Twitter { get; set; }

        [JsonProperty(PropertyName = "instagram")]
        public string Instagram { get; set; }

        [JsonProperty(PropertyName = "facebook")]
        public string Facebook { get; set; }

        [JsonProperty(PropertyName = "facebookUsername")]
        public string FacebookUsername { get; set; }

        [JsonProperty(PropertyName = "facebookName")]
        public string FacebookName { get; set; }
    }
}
