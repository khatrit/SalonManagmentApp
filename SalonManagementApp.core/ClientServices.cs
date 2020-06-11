using System;
using System.Collections.Generic;
using System.Text;

namespace SalonManagementApp.core
{
    class ClientServices
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public DateTime DateOfService { get; set; }
        public Services Service { get; set; }
    }
}
