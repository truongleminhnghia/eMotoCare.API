using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Permission
    {
        public Guid PermissionId { get; set; }
        public Guid PageId { get; set; }
        public Guid ActionId { get; set; }
        public StatusEnum Status { get; set; }
    }
}