using System;
using System.Collections.Generic;

namespace PractiseProject4
{
    public class Program
    {
        static void AddStudents(List<Students> studentS)
        {
            char option;
            do
            {
                Console.WriteLine("Enter Students Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Students Class");
                int clasS = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Students Class Section(Characters Only Eg..A)");
                char Sec = char.Parse(Console.ReadLine());
                var students = new Students { Name = name, Class = clasS, Section = Sec };
                studentS.Add(students);
                Console.WriteLine("Do you Want to Add one more Student Data ? Y/N");
                option = char.Parse(Console.ReadLine().ToLower());
            } while (option=='Y' || option=='y');

        }
        static void DisplayStudentData(List<Students> studentS)
        {
            Console.WriteLine("**********************************************************");
            foreach (var student in studentS)
            {
                Console.WriteLine("Student Name is    : " + student.Name);
                Console.WriteLine("Student class is   : " + student.Class);
                Console.WriteLine("Student Section is : " + student.Section);

            }
            Console.WriteLine("**********************************************************");
        }
        static void DisplayClassData(List<Students> studentS,int clasS)
        {
            Console.WriteLine($"Displaying student Data in the {clasS}th class");
            foreach (var student in studentS)
            {
                if (student.Class==clasS)
                {
                    Console.WriteLine($"{student.Name} is a {clasS}th Student");
                }
            }
        }

        static void AddTeachers(List<Teachers> teachers)
        {
            char option;
            do
            {
                Console.WriteLine("Enter Teacher Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Teacher Class");
                int clasS = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Teacher Class Section (Characters Only Eg..A)");
                char Sec = char.Parse(Console.ReadLine());
                var teacher = new Teachers { Name = name, Class = clasS, Section = Sec };
                teachers.Add(teacher);
                Console.WriteLine("Do you Want to Add one more Teacher Data ? Y/N");
                option = char.Parse(Console.ReadLine().ToLower());
            } while (option == 'Y' || option == 'y');

        }
        static void DisplayTeachersData(List<Teachers> teachers)
        {
            Console.WriteLine("**********************************************************");
            foreach (var teacher in teachers)
            {
                Console.WriteLine("Teacher Name is    : " + teacher.Name);
                Console.WriteLine("Teacher class is   : " + teacher.Class);
                Console.WriteLine("Teacher Section is : " + teacher.Section);

            }
            Console.WriteLine("**********************************************************");
        }

        static void AddSubjects(List<Subjects> subjectS)
        {
            char option;
            do
            {
                Console.WriteLine("Enter Subject Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Subject Code (Characters Only Eg..A)");
                char SubCode = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter Teacher Name");
                string teacher = Console.ReadLine();
                var subjects = new Subjects { SubjectName = name, SubjectCode = SubCode, Teacher = teacher };
                subjectS.Add(subjects);
                Console.WriteLine("Do you Want to Add one more Subject Data ? Y/N");
                option = char.Parse(Console.ReadLine().ToLower());
            } while (option == 'Y' || option == 'y');

        }
        static void DisplaySubjectsTaughtNyTeacher(List<Subjects> subjectS, string teacher)
        {
            Console.WriteLine($"{teacher} teaches the following Subjects");
            foreach (var subject in subjectS)
            {
                if (subject.Teacher == teacher)
                {
                    Console.WriteLine(subject.SubjectName);
                }
            }
        }
        static void DisplaySubjectsData(List<Subjects> subjects)
        {
            Console.WriteLine("**********************************************************");
            foreach (var subject in subjects)
            {
                Console.WriteLine("Subject Name is           : " + subject.SubjectName);
                Console.WriteLine("Subject Code is           : " + subject.SubjectCode);
                Console.WriteLine("Subject's Teacher Name is : " + subject.Teacher);

            }
            Console.WriteLine("**********************************************************");
        }
        static void Main(string[] args)
        {
            var student1 = new Students
            {
                Name = "Nepolean",
                Class = 9,
                Section = 'A',
            };
            var student2 = new Students
            {
                Name = "Tina",
                Class = 9,
                Section = 'A',
            };
            var student3 = new Students
            {
                Name = "Anbu Das",
                Class = 10,
                Section = 'B',
            };
            var student4 = new Students
            {
                Name = "Vijaya Shankar",
                Class = 10,
                Section = 'B',
            };
            var student5 = new Students
            {
                Name = "Elsa",
                
            };
            var student6 = new Students
            {
                Name = "Subramani",
                Class = 10,
                Section = 'A',
            };
            var student7 = new Students
            {
                Name = "Sundeep",
                Class = 8,
                Section = 'A',
            };
            var students = new List<Students>()
            {
                student1,
                student2,
                student3,
                student4,
                student5,
                student6,
                student7
            };


            var teacher1 = new Teachers
            {
                Name = "Vikram",
                Class = 9,
                Section = 'A',
            };
            var teacher2 = new Teachers
            {
                Name = "Rolex",
                Class = 10,
                Section = 'B',
            };
            var teacher3 = new Teachers
            {
                Name = "Leo",
                Class = 10,
                Section = 'A',
            };
            var teachers = new List<Teachers>
            {
                teacher1,
                teacher2,
                teacher3
            };

            var subject1 = new Subjects
            {
                SubjectName = "Chemistry",
                SubjectCode = 'C',
                Teacher= "Rolex"
            };
            var subject2 = new Subjects
            {
                SubjectName = "Maths",
                SubjectCode = 'M',
                Teacher = "Vikram"
            };
            var subject3 = new Subjects
            {
                SubjectName = "Zoology",
                SubjectCode = 'Z',
                Teacher = "Leo"
            };
            var subject4 = new Subjects
            {
                SubjectName = "Pysics",
                SubjectCode = 'P',
                Teacher = "Rolex"
            };
            var subject5 = new Subjects
            {
                SubjectName = "Hindhi",
                SubjectCode = 'H',
                Teacher = "Leo"
            };
            var subject6 = new Subjects
            {
                SubjectName = "Social",
                SubjectCode = 'H',
                Teacher = "Vikram"
            };

            var subjects = new List<Subjects>
            {
                subject1,
                subject2,
                subject3,
                subject4,
                subject5,
                subject6
                
            };
            Console.WriteLine("Choose Which of the Following Data You Want to Access \n1.Students \n2.Teachers \n3.Subjects");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("Choose which Operation You Want to perform on Students Data \n1.Add New Student Data \n2.Display All Students Data\n3.Students Data in a Particular Class \n4.All Operations");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddStudents(students);
                        break;
                    case 2:
                        DisplayStudentData(students);
                        break;
                    case 3:
                        Console.WriteLine("We have 10,9,8 classes");
                        Console.WriteLine("Which Class Student data You Want Please Enter ");
                        int x = int.Parse(Console.ReadLine());
                        DisplayClassData(students, x);
                        break;
                    case 4:
                        AddStudents(students);
                        DisplayStudentData(students);
                        Console.WriteLine("We have 10,9,8 classes");
                        Console.WriteLine("Which Class Student data You Want Please Enter ");
                        int y = int.Parse(Console.ReadLine());
                        DisplayClassData(students, y);
                        break;
                    default:
                        Console.WriteLine("Inalid Operation !!!");
                        break;
                }
            }
            else if (op == 2)
            {
                Console.WriteLine("Choose which Operation You Want to perform on Teachers Data \n1.Add New Teachers Data \n2.Display Students Data\n3.All Operations");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddTeachers(teachers);
                        break;
                    case 2:
                        DisplayTeachersData(teachers);
                        break;
                    case 3:
                        AddTeachers(teachers);
                        DisplayTeachersData(teachers);
                        break;
                    default:
                        Console.WriteLine("Inalid Operation !!!");
                        break;
                }
            }
            else if (op == 3)
            {
                Console.WriteLine("Choose which Operation You Want to perform on Teachers Data \n1.Add New Subject Data \n2.Display Subjects Data \n3.Teacher Who taughts the Subjects \n4.All Operations");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddSubjects(subjects);
                        break;
                    case 2:
                        DisplaySubjectsData(subjects);
                        break;
                    case 3:
                        Console.WriteLine("We have three Teachers\n1.Vikram \n2.Leo \n3.Rolex  \nEnter one Teacher Name to Know Which subjects he teches");
                        string name = Console.ReadLine();
                        DisplaySubjectsTaughtNyTeacher(subjects, name);
                        break;
                    case 4:
                        AddSubjects(subjects);
                        DisplaySubjectsData(subjects);
                        Console.WriteLine("We have three Teachers\n1.Vikram \n2.Leo \n3.Rolex  \nEnter one Teacher Name to Know Which subjects he teaches");
                        string name1 = Console.ReadLine();
                        DisplaySubjectsTaughtNyTeacher(subjects, name1);
                        break;
                    default:
                        Console.WriteLine("Inalid Operation !!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }
          
            Console.ReadKey();
        }
        
       
    }
}
