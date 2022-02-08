using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityDemo.Shared
{
    public class Response
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
