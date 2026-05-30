using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class RMA : BaseEntity
    {
        public Guid RMAId { get; set; }
        public string RMACode { get; set; } = string.Empty;
        public Guid ProfileId { get; set; }
        public Guid VehicleId { get; set; }
        public Guid CreateBy { get; set; }
        public Guid ApprovedBy { get; set; }
        public RMAStatuEnum Status { get; set; }
    }
}