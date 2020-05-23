using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Visits = new HashSet<Visits>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Visits> Visits { get; set; }
    }
}
