using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class ServiceCenter : BaseEntity
    {
        public Guid ServiceCenterId { get; set; }
        public string ServiceCenterCode { get; set; } = string.Empty;
        public string? ServiceCenterName { get; set; }
        public Guid AddressId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public StatusEnum Status { get; set; }
        public Guid CreatedBy { get; set; }
    }
}