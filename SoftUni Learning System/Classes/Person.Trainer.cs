namespace SoftUni_Learning_System.Classes
{
    using System;

    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            printout = "TRAINER\n"
                + printout;
        }

        public void CreateCourse(string courseName)
        {
            string output = string.Format("New course {0} created.", courseName);

            Console.WriteLine(output);
        }
    }
}