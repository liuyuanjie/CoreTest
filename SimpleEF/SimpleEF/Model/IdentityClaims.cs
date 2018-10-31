using System;
using System.Collections.Generic;

namespace SimpleEF.Model
{
    public partial class IdentityClaims
    {
        public int Id { get; set; }
        public int IdentityResourceId { get; set; }
        public string Type { get; set; }

        public IdentityResources IdentityResource { get; set; }
    }
}
