﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinListView.Models
{
    class Paises
    {
        #region Atributos
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }

        [JsonProperty(PropertyName = "capital")]
        public string Capital { get; set; }
        #endregion
    }
}
