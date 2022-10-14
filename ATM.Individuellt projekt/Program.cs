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

        static void Welcome()
        {

            Console.Title = "Big Money Central Bank";
            Console.WriteLine("-----Welcome to BMC Bank-----");
            Console.WriteLine("*****************************");


        } //Välkomms meddelande 

        private static bool Login(ref int currentAccountIndex, ref string[][] users)
        {

            //Deklarera försök börjar på noll, om det går över 3 så går det slut på försök 
            int tries = 0;


            Welcome();

            do
            {
                Console.WriteLine("Username: "); //Ber användaren skriva in användarnamn och pin som sedan kollar igenom vår array för att hitta match 
                string username = Console.ReadLine();
                Console.WriteLine("PinCode: ");
                string password = Console.ReadLine();


                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i][0] == username && users[i][1] == password) // Om anvädare och pin stämmer överns med index i array 
                    {
                        currentAccountIndex = i; //Här sparas värdet av den användare som loggar in. 
                        return true;

                    }


                }
                tries++;
                Console.WriteLine("Wrong information.... ");


            } while (tries < 3);
            Console.WriteLine("To many tries.... This Application will exit "); // Vi har kommit över 3 försök och hoppar ur lopen, programmet stängs 
            Environment.Exit(100);



            return false;


        } //Login funktion 


    }
}
