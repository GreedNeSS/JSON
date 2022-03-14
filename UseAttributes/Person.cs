using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UseAttributes
{
    class Person
    {
        [JsonPropertyName("firstname")]
        public string Name { get; set; }
        [JsonIgnore]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
