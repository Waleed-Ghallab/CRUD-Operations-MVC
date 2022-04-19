namespace WebApplication3.Models
{
    public class StudentMoc:IStudent
    {
        static public List<Student> students = new List<Student>()
        {
            new Student() { id = 1, userName="mosalah",name = "waleed", age = 22 },
            new Student() { id = 2, userName="elneny",name = "3antar", age = 22 },
            new Student() { id = 3, userName="zizo",name = "shaimaa", age = 22 },
            new Student() { id = 4, userName="shenawy",name = "gom3a", age = 22 }

        };
        public List<Student> getAllStudents()
        {
            return students;
        }
        public void addStudent(Student std)
        {
            students.Add(std);
        }
        public Student findStudent(int id)
        {
            return students.FirstOrDefault(i => i.id == id);
        }
        public void editStudent(Student std)
        {
            Student old=students.FirstOrDefault(i => i.id == std.id);
            if (old == null)
            {
                return ;
            }
            else
            {
                old.id = std.id;
                old.name=std.name;
                old.age = std.age;
            }
        }
        public void deleteStudent(int id)
        {
            Student student = students.FirstOrDefault(i => i.id == id);
            if(student == null)
            {
                return;
            }
            else
            {
                students.Remove(student);
            }
        }
    }
}
