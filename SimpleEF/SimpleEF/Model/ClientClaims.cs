using System;
using System.Collections.Generic;

namespace SimpleEF.Model
{
    public partial class ClientClaims
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public Clients Client { get; set; }
    }
}
