using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamJunction.Entities
{
    public class InvestorDetail
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PAN { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public bool IsLocked{ get; set; }
        public bool IsActive { get; set; }
        public string Token { get; set; }
        public int OTP { get; set; }
        public bool IsUsedOTP { get; set; }
        public bool IsVerifiedMobile { get; set; }
        public bool IsVerifiedEmail { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
