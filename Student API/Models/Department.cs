using System.ComponentModel.DataAnnotations.Schema;

namespace Student_API.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string Capacity { get; set; }

        
        public int DeptNo { get; set; }
    }
}
