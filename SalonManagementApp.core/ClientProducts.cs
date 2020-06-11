using System;
using System.Collections.Generic;
using System.Text;

namespace SalonManagementApp.core
{
    class ClientProducts
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Products Product { get; set; }
        public DateTime DatePurchased { get; set; }
        public int Quantity { get; set; }
    }
}
