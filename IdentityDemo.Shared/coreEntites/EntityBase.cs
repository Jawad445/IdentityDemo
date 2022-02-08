using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityDemo.Shared.coreEntites
{
#nullable enable
    public class EntityBase<TId>
    {
        public TId Id { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset UpdatedDateTime { get; set; }
    }

    public class EntityBase : EntityBase<Guid>
    {        
        public EntityBase()
        {
            base.Id = Guid.NewGuid();
        }
    }
}
