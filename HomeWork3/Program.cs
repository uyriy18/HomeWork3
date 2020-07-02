using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        public class Student
        {
            private new int[][] marksArray;
            private string name;
            private string surname;
            private string fathername;
            private string group;
            private int age;
            public void arrayInizialization(int[] adm, int[] prog, int[] disign)
            {
                marksArray = new int[3][] { adm, prog, disign };
            }
            public void setName(string name)
            {
                    if (name.Trim() == "") throw new ArgumentException("Name's field can't be empty");
                    this.name = name;
              
            }
            public string getName()
            {
                return name;
            }
            public void setSurname(string surname)
            {
                if (surname.Trim() == "") throw new ArgumentException("Surname's field can't be empty");
                this.surname = surname;
            }
            public string getsurName()
            {
                return surname;
            }
            public void setFathername(string fathername)
            {
                if (fathername.Trim() == "") throw new ArgumentException("Fathername's field can't be empty");
                this.fathername = fathername;
            }
            public string getfathername()
            {
                return fathername;
            }
            public void setGroup(string group)
            {
                if (group.Trim() == "") throw new ArgumentException("Group's field can't be empty");
                this.group = group;
            }
            public string getGroup()
            {
                return group;
            }
            public void setAge(int age)
            {
                this.age = age;
            }
            public int getAge()
            {
                return age;
            }

          
             public void printMarks()
            {
                Console.WriteLine("Admin marks:");
                foreach (int i in marksArray[0]) 
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\nProgram marks:");
                foreach (int i in marksArray[1])
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\nDisign marks:");
                foreach (int i in marksArray[2])
                {
                    Console.Write(i + " ");
                }
            }

        }
        static void Main(string[] args)
        {
            bool check = false;
            Student st1 = new Student();
            Console.WriteLine("Enter studen's name: ");
            st1.setName(Console.ReadLine());
            Console.WriteLine("Enter studen's surname: ");
            st1.setSurname(Console.ReadLine());
            Console.WriteLine("Enter studen's fathername: ");
            st1.setFathername(Console.ReadLine());
            Console.WriteLine("Enter studen's age(digits): ");
            while (!check)
            {
                try
                {
                    st1.setAge(int.Parse(Console.ReadLine()));
                    check = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "\nIncorrect format, try again");
                }
            }
           
            Console.WriteLine("Enter studen's group: ");
            st1.setGroup(Console.ReadLine());
            st1.arrayInizialization(new int[] { 1, 2, 3, 4, 5 },new int[] { 1, 2, 3, 4, 5, 6, 7, 8},new int[] { 1, 2, 3, 4});
            Console.WriteLine("Studen's name: " + st1.getName() + "\nStudents surname: " + st1.getsurName() + "\nStudents fathername: " + st1.getfathername() + "\nstudent's age:" + st1.getAge() + "\nStudents group: " + st1.getGroup());
            st1.printMarks();
            Console.WriteLine();
        }
    } 
    
}
