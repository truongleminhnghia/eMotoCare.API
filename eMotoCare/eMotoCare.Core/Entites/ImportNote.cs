using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class ImportNote : BaseEntity
    {
        public Guid ImportNoteId { get; set; }

        /// <summary>
        /// To Service Center
        /// </summary>
        public Guid? ImportTo { get; set; }

        /// <summary>
        /// From Service Center
        /// </summary>
        public Guid? ImportFrom { get; set; }

        /// <summary>
        /// Staff Created ImportNote
        /// </summary>
        public Guid CreatedBy { get; set; }

        public string ImportNoteCode { get; set; } = string.Empty;
        public ImportTypeEnum ImportType { get; set; }
        public DateTime ImportDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalPart { get; set; }
        public StatusEnum ImportNoteStatus { get; set; }
    }
}