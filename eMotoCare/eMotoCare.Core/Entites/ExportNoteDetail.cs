using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;

namespace eMotoCare.Core.Entites
{
    public class ExportNoteDetail : BaseEntity
    {
        public Guid ExpotNoteDetailId { get; set; }
        public Guid ExportNoteId { get; set; }
        public Guid PartItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}