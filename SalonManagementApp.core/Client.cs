using System;
using System.Collections.Generic;
using System.Text;

namespace SalonManagementApp.core
{
    class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public DateTime DOB { get; set; }
        public DateTime Anniversary { get; set; }
        public string InstaUserId { get; set; }
        public string FBUserId { get; set; }
        public string TwitterHandle { get; set; }
        public bool IsActive { get; set; }
    }
}
