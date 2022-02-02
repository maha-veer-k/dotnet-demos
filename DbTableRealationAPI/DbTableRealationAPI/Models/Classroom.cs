namespace DbTableRealationAPI.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public ICollection<Student>  students { get; set; }
        public Teacher teacher { get; set; }
    }
}
