﻿using System;
using System.Collections.Generic;

namespace SimpleEF.Model
{
    public partial class ClientGrantTypes
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string GrantType { get; set; }

        public Clients Client { get; set; }
    }
}
