using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Page
    {
        public Guid PageId { get; set; }
        public Guid ModuleId { get; set; }
        public string PageCode { get; set; } = string.Empty;
        public string PageUrl { get; set; } = string.Empty;
        public string? Icon { get; set; }
        public bool IsMenu { get; set; }
        public int OrderIndex { get; set; }
        public StatusEnum Status { get; set; }
    }
}