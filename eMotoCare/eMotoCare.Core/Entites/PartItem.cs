using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class PartItem : BaseEntity
    {
        public Guid PartItemId { get; set; }
        public Guid PartId { get; set; }
        public string? SerialNumber { get; set; }
        public PartItemStatus PartItemStatus { get; set; }
        public int Quantity { get; set; }
        public Guid InvetoryId { get; set; }
    }
}