using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;

namespace eMotoCare.Core.Entites
{
    public class ImportNoteDetail : BaseEntity
    {
        public Guid ImportNoteDetailId { get; set; }
        public Guid ImportNoteId { get; set; }
        public Guid PartItemId { get; set; }
        public int Quantity { get; set; }
    }
}