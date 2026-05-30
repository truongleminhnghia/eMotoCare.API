using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Account : BaseEntity
    {
        public Guid AccountId { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}