using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class EVCheckDetail : BaseEntity
    {
        public Guid EVCheckDetaikId { get; set; }
        public Guid EVCheckId { get; set; }
        public Guid VehiclePartItem { get; set; }
        public ActionTypeEnum ActionType { get; set; }
        public string? Result { get; set; }
        public SolutionEnum Solution { get; set; }
        public string? IamgeResult { get; set; }
        public Guid? PartItemReplacement { get; set; }
        public decimal? PartPrice { get; set; }
        public Guid? ServicePriceId { get; set; }
        public decimal? TotalPrice { get; set; }
        public EVCheckDetailStatus Status { get; set; }
    }
}