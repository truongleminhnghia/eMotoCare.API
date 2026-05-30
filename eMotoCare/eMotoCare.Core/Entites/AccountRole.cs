using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;

namespace eMotoCare.Core.Entites
{
    public class AccountRole : BaseEntity
    {
        public Guid AccountId { get; set; }
        public Guid RoleId { get; set; }
        public Guid CreateBy { get; set; }
        public Guid? LastEditBy { get; set; }
    }
}