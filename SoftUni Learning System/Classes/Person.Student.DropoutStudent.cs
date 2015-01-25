namespace SoftUni_Learning_System.Classes
{
    using System;

    internal class DropoutStudent : Student
    {
        private string _dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade,
            string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;

            printout = "DROPOUT "
                       + printout
                       + string.Format("Dropout reason: {0}\n", this.DropoutReason);
        }

        public string DropoutReason
        {
            get { return _dropoutReason; }
            set { this._dropoutReason = value; }
        }

        public void Reapply()
        {
            Console.WriteLine(printout);
        }
    }
}
