using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class MaintenancePlan : BaseEntity
    {
        public Guid MaintenancePlanId { get; set; }
        public string? MaintenancePlanname { get; set; }
        public string MaintenancePlanCode { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int TotalStage { get; set; }
        public StatusEnum Status { get; set; }
    }
}
