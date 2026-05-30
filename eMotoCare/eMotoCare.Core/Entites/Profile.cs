using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMotoCare.Core.Commons.Bases;
using eMotoCare.Core.Enums;

namespace eMotoCare.Core.Entites
{
    public class Profile : BaseEntity
    {
        public Guid ProfileId { get; set; }
        public string ProfileCode { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ProfileTypeEnum ProfileType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Guid AddressId { get; set; }
        public StatusEnum Status { get; set; }
    }
}