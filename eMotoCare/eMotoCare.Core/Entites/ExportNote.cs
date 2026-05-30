using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class ExportNote : BaseEntity
    {
        public Guid ExportNoteId { get; set; }
        public Guid CreatedBy { get; set; } // staff
        public Guid? ExportFrom { get; set; } // service center
        public Guid? ExportTo { get; set; } // service center
        public string ExportNoteCode { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public ExportNoteType ExportType { get; set; }
        public DateTime ExportDate { get; set; }
        public int TotalQuantityPart { get; set; }
    }
}
