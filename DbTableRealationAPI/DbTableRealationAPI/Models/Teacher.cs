namespace DbTableRealationAPI.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public int ClassroomId { get; set; }    

        public Classroom classroom { get; set; }
    }
}
