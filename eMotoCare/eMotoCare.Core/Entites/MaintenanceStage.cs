using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class MaintenanceStage : BaseEntity
    {
        public Guid MaintenanceStageId { get; set; }
        public Guid MaintenancePlanId { get; set; }
        public string MaintenanceStageCode { get; set; } = string.Empty;
        public string? MaintenanceStageName { get; set; }
        public int OrderIndex { get; set; }
        public string MaintenanceInterval { get; set; } = string.Empty;
        public int TimeMaintenance { get; set; }
        public UnitEnum Unit { get; set; }
        public string? Description { get; set; }
        public StatusEnum Status { get; set; }
    }
}