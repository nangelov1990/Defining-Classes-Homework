namespace Persons
{
    using System;
    class PersonsMain
    {
        static void Main()
        {
            Person personFirst = new Person("Metodi", 12);
            Person personSecond = new Person("Jully", 26, "django_ze@maimunka.zoopark");

            Console.WriteLine(personFirst + "\n" + personSecond);
        }
    }
}
