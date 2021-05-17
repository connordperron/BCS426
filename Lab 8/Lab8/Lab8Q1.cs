using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8Q1
{

    class Student : IComparable<Student>, IFormattable
    {


        public Student(int id, string name, string status, string state)
        {
            Id = id;
            Name = name;
            Status = status;
            State = state;
        }

        public Student(int id,  string status, string state)
        {
            Id = id;
            Name = "NO NAME";
            Status = status;
            State = state;
        }

        public int Id { get; }
        public string Name { get; }
        public string Status { get; }

        public string State { get; }

        public override string ToString() => $"Name: {Name}";



       public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "A";
            switch (format.ToUpper())
            {
                case null:
                case "Name": // name
                    return ToString();
                case "Id": // id
                    return $"{ToString()}, ID: {Id}";
                case "Status": // status
                    return $"{ToString()}, Status: {Status}";
                case "State": // State
                    return $"{ToString()}, State: {State}";
                case "A": // All
                    return $"{ToString()} | ID: {Id} | Status: {Status} | State: {State}";
                default:
                    throw new FormatException(String.Format(formatProvider,
                          "Format {0} is not supported", format));
            }
        } 

        public string ToString(string format) => ToString(format, null);

        public int CompareTo(Student other)
        {
            if (other == null) return -1;
            int compare = string.Compare(Status, other.Status);
            if (compare == 0)
                return string.Compare(Name, other.Name);
            return compare;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            students.Add(new Student(id:2000, name:"Mike Smith", status:"Freshman", state:"NY"));
            students.Add(new Student(id:4444, name:"Alice Smith", status:"Sophmore", state:"NC"));
            students.Add(new Student(id:2002, name:"Tom Brown", status:"Freshman", state:"NY"));
            students.Add(new Student(id:3000, name:"Sarah Smith", status:"Senior", state:"NY"));
            students.Add(new Student(id:4004, status:"Junior", state:"NJ"));
            students.Add(new Student(id:1000, status:"Freshman", state:"NJ"));

            var lookupStudent = students.ToLookup(s => s.Status);

            Console.WriteLine("Students with Freshman Status:");
            foreach(Student s in lookupStudent["Freshman"])
            {
                Console.WriteLine(s);
            }

            lookupStudent = students.ToLookup(s => s.State);

            Console.WriteLine("Students from New York:");
            foreach (Student s in lookupStudent["NY"])
            {
                Console.WriteLine(s);
            }

        }
    }
}
