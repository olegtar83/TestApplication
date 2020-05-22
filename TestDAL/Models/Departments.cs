using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Visits = new HashSet<Visits>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Visits> Visits { get; set; }
    }
}
