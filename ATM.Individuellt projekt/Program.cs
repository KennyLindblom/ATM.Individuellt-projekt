using System;

namespace ATM.Individuellt_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int currentAccountIndex = 0;
            string[][] users = new string[5][];

        }

        private static string[][] GetUsers(ref string[][] users)
        {
            users[0] = new string[] { "Johan", "1234", "SavingsAccount", "15000,0", "PrivateAccount", "4500,50" };
            users[1] = new string[] { "Fredrik", "4321", "SavingsAccount", "1500,0", "PrivateAccount", "30000,50" };
            users[2] = new string[] { "Anna", "1111", "SavingsAccount", "2700,0", "PrivateAccount", "60000,50" };
            users[3] = new string[] { "Björn", "2222", "SavingsAccount", "18000,0", "PrivateAccount", "200,50" };
            users[4] = new string[] { "Jerka", "3333", "SavingsAccount", "5500,0", "PrivateAccount", "1000" };

            return users;



        } //Databas av alla användare


    }
}
