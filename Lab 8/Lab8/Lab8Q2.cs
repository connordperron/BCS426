using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8Q2
{

    class Student : IComparable<Student>, IFormattable
    {

        
        public Student(string name, string status, string state)
        {
            Name = name;
            Status = status;
            State = state;
        }

        public Student(string status, string state)
        {
            Name = "NO NAME";
            Status = status;
            State = state;
        }
        public override int GetHashCode()
        {
            return ID;
        }

        public int Id { get; }
        public string Name { get; }
        public string Status { get; }

        public string State { get; }
        public int ID { get; set; }

        public override string ToString() => $"Name: {Name} | Status: {Status} | State: {State}";



        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "A";
            switch (format.ToUpper())
            {
                case null:
                case "Name": // name
                    return $"Name: {Name}";
                case "Id": // id
                    return $"{ToString()}, ID: {Id}";
                case "Status": // status
                    return $"{ToString()}, Status: {Status}";
                case "State": // State
                    return $"{ToString()}, State: {State}";
                case "A": // All
                    return ToString();
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
            var students = new SortedList<int, Student>();

            students[2000] = new Student(name:"Mike Smith",status:"Freshman",state:"NY");
            students[4444] = new Student(name: "Alice Smith", status: "Sophmore", state: "NC");
            students[2002] = new Student(name: "Tom Brown", status: "Freshman", state: "NY");
            students[3000] = new Student(name: "Sarah Smith", status: "Senior", state: "NY");
            students[4004] = new Student(status: "Junior", state: "NJ");
            students[1000] = new Student(status: "Freshman", state: "NJ");

            Console.WriteLine("Students sorted by ID:");
            foreach (int id in students.Keys)
            {
                Console.WriteLine("ID:" + id + " | " + students[id]);
            }

            Console.WriteLine("What student ID would you like to search for?");
            int searchFor = Convert.ToInt32(Console.ReadLine());

            if (students.ContainsKey(searchFor))
            {
                Console.WriteLine("ID:" + searchFor + " | " + students[searchFor]);
            }
            else
            {
                Console.WriteLine("Sorry, but a student with ID:" + searchFor + " does not exist. \nPlease enter another ID and try again. \n \n");
                Main(args);
            }

        }
    }
}
