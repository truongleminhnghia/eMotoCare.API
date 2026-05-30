using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class VehicleModel : BaseEntity
    {
        public Guid VehicleModelId { get; set; }
        public Guid MaintenancePlanId { get; set; }
        public string ModelCode { get; set; } = string.Empty;
        public string? ModelName { get; set; }
        public List<string> Colors { get; set; } = [];
        public BatteryType? BatteryType { get; set; }

        /// <summary>
        /// Thời gian sạc tiêu chuẩn (giờ)
        /// </summary>
        public decimal StandardChargingTime { get; set; }

        /// <summary>
        /// Loại động cơ
        /// </summary>
        public MotorType MotorType { get; set; }

        /// <summary>
        /// Công suất tối đa (W)
        /// </summary>
        public decimal MaximumPower { get; set; }

        /// <summary>
        /// Giảm xóc
        /// </summary>
        public string ShockAbsorbers { get; set; } = string.Empty;

        /// <summary>
        /// Dung lượng pin (kWh)
        /// </summary>
        public decimal BatteryCapacity { get; set; }

        /// <summary>
        /// Tốc độ tối đa (km/h)
        /// </summary>
        public decimal MaximumSpeed { get; set; }

        /// <summary>
        /// Quãng đường đi được mỗi lần sạc (km)
        /// </summary>
        public decimal RangePerCharge { get; set; }

        /// <summary>
        /// Trọng lượng (kg)
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Dài (mm)
        /// </summary>
        public decimal Length { get; set; }

        /// <summary>
        /// Rộng (mm)
        /// </summary>
        public decimal Width { get; set; }

        /// <summary>
        /// Cao (mm)
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// Phanh trước
        /// </summary>
        public string FrontBrakes { get; set; } = string.Empty;

        /// <summary>
        /// Phanh sau
        /// </summary>
        public string RearBrakes { get; set; } = string.Empty;

        /// <summary>
        /// Thời gian bảo hành (tháng)
        /// </summary>
        public int WarrantyPeriod { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public StatusEnum Status { get; set; }
    }
}