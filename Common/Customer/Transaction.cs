using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Customer
{
    public class Transaction
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public double Amount { get; set; }
        [JsonProperty]
        public DateTime Timestamp { get; set; }
    }
}
