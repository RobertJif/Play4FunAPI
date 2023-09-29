using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play4Fun.Models.Requests
{
    public class NewMatchRequest
    {
        public string GameCode { get; set; }
        public string PlayerUsername { get; set; }
    }
}