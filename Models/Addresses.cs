using System;
using System.Collections.Generic;

namespace dc_snoop_database_writer.Models
{
    public partial class Addresses
    {
        public int Id { get; set; }
        public string Precinct { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}
