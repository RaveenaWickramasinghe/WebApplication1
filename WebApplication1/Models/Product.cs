using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication1.Website.Models {
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

        
    }
}
