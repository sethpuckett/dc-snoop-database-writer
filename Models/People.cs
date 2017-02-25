using System;
using System.Collections.Generic;

namespace dc_snoop_database_writer.Models
{
    public partial class People
    {
        public int Id { get; set; }
        public string Affiliation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Status1211 { get; set; }
        public string Status1304 { get; set; }
        public string Status1404 { get; set; }
        public string Status1407 { get; set; }
        public string Status1411 { get; set; }
        public string Status1504 { get; set; }
        public string Unit { get; set; }
        
        public int AddressId { get; set; }
        
        public virtual Addresses Address { get; set; }
    }
}
