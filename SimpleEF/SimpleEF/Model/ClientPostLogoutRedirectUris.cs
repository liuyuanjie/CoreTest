using System;
using System.Collections.Generic;

namespace SimpleEF.Model
{
    public partial class ClientPostLogoutRedirectUris
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string PostLogoutRedirectUri { get; set; }

        public Clients Client { get; set; }
    }
}
