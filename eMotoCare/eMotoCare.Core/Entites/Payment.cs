using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Payment : BaseEntity
    {
        public Guid PayemntId { get; set; }
        public Guid AppointmentId { get; set; }
        public string PaymentCode { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string? TransactionReference { get; set; }
        public DateTime PaymentTime { get; set; }
        public string? Currency { get; set; }
        public string? Note { get; set; }
        public string? AttachmentUrl { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? TotalPaidAmount { get; set; }
        public decimal? RemainingAmount { get; set; }
    }
}