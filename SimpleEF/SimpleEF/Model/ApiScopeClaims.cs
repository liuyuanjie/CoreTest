using System;
using System.Collections.Generic;

namespace SimpleEF.Model
{
    public partial class ApiScopeClaims
    {
        public int Id { get; set; }
        public int ApiScopeId { get; set; }
        public string Type { get; set; }

        public ApiScopes ApiScope { get; set; }
    }
}
