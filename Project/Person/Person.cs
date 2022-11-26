public class Person {
    private string namePrefix;
    private string name;
    private string surname;
    private string age;
    private string country;

    public Person(string namePrefix,string name,string surname
    ,string age,string country) {
        this.namePrefix = namePrefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.country = country;
    }

    public string GetNamePrefix(){
        return this.namePrefix;
    }
    public string GetName(){
        return this.name ;
    }
    public string GetSurname(){
        return this.surname;
    }
    public string GetAge(){
        return this.age;
    }
    public string GetCountry(){
        return this.country;
    }

}
