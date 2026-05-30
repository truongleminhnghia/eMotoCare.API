using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Action
    {
        public Guid ActionId { get; set; }
        public string ActionCode { get; set; } = string.Empty;
        public string ActionName { get; set; } = string.Empty;
        public StatusEnum Status { get; set; }
    }
}