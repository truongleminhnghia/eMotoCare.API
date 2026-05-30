using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class EVCheck : BaseEntity
    {
        public Guid EVCheckId { get; set; }
        public Guid AppointmentId { get; set; }
        public string? EVCheckCode { get; set; }

        /// <summary>
        /// Người thực hiện technician
        /// </summary>
        public Guid? ExecutedBy { get; set; }
        public DateTime CheckDate { get; set; }
        public EVCheckStauts Status { get; set; }
        public string? Note { get; set; }
        public decimal? TotalAmount { get; set; }

        public EVCheck()
        {

        }

        public EVCheck(Guid appointmentId,
                            Guid? executedBy,
                            DateTime checkDate,
                            EVCheckStauts status,
                            string EVCheckCode,
                            string? note,
                            decimal? totalAmount)
        {
            EVCheckId = Guid.NewGuid();
            AppointmentId = appointmentId;
            ExecutedBy = executedBy;
            CheckDate = checkDate;
            Status = status;
            Note = note;
            TotalAmount = totalAmount;
        }
    }
}