namespace WebApplication3.Models
{
    public interface IStudent
    {
        public List<Student> getAllStudents();
        public void addStudent(Student std);
        public Student findStudent(int id);
        public void editStudent(Student std);
        public void deleteStudent(int id);
    }

}
