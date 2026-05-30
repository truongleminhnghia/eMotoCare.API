using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class RMADetail : BaseEntity
    {
        public Guid RMADetailId { get; set; }
        public Guid RMAId { get; set; }
        public Guid VehiclePartItemId { get; set; }

        /// <summary>
        /// EVCheckDetail
        /// </summary>
        public Guid ReferenceSource { get; set; }

        public RMADetailStatusEnum Status { get; set; }
        public string? IssueDescription { get; set; }
        public string? InspectionResult { get; set; }
        public WarrantyDecision? Decision { get; set; }
    }
}