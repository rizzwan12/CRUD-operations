using System.ComponentModel.DataAnnotations;

namespace CRUD.Model
{
    public class User
    {
        
     [Key]   public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Place { get; set; }
    }
}
