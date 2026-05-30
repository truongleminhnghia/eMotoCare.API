using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class MaintenanceStageDetail : BaseEntity
    {
        public Guid MaintenanceStageDetailId { get; set; }
        public Guid MaintenanceStageId { get; set; }
        public Guid PartId { get; set; }
        public ActionTypeEnum ActionType { get; set; }
        public int OrderIndex { get; set; }
    }
}