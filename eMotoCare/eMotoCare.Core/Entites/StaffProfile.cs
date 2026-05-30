using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class StaffProfile
    {
        public Guid StaffProfileId { get; set; }
        public Guid ProfileId { get; set; }
        public string StaffCode { get; set; } = string.Empty;
        public Guid ServiceCenterId { get; set; }
        public PositionStaff Position { get; set; }
    }
}