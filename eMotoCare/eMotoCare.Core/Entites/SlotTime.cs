using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class SlotTime : BaseEntity
    {
        public Guid SlotTimeId { get; set; }
        public Guid ServiceCenterId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public StatusEnum Status { get; set; }
        public Guid CreateBy { get; set; }
        public Guid? LastEditBy { get; set; }
    }
}