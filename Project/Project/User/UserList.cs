using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserList {
    private List<User> userList;
    public UserList() {
        this.userList = new List<User>();
    }

    public void AddNewUser(User newUser) {
        this.userList.Add(newUser);
    }

    public void UList() {
        
        foreach (User newUser in this.userList) {
            if (newUser is User) {
                Console.WriteLine("| Username : {0}",newUser.GetUsername());
            } 
        }
    }

    public int CheckValue() {
        int x = userList.Count();
        if (x == null) {
            return 0;
        } else {
            return x;
        }
    }

    public bool Loging_in(User searchRegis) {
        foreach (User newUser in userList) {
            string username = searchRegis.GetUsername();
            string password = searchRegis.GetPassword();

            if (newUser.GetUsername().Equals(username) && //เช็คว่า login แล้วที่กรอกมาถูกไหม
                newUser.GetPassword().Equals(password)) {
                return true;
                }
            }
            return false;
        }
}