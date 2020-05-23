

namespace TestDAL.Models
{
    public partial class Visits
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
        public virtual Employees Employee { get; set; }
    }
}
