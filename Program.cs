namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Preschooler person1 = new Preschooler("Tom", "Tod", 12, "+6985105897", "tom@mail.com", "te", "Bob", 2, false);
            Preschooler person2 = new Preschooler("Tom", "Tod", 3, "+6985105897", "tom@mail.com", "te", "Bob", 2, true);
            Schoolkid person3 = new Schoolkid("Jack", "Scott", 10, "+9475528867", "scott@gmail.com", "address", "School", "PE", 10.2);
            Student person4 = new Student("Bob", "", 18, "+1-999-555-9999", "bob@b.com", null, "", "ICS","CK2146");

            PersonsArray persons = new PersonsArray(person1, person2);

            persons.AddPerson(person3);
            persons.AddPerson(person4);
            Console.WriteLine(persons);

            persons.EditPerson(0, new Preschooler("Robert", "Barrett", 2, "+1-212-664-7665", "robertB@mail.com", "new Address", "Toy", 1, false));
            persons.EditPerson(person4, new Student("Bob", "Scott", 21, "+1-999-555-99", "bob@b.com", "address", "ONPU", "ICS", "CK2146"));
            Console.WriteLine(persons);

            persons.RemovePerson(person2);
            persons.RemovePerson(1);
            Console.WriteLine(persons);
        }
    }
}