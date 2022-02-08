using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IdentityDemo.Shared.coreEntites
{
#nullable enable
    public class NameBaseEntity: EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
