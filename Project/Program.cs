﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static PersonList personList;
    static UserList userList;
    private static void Main(string[] args)
    {
        PreparePersonAndUserListProgramIsLoad();
        PrintMenuScreen();
    }
    static void PrintMenuScreen(){
        Console.Clear();
        PrintListMenu();
    }
    static void PrintListMenu(){
        Console.WriteLine("                             Menu                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (1) <<- Register.");
        Console.WriteLine(" (2) <<- Login.");
        Console.WriteLine(" (3) <<- Guest login.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Choose number (1-3) : ");
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
        Console.WriteLine(" (1) <<- Register.");
        Console.WriteLine(" (2) <<- Show My Info.");
        Console.WriteLine(" (3) <<- Log out.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Choose number (1-3) : ");
        Menu2 menu2 = (Menu2)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu2) {
            case Menu2.Registeration:
                InputRegisterationScreen();
                break;
            case Menu2.ShowAllMember:
                ShowMemberInfo();
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
        Console.WriteLine(" (1) <<- Show My Info.");
        Console.WriteLine(" (2) <<- Login.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Choose number (1-2) : ");
        Menu3 menu3 = (Menu3)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu3) {
            case Menu3.ShowAllMember:
                ShowMemberGuestInfo();
                break;
            case Menu3.GoLogin:
                BackToLoginScreen();
                break;
        default:
            break;
        }
    }

    static void PrintListMenuWhenGuestWantToLogin(){
        Console.Clear();
        Console.WriteLine("                             Menu                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (1) <<- Register.");
        Console.WriteLine(" (2) <<- Login.");
        Console.WriteLine(" (3) <<- Back.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Choose number (1-3) : ");
        Menu4 menu4 = (Menu4)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (menu4) {
            case Menu4.Registeration:
                InputRegisterationScreen();
                break;
            case Menu4.GoLogin:
                BackToLoginScreen();
                break;
            case Menu4.PreviousPage:
                ShowMemberGuestInfo();
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
        Person newPerson = new Person(CheckNamePrefix(InputNamePrefix()),
                                  InputName(),
                                  InputSurname(),
                                  InputAge(),
                                  CheckCountry(InputCountry()));
        Program.personList.AddNewPerson(newPerson);

        InputUsername_Email_Password();

        Console.WriteLine("********************");

        BackToMainMenu();

    }

    static void PreparePersonAndUserListProgramIsLoad() {
        Program.personList = new PersonList();
        Program.userList = new UserList();
    }

    static void ShowMemberInfo() {
        Console.WriteLine("Show Member Info");
        Console.WriteLine("***************************************");

        Program.userList.UList();
        Program.personList.PList();

        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToMenuWhenLogin();
    }

    static void ShowMemberGuestInfo() {
        Console.Clear();
        Console.WriteLine("***************************************");
        Console.WriteLine("             Please Login              ");
        Console.WriteLine("***************************************");
        Console.WriteLine(" (1) <<- Register.");
        Console.WriteLine(" (2) <<- Login.");
        Console.WriteLine(" (3) <<- Back.");
        Console.Write("Choose number (1-2) : ");
        GuestInfo guestWantToLogin = (GuestInfo)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (guestWantToLogin) {
            case GuestInfo.GuestWantToRegister:
                ShowLoginScreen();
                break;
            case GuestInfo.GuestWantToLogin:
                InputRegisterationScreen();
                break;
            case GuestInfo.GuestInfoPreviousPage:
                PrintListMenuWhenGuestLogin();
                break;
        default:
            break;
        }
    }

    public static void InputUsername_Email_Password() {
        Console.Clear();
        if (userList.CheckValue() == 0) { //เช็ค จำนวนmember
            User newUser = new User(InputUsername(),
                                    InputPassword());
            Program.userList.AddNewUser(newUser);
        } else { //ถ้าไม่มีแอด newUser ใหม่
            int a = 0;
            do {
                User newUser = new User(InputUsername(),
                                        InputPassword());
                if (userList.Loging_in(newUser) == false) { 
                    Program.userList.AddNewUser(newUser);
                    a = 1;
                    Console.Clear();
                } else {
                    Console.WriteLine("Invalid Email. Pleae try again.!!");
                }
            } while (a != 1);
        }
        Console.Clear();
    }

    public static void InputUsername_Password() {
        int a = 0;
        do {
            User newUser = new User(InputUsername(),
                                    InputPassword());
            if (userList.Loging_in(newUser) == false) { 
                Console.WriteLine("Username or password does not match.");
                Console.Clear();
            } else {
                break;
            }
        } while (a != 1);
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

    static string InputUsername() {
        Console.WriteLine("Input Username & Password");
        Console.Write("Username : ");
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
        Console.WriteLine("               Log-in               ");
        Console.WriteLine("************************************");
        InputUsername_Password();

        Console.Clear();
        PrintListMenuWhenLogin();
    }

    static void BackToLoginScreen() {
        Console.Clear();
        ShowLoginScreen();
    }

    static void BackToMenuWhenLogin() {
        Console.Clear();
        PrintListMenuWhenLogin();
    }
}