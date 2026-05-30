using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMotoCare.Core.Commons.Bases
{
    public abstract class BaseEntity
    {
        public DateTime CreatedAt { get; protected set; }

        public DateTime? UpdatedAt { get; protected set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public void SetUpdatedTime()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}