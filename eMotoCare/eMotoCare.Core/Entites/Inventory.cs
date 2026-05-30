using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;

namespace eMotoCare.Core.Entites
{
    public class Inventory : BaseEntity
    {
        public Guid InventoryId { get; set; }
        public string InventoryCode { get; set; } = string.Empty;
        public Guid ServiceCenterId { get; set; }
        public Guid AddressId { get; set; }

        /// <summary>
        /// Quản lý kho
        /// </summary>
        public Guid InventoryManager { get; set; }
    }
}