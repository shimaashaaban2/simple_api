using System.ComponentModel.DataAnnotations.Schema;

namespace Student_API.Models
{
    public class Student
    {

        public int  Id { get; set; }

        public string Name { get; set; }

        public string DeptName { get; set; }

        
        public virtual int DeptNo { get; set; }

          
    }
}
