﻿using System;
using System.Collections.Generic;

namespace SimpleEF.Model
{
    public partial class ClientCorsOrigins
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Origin { get; set; }

        public Clients Client { get; set; }
    }
}
