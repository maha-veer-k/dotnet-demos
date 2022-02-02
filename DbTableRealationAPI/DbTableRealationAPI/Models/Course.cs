namespace DbTableRealationAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        public ICollection<Student> students { get; set; }
    }
}
