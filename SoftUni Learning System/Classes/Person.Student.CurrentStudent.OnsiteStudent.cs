namespace SoftUni_Learning_System.Classes
{
    class OnsiteStudent : CurrentStudent
    {
        private int _numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, SoftUniCourses currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;

            printout = "ONSITE "
                       + printout
                       + string.Format("Number of visits: {0}\n", this.NumberOfVisits);
        }

        public int NumberOfVisits
        {
            get { return this._numberOfVisits; }
            set { this._numberOfVisits = value; }
        }
    }
}
