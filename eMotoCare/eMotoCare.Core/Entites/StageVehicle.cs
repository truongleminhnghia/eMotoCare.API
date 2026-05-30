using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class StageVehicle : BaseEntity
    {
        public Guid StageVehicleId { get; set; }
        public Guid VehicleId { get; set; }
        public Guid MaintenaceStageId { get; set; }

        public VehicleStageStatus VehicleStageStatus { get; set; }

        /// <summary>
        /// Ngày dự kiến
        /// </summary>
        public DateTime ExpectedDate { get; set; }

        /// <summary>
        /// Ngày dự kiến kết thức
        /// </summary>
        public DateTime ExpectedEndDate { get; set; }

        /// <summary>
        /// Ngày thực tế làm
        /// </summary>
        public DateTime ActualExecutionDate { get; set; }
    }
}