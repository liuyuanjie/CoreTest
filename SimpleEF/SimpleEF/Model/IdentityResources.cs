﻿using System;
using System.Collections.Generic;

namespace SimpleEF.Model
{
    public partial class IdentityResources
    {
        public IdentityResources()
        {
            IdentityClaims = new HashSet<IdentityClaims>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Emphasize { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }

        public ICollection<IdentityClaims> IdentityClaims { get; set; }
    }
}
