using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class PartType : BaseEntity
    {
        public Guid PartTypeId { get; set; }
        public string? PartTypeName { get; set; }
        public StatusEnum Status { get; set; }
        public string PartTypeCode { get; set; } = string.Empty;
    }
}