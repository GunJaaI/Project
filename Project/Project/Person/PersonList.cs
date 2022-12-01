using System.Collections.Generic;
using System;
public class PersonList {
    private List<Person> personList;
    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person newPerson) {
        this.personList.Add(newPerson);
    }

    public void PList() {

        foreach (Person newPerson in this.personList) {
            if (newPerson is Person) {
                Console.WriteLine("| Name : {0}{1} {2}",newPerson.GetNamePrefix(),newPerson.GetName(),newPerson.GetSurname());
                Console.WriteLine("| Age : {0}",newPerson.GetAge());
                Console.WriteLine("| Country : {0}",newPerson.GetCountry());
            } 
        }
        Console.WriteLine("**********************");
    }

    public bool ChaekMemberName(Person search)
        {
            foreach (Person newPerson in personList)
            {
                if (newPerson.GetNamePrefix().Equals(search.GetNamePrefix()) && newPerson.GetName().Equals(search.GetName()) && newPerson.GetSurname().Equals(search.GetSurname())){
                    return false;
                }
            }
            return true;
        }
}