using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Part : BaseEntity
    {
        public Guid PartId { get; set; }
        public Guid PartTypeId { get; set; }
        public string? PartName { get; set; }
        public string PartCode { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public decimal CostPrice { get; set; }
        public bool IsWarranty { get; set; }
        public int WarrantyPeriod { get; set; }
        public UnitWarrntyEnum UnitWarrnty { get; set; }
        public StatusEnum Status { get; set; }
        public string? ImageUrl { get; set; }
    }
}