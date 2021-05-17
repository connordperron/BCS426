using System;
using System.Collections;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            var list1 = new LinkedList();

            list1.AddFirst(100);
            list1.AddFirst(200);
            list1.AddFirst(300);

            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            var list2 = new LinkedList();

            list2.AddFirst("One");
            list2.AddFirst("Two");
            list2.AddFirst("Three");

            foreach (String i in list2)
            {
                Console.WriteLine(i);
            }


            var list3 = new LinkedList();


            Person p1 = new Person("Alex", "Auburn");
            Person p2 = new Person("Bob", "Brown");
            Person p3 = new Person("Chuck", "Chimney");
            list3.AddFirst(p1);
            list3.AddFirst(p2);
            list3.AddFirst(p3);

            foreach (Person i in list3)
            {
                Console.WriteLine(i);
            }


        }
    }

    public class LinkedList : IEnumerable
    {
        public LinkedListNode First { get; private set; }
        public LinkedListNode Last { get; private set; }

        public LinkedListNode AddLast(object node)
        {
            var newNode = new LinkedListNode(node);
            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                newNode.Prev = Last;
                Last.Next = newNode;
                Last = newNode;
            }
            return newNode;
        }

        public LinkedListNode AddFirst(object node)
        {
            var newNode = new LinkedListNode(node);
            if (Last == null)
            {
                Last = newNode;
                First = Last;
            }
            else
            {
                newNode.Next = First;
                First.Prev = newNode;
                First = newNode;
            }
            return newNode;
        }

        public IEnumerator GetEnumerator()
        {
            LinkedListNode current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }




    }

    public class LinkedListNode
    {
        public LinkedListNode(object value) => Value = value;

        public object Value { get; }

        public LinkedListNode Next { get; internal set; }
        public LinkedListNode Prev { get; internal set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string f = "none", string l = "none")
        {
            FirstName = f;
            LastName = l;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }

}
