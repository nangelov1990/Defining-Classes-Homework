namespace SoftUni_Learning_System.Classes
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, SoftUniCourses currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            printout = "ONLINE " + printout;
        }
    }
}
