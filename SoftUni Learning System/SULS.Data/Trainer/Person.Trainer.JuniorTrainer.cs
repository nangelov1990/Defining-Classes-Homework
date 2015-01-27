namespace SoftUni_Learning_System.Classes
{
    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            printout = "JUNIOR " + printout;
        }
    }
}
