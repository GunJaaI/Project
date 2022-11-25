public class Person {
    private string username;
    private string namePrefix;
    private string name;
    private string surname;
    private string age;
    private string country;
    private string email;
    private string password;

    public Person(string username,string namePrefix,string name,string surname
    ,string age,string country) {
        this.username = username;
        this.namePrefix = namePrefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.country = country;
        

    }

    public string GetUsername(){
        return this.username;
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
    public string GetEmail(){
        return this.email;
    }
    public string GetPassword(){
        return this.password;
    }

}

public class User : Person {
    public User(string username,string namePrefix,string name,string surname,string age,string country)
    : base(username,namePrefix,name,surname,age,country) {
    }
}