using System;
using System.Threading;

namespace Lab7
{
    public enum Status { FRESHMAN, SOPHMORE, JUNIOR, SENIOR };
    public class Student
    {
        private string _name;
        private DateTime _dateOfBirth;
        private string _major;
        private Status _status;
        private bool _registered;

        public Student(string name, DateTime dateOfBirth, string major, Status status)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
            _major = major;
            _status = status;
            _registered = false;
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Major { get; set; }
        public Status status { get; set; }
        public bool Registered { get; set; }

        public void Register()
        {
            _registered = true;
        }

        public override string ToString()
        {
            return "Student Name: "+_name+" \t Date of Birth: "+_dateOfBirth+ " \t Major: "+_major+" \t Status: "+_status+ " \t Registered: "+_registered;
        }

        public void NewStudentArrived(object sender, StudentArrived e) =>
          Console.WriteLine($"{_name}: student {e.Student} is new");
    }

    public class StudentArrived : EventArgs
    {
        public StudentArrived(Student student) => Student = student;
        public Student Student { get; }
    }

    public class Registrar
    {
        private Student[] _studentList;
        public event EventHandler<StudentArrived> NewStudentInfo;
        private static int numberOfStudents = 0;

        public Registrar(Student[] studentList)
        {
            _studentList = studentList;
        }

        public void NewStudent(Student student)
        {
            student.Register();
            _studentList[numberOfStudents] = student;

            Console.WriteLine($"Registrar, new student {student}");

            NewStudentInfo?.Invoke(this, new StudentArrived(student));

            numberOfStudents++;


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentList = new Student[100];
            var registrar = new Registrar(studentList);
            Random rnd = new Random();


            var dob = new DateTime(2001, 7, 11);
            Student s1 = new Student("Connor Perron", dob, "CPIS", Status.JUNIOR);

            dob = new DateTime(2002, 10, 10);
            Student s2 = new Student("Student Person", dob, "Liberal Arts", Status.FRESHMAN);

            dob = new DateTime(2001, 11, 13);
            Student s3 = new Student("Name Nameson",dob, "Dentistry", Status.SOPHMORE);


        

            Console.WriteLine(s1);
            registrar.NewStudent(s1);
            Thread.Sleep(rnd.Next(100, 3000));

            Console.WriteLine(s2);
            registrar.NewStudent(s2);
            Thread.Sleep(rnd.Next(100, 3000));

            Console.WriteLine(s2);
            registrar.NewStudent(s3);
           

        }
    }
}
