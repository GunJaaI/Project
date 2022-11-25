using System.Collections.Generic;
using System;
public class PersonList {
    private List<Person> personList;
    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }

    public void List() {
        Console.WriteLine("List Member(s).");
        Console.WriteLine("**********************");

        foreach (Person person in this.personList) {
            if (person is User) {
                Console.WriteLine("| Username : {0}",person.GetUsername());
                Console.WriteLine("| Name : {0}{1} {2}",person.GetNamePrefix(),person.GetName(),person.GetSurname());
                Console.WriteLine("| Age : {0}",person.GetAge());
                Console.WriteLine("| Country : {0}",person.GetCountry());
            } 
        }
        Console.WriteLine("**********************");
    }
}