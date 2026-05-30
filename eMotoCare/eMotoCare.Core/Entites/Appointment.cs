using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Appointment : BaseEntity
    {
        public Guid AppointmentId { get; set; }
        public string AppointmentCode { get; set; } = string.Empty;
        public Guid VehicleStageId { get; set; }
        public string ProfileCode { get; set; }
        public string VehicleCode { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string SlotTime { get; set; }
        public string ServiceCenterCode { get; set; }
        public string StaffCode { get; set; }
        public AppointmentStatusEnum AppointmentStatus { get; set; }

        public Appointment()
        {

        }

        public Appointment(string appointmentCode,
                            Guid vehicleStageId,
                            string profileCode,
                            string vehicleCode,
                            DateTime appointmentDate,
                            string slotTime,
                            string serviceCenterCode,
                            string staffCode,
                            AppointmentStatusEnum appointmentStatus
                            )
        {
            AppointmentId = Guid.NewGuid();
            AppointmentCode = appointmentCode;
            VehicleStageId = vehicleStageId;
            ProfileCode = profileCode;
            VehicleCode = vehicleCode;
            AppointmentDate = appointmentDate;
            SlotTime = slotTime;
            ServiceCenterCode = serviceCenterCode;
            StaffCode = staffCode;
            AppointmentStatus = appointmentStatus;
        }
    }
}