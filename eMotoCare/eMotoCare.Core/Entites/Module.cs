using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Module
    {
        public Guid? ModuleId { get; set; }
        public string ModuleName { get; set; } = string.Empty;
        public string ModuleCode { get; set; } = string.Empty;
        public int OrderIndex { get; set; }
        public StatusEnum Status { get; set; }
    }
}