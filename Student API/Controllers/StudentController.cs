using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_API.Models;


namespace Student_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly APPDbContext _db;
        public StudentController(APPDbContext db) 
        {
            _db = db;
        }
        [HttpGet]
        // [Route("{id}")]
        public ActionResult <List<Student>> GetAll()
        {
            return _db.Student.ToList();
        }
        [HttpGet("{id}")]
       // [HttpGet("{id:int}")]
        public ActionResult <Student> GetById(int id)
        {
            Student s=_db.Student.Find(id);
            if (s == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(s);
            }
           
        }
        [HttpGet("/api/stud/{name}")]
        //[HttpPost("{name:alpha}")]
        public ActionResult <Student> GetByName(string name) 
        {
            return _db.Student.Where(n=>n.Name==name).FirstOrDefault();
        }
        [HttpPost]
        public ActionResult AddStudent(Student s)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _db.Student.Add(s);
                    _db.SaveChanges();
                    return Created("url",s);
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else 
            {
                return BadRequest();
            }
            
        }
        [HttpPut]

        public ActionResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _db.Entry(s).State = EntityState.Modified;
                    _db.SaveChanges();
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else { return BadRequest(); }
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Student s = _db.Student.Find(id);
            if (s == null) { return NotFound(); }
           else 
            {
                _db.Remove(s);
                _db.SaveChanges();
                return Ok(s);
            }
        }
    }

}
 