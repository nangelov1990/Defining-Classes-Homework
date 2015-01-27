namespace SoftUni_Learning_System.Classes
{
    class Student : Person
    {
        private int _studentNumber;
        private double _averageGrade;

        public enum SoftUniCourses
        {
            HTML, JavaScript, Java, OOP, PHP
        }

        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;

            printout = "STUDENT\n"
                + printout
                + string.Format("Student No.: {0}\n", this.StudentNumber)
                + string.Format("Average grade: {0}\n", this.AverageGrade);
        }

        public int StudentNumber
        {
            get { return this._studentNumber; }
            set { this._studentNumber = value; }
        }

        public double AverageGrade
        {
            get { return this._averageGrade; }
            set { this._averageGrade = value; }
        }
    }
}
