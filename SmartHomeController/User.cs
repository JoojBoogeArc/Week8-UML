using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private string contactInfo;
        private bool isLoggedIn;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn;}
            set { isLoggedIn = value;}
        }

        public User(int userId, string userName, string password, string contactInfo)
        {
            this.userID = userId;
            this.userName = userName;
            this.password = password;
            this.isLoggedIn = false;
        }

        public bool Login(string userName, string password)
        {
            if (UserName == userName && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Login Successful");
            }
            else
            {
                IsLoggedIn = false;
                Console.WriteLine($"Login Failed. Username {userName} or password is incorrect");
            }
            return IsLoggedIn;
        }

        public void Logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("User is logged out successfully");
            }
            else
            {
                Console.WriteLine("User is not logged in");
            }
        }

        public void ControlDevices(int deviceID, string deviceName, string deviceAction)
        {
            if (IsLoggedIn)
            {
                Console.WriteLine($"Performing action {deviceAction} on {deviceName} ");
            }
            else
            {
                Console.WriteLine("Please log in to control the device");
            }
        }
    }
}