namespace SoftUni_Learning_System.Classes
{
    using System;

    class CurrentStudent : Student
    {
        private SoftUniCourses _currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, SoftUniCourses currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;

            printout = printout
                + string.Format("Current course: {0}\n", this.CurrentCourse);
        }

        public SoftUniCourses CurrentCourse
        {
            get { return _currentCourse; }
            set
            { this._currentCourse = value; }
        }
    }
}
