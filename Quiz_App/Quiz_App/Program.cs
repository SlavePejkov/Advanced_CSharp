using Modules;

namespace Quiz_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teachers = new List<Teacher>();
            List<Students> students = new List<Students>();

            Teacher teacher1 = new Teacher("Marko", "Markovski", "teacherOne321", "teach1234");
            Teacher teacher2 = new Teacher("Todor", "Todorovski", "teacherTwo321", "TT456");
            Teacher teacher3 = new Teacher("Ilija", "Stojanovski", "teacherThree321", "Teach34");
            Teacher teacher4 = new Teacher("Teo", "Teovski", "teacherFour321", "password");

            Students student1 = new Students("Slave", "Pejkov", "studentOne123", "st1234");
            Students student2 = new Students("Risto", "Panchevski", "studentTwo123", "rp456");
            Students student3 = new Students("John", "Doe", "studentThree123", "doeJohn4");
            Students student4 = new Students("Bob", "Bobski", "studentFour123", "bobskiii");

            teachers.Add(teacher1);
            teachers.Add(teacher2);
            teachers.Add(teacher3);
            teachers.Add(teacher4);

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
         
            bool foundStudent = false;

            Console.WriteLine(" \t \t \t \t \t Welcome to the Quiz App");

            while (true)
            {
                Console.WriteLine("If you are a teacher press [T] if you are a student press [S]");
                string studentOrTeacher = Console.ReadLine();

                switch (studentOrTeacher)
                {
                    case "S":
                    case "s":
                        Console.WriteLine("Please enter your username:");
                        string studentUsername = Console.ReadLine();

                        Console.WriteLine("Please enter your password:");
                        string studentPassword = Console.ReadLine();

                        Console.WriteLine();
                                           
                        foreach (Students st in students)
                        {                                                      
                            if (studentUsername == st.UserName && studentPassword == st.Password)
                            {
                                Console.WriteLine($"Welcome {st.GetInfo()}");
                                foundStudent = true;

                                st.IsLoggedIn = true;
                              
                                Console.WriteLine(); //I did this just to have a cleaner terminal that is not so jammed
                                                               
                                Console.WriteLine("1.Q:What is the capital of Tasmania? \na:Dadoma \nb:Hobart \nc:Launceston \nd:Wellington");
                                string questionOneAnswer = Console.ReadLine();
                                if (questionOneAnswer == "b")
                                {
                                    st.Grades++;
                                }
                                Console.WriteLine();

                                Console.WriteLine("2.Q: What is the tallest building in the Republic of the Congo? \na:Kinshasa Democratic Republic of the Congo Temple \nb:Palais de la Nation \nc:Kongo Trade Centre \nd:Nabemba Tower");
                                string questionTwoAnswer = Console.ReadLine();
                                if (questionTwoAnswer == "d")
                                {
                                    st.Grades++;
                                }
                                Console.WriteLine();

                                Console.WriteLine("3.Q:Which of these is not one of Pluto's moons? \na:Styx \nb:Hydra \nc:Nix  \nd:Lugia");
                                string questionThreeAnswer = Console.ReadLine();
                                if (questionThreeAnswer == "c")
                                {
                                    st.Grades++;
                                }
                                Console.WriteLine();

                                Console.WriteLine("4.Q:What is the smallest lake in the world? \na:Onega Lake \nb:Benxi Lake \nc:Kivu Lake \nd:Wakatipu Lake");
                                string questionFourAnswer = Console.ReadLine();
                                if (questionFourAnswer == "b")
                                {
                                    st.Grades++;
                                }
                                Console.WriteLine();

                                Console.WriteLine("5.Q:What country has the largest population of alpacas? \na:Chad \nb:Peru  \nc:Australia  \nd:Niger");
                                string questionFiveAnswer = Console.ReadLine();
                                if (questionFiveAnswer == "b")
                                {
                                    st.Grades++;
                                }
                                Console.WriteLine();
                                Console.WriteLine($"{st.FirstName} got {st.Grades} total points");
                                Console.WriteLine("Thank you for joining the quiz");
                                                                
                            }
                        }
                        
                        if (!foundStudent)
                        {
                            Console.WriteLine("Wrong input");
                        }

                        break;

                    case "T":
                    case "t":
                        Console.WriteLine("Please enter your username:");
                        string teacherUsername = Console.ReadLine();

                        Console.WriteLine("Please enter your password:");
                        string teacherPassword = Console.ReadLine();

                        bool foundTeacher = false;

                        foreach (Teacher teacher in teachers)
                        {
                            if (teacherUsername == teacher.UserName && teacherPassword == teacher.Password)
                            {
                                Console.WriteLine($"Welcome {teacher.GetInfo()}");
                                Console.WriteLine();
                                foundTeacher = true;

                                foreach (Students student in students)
                                {
                                    if (student.IsLoggedIn)
                                    {
                                        Console.WriteLine($"Student Name: {student.GetInfo()}: Student Grade: {student.Grades}");
                                        Console.WriteLine();
                                    }
                                }

                            }

                        }
                        if (!foundTeacher)
                        {
                            Console.WriteLine("Teacher is not found or doesnt exist");
                        }

                            break;
                }
            }
        }
    }
}