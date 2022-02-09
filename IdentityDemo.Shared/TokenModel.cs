using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityDemo.Shared
{
    public class TokenModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
