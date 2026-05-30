using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Vehicle : BaseEntity
    {
        public Guid VehicleId { get; set; }
        public Guid VehicleModelId { get; set; }
        public Guid ProfileId { get; set; }
        public string? Color { get; set; }
        public string ClassisNumber { get; set; } = string.Empty;
        public string EngineNumber { get; set; } = string.Empty;
        public string LicensePlateNUmber { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; }
        public DateTime WarrantyStartDate { get; set; }
        public DateTime WarrantyEndDate { get; set; }
        public StatusEnum Status { get; set; }
    }
}