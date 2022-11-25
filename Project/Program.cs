using System;
class Program
{
    static PersonList personList;
    private static void Main(string[] args)
    {
        PreparePersonListProgramIsLoad();
        PrintMenuScreen();
    }
    static void PrintMenuScreen(){
        Console.Clear();
        PrintListMenu();
    }
    static void PrintListMenu(){
        Console.WriteLine("                             Menu                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Guest login");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Please input Menu (1-3) : ");
        Menu menu = (Menu)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu) {
            case Menu.Registeration:
                InputRegisterationScreen();
                break;
            case Menu.Login:
                ShowLoginScreen();
                break;
            case Menu.Guest:
                PrintListMenuWhenGuestLogin();
                break;
        default:
            break;
        }
    }

    static void PrintListMenuWhenLogin(){
        Console.WriteLine("                             Menu                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("1. Registeration");
        Console.WriteLine("2. Show member.");
        Console.WriteLine("3. Log out.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Please input Menu (1-3) : ");
        Menu2 menu2 = (Menu2)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu2) {
            case Menu2.Registeration:
                InputRegisterationScreen();
                break;
            case Menu2.ShowAllMember:
                ShowAllMemberParticipating();
                break;
            case Menu2.Logout:
                PrintMenuScreen();
                break;
        default:
            break;
        }
    }

    static void PrintListMenuWhenGuestLogin(){
        Console.Clear();
        Console.WriteLine("                             Menu                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("1. Registeration");
        Console.WriteLine("2. Show member.");
        Console.WriteLine("3. Login.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Please input Menu (1-3) : ");
        Menu3 menu3 = (Menu3)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu3) {
            case Menu3.Registeration:
                InputRegisterationScreen();
                break;
            case Menu3.ShowAllMember:
                ShowAllMemberParticipating();
                break;
            case Menu3.GoLogin:
                BackToLoginScreen();
                break;
        default:
            break;
        }
    }

    public static void InputRegisterationScreen() {
        Console.Clear();
        Console.WriteLine("      Register      ");
        Console.WriteLine("********************");
        Console.Clear();
        User newUser = new User(InputUsername(),
                                  CheckNamePrefix(InputNamePrefix()),
                                  InputName(),
                                  InputSurname(),
                                  InputAge(),
                                  CheckCountry((InputCountry())));
        Program.personList.AddNewPerson(newUser);
        Console.WriteLine("********************");

        BackToMainMenu();

    }
    /*
    static void CheckName(){
        PersonList inventory = new PersonList(personList);
        Person checkperson = new Person(InputNamePrefix(),InputName(),InputSurname(),"","","","","");
        Person searchName = inventory.SearchName(checkperson);
    }
    */
    static void PreparePersonListProgramIsLoad() {
        Program.personList = new PersonList();
    }

    static void ShowAllMemberParticipating() {
        Console.WriteLine("Show all Members participating");
        Console.WriteLine("***************************************");

        Program.personList.List();

        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToMenuWhenLogin();
    }


    static string InputUsername() {
        Console.Write("Username : ");
        return Console.ReadLine();
    }

    static string InputNamePrefix() {
        Console.Write("Name prefix ( (1)Mr. (2)Mrs. (3)Miss. ) : ");
        return Console.ReadLine();
    }

    static string InputName() {
        Console.Write("Name : ");
        return Console.ReadLine();
    }

    static string InputSurname() {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }

    static string InputAge() {
        Console.Write("Age : ");
        return Console.ReadLine();
    }

    static string InputCountry() {
        Console.Write("Country ( (1)Thailand <-- Only ) : ");
        return Console.ReadLine();
    }
     /*
    static string InputAdmin() {
        Console.Write("Admin? (y/n) : ");
        string checkadmin = Console.ReadLine();
        if((checkadmin == "Yes")||(checkadmin == "yes")||(checkadmin == "Y")||(checkadmin == "y")) {
            CheckEmail(InputEmail());
            InputPassword();
        } else if((checkadmin == "No")||(checkadmin == "no")||(checkadmin == "N")||(checkadmin == "n")) {
            return null;
        } else {
            Console.WriteLine("Please input again");
            Console.ReadLine();
            return InputAdmin();
        }
        return null;
    }
    */
    static string InputEmail() {
            Console.Write("Email : ");
            return Console.ReadLine();
    }

    static string InputPassword() {
            Console.Write("Password : ");
            return Console.ReadLine();
    }

    static string CheckNamePrefix(string namePrefix){
        if (namePrefix == "1") {
            return namePrefix = "Mr.";
        } else if (namePrefix == "2") {
            return namePrefix = "Mrs.";
        } else if (namePrefix == "3") {
            return namePrefix = "Miss.";
        }
        throw new Exception("Please choose Name-prefix");
    }

    static string CheckCountry(string country){
        if ((country == "1")) {
            return country = "TH";
        } else {
            Console.WriteLine("Please input your Country");
            return CheckCountry(InputCountry());
        }
    }

    static string CheckEmail(string email){
        if ((email == "exit")) {
            Console.Write("Invalid email. Please try again.");
            Console.ReadLine();
            BackToMainMenu();
        }
        return email;
    }

    static void BackToMainMenu() {
        Console.Clear();
        PrintListMenu();
    }

    static void ShowLoginScreen() {
        Console.Clear();
        Console.WriteLine("   Log-in   ");
        Console.WriteLine("************");
        Login login = new Login(CheckLoginEmail(InputLoginEmail()),
                                InputLoginPassword());
        Console.Clear();
        PrintListMenuWhenLogin();
    }

    static string InputLoginEmail() {
        Console.Write("Email : ");
        return Console.ReadLine();
    }

    static string InputLoginPassword() {
        Console.Write("Password : ");
        return Console.ReadLine();
    }
    static string CheckLoginEmail(string loginEmail/*,string email*/){
        if ((loginEmail == "exit")) {
            Console.Clear();
            BackToMainMenu();
        }
        /*
        else if (loginEmail != email) {
            Console.WriteLine("Incorrect email or password. Please try again.");
            BackToLoginScreen();
        }
        */
        return null;
    }

    /*
    static string CheckLoginPassword(string loginPassword){
        if ((loginPassword != this.password)) {
            Console.WriteLine("Incorrect email or password. Please try again.");
            BackToLoginScreen();
        }
        return null;
    } */
    
    static void BackToLoginScreen() {
        Console.Clear();
        ShowLoginScreen();
    }

    static void BackToMenuWhenLogin() {
        Console.Clear();
        PrintListMenuWhenLogin();
    }
}