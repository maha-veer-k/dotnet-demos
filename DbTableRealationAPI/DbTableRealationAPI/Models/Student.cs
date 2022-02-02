namespace DbTableRealationAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }

        public Classroom classroom { get;}

        public ICollection<Course> courses { get; set; }
    }
}
