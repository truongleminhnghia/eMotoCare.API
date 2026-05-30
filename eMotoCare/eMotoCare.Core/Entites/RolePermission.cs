using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;

namespace eMotoCare.Core.Entites
{
    public class RolePermission : BaseEntity
    {
        public Guid RolePermissionId { get; set; }
        public Guid PermissionId { get; set; }
        public Guid CreateBy { get; set; }
        public Guid LastEditBy { get; set; }
    }
}