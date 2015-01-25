namespace SoftUni_Learning_System.Classes
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            printout = "GRADUATE " + printout;
        }
    }
}
