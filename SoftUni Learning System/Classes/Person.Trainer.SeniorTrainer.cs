namespace SoftUni_Learning_System.Classes
{
    using System;

    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            printout = "SENIOR " + printout;
        }

        public void DeleteCourse(string courseName)
        {
            string output = string.Format("{0} course deleted.", courseName);

            Console.WriteLine(output);
        }
    }
}
