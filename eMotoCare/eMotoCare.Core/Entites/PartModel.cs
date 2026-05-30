using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class PartModel : BaseEntity
    {
        public Guid PartModelId { get; set; }
        public Guid PartId { get; set; }
        public Guid VehicleModelId { get; set; }
        public bool IsWarranty { get; set; }
        public UnitWarrntyEnum UnitWarrnty { get; set; }
        public StatusEnum Status { get; set; }
    }
}