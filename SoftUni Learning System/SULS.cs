namespace SoftUni_Learning_System
{
    using System;
    using System.Linq;
    using SoftUni_Learning_System.Classes;

    static class SULS
    {
        static readonly Student student01 = new OnsiteStudent("Demir", "Zhebchiev", 19, 40009014, 4.87, Student.SoftUniCourses.HTML, 21);
        static readonly Student student02 = new OnsiteStudent("Mirko", "Bogomiralev", 21, 40009064, 5.47, Student.SoftUniCourses.Java, 28);
        static readonly Student student03 = new OnsiteStudent("Shishmani", "Dzechev", 17, 40009043, 5.94, Student.SoftUniCourses.OOP, 41);
        static readonly Student student04 = new OnsiteStudent("Gurel", "Lekomurzlev", 26, 40009193, 3.94, Student.SoftUniCourses.JavaScript, 11);
        static readonly Student student05 = new OnsiteStudent("Rumbosko", "Vurtugyzeff", 23, 40009033, 4.85, Student.SoftUniCourses.PHP, 31);
        static readonly Student student06 = new OnlineStudent("Gergin", "Shamandurev", 22, 40009047, 5.12, Student.SoftUniCourses.HTML);
        static readonly Student student07 = new OnlineStudent("Zhambazko", "Gepishamarev", 19, 40009098, 5.08, Student.SoftUniCourses.Java);
        static readonly Student student08 = new OnlineStudent("Zamun", "Humanoid", 21, 40009065, 4.52, Student.SoftUniCourses.JavaScript);
        static readonly Student student09 = new OnlineStudent("Gosho", "Shoshov", 27, 40009171, 3.94, Student.SoftUniCourses.PHP);
        static readonly Student student10 = new OnlineStudent("Emet", "Shemet", 25, 40009147, 5.75, Student.SoftUniCourses.OOP);
        static readonly Student student11 = new GraduateStudent("Goradi", "Gurdev", 26, 40009007, 5.96);
        static readonly Student student12 = new GraduateStudent("Hubaff", "Samsi", 24, 40009013, 4.67);
        static readonly Student student13 = new GraduateStudent("Dushku", "Dubrudushkov", 29, 40009015, 5.34);
        static readonly Student student14 = new DropoutStudent("Dushku", "Dubrudushkov", 29, 40009015, 3.35, "Failed at HTML");
        static readonly Student student15 = new DropoutStudent("Dushku", "Dubrudushkov", 29, 40009015, 2.36, "FAILED!!!");

        static readonly Trainer jtrainer01 = new JuniorTrainer("Goran", "Hristoskov", 26);
        static readonly Trainer jtrainer02 = new JuniorTrainer("Milcho", "Mishev", 24);
        static readonly Trainer strainer01 = new SeniorTrainer("Vilcho", "Veskov", 29);

        static readonly Student[] students = new Student[]
            {
                student01,
                student02,
                student03,
                student04,
                student05,
                student06,
                student07,
                student08,
                student09,
                student10,
                student11,
                student12,
                student13,
                student14,
                student15
            };

        static readonly Trainer[] trainers = new Trainer[]
            {
                jtrainer01,
                jtrainer02,
                strainer01
            };

        private const string StarBreaker = "***********************\n";
        private const string LineBreaker = "-----------------------\n";

        static void Main()
        {
            Console.WriteLine(StarBreaker + "SoftUni Learning System\n" + StarBreaker);

            SulsTest();

            PrintSu();
        }

        private static void SulsTest()
        {
            Console.WriteLine("Current Students\n");

            foreach (var student in students
                .Where(student => student is CurrentStudent)
                .OrderBy(student => student.AverageGrade))
            {
                Console.WriteLine(student);
                Console.WriteLine(LineBreaker);
            }
        }

        private static void PrintSu()
        {
            Console.WriteLine(StarBreaker + "SOFTUNI\n" + StarBreaker);

            Console.WriteLine("Trainers\n");

            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer);
                Console.WriteLine(LineBreaker);
            }

            Console.WriteLine("Graduate students\n");

            foreach (var student in students
                .Where(student => student is GraduateStudent)
                .OrderBy(student => student.AverageGrade))
            {
                Console.WriteLine(student);
                Console.WriteLine(LineBreaker);
            }

            Console.WriteLine("Dropout students\n");

            foreach (var student in students
                .Where(student => student is DropoutStudent)
                .OrderBy(student => student.AverageGrade))
            {
                Console.WriteLine(student);
                Console.WriteLine(LineBreaker);
            }
        }
    }
}
