using System;

namespace ATM.Individuellt_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int currentAccountIndex = 0;
            string[][] users = new string[5][];

            GetUsers(ref users);

            //Start punkt för programmet som tar oss till mainmenu login är TRUE 
            ProgramStart(ref currentAccountIndex, ref users);



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

        private static void ProgramStart(ref int currentAccountIndex, ref string[][] users)
        {
            if (Login(ref currentAccountIndex, ref users))
            {
                Console.WriteLine("You are logged in" + " " + currentAccountIndex);
                MainMenu(ref currentAccountIndex, ref users);
            }
        } //Program start 

        private static void MainMenu(ref int CurrentAccountIndex, ref string[][] users)
        {
            Welcome();

            Console.WriteLine("1 - View your account");                //Olika alternativ om vad användaren vill göra 
            Console.WriteLine("2 - Transfer between accounts");
            Console.WriteLine("3 - Take out Money");
            Console.WriteLine("4 - Exit");
            int userChoiceMenu = int.Parse(Console.ReadLine()); //Sparas i varibel som används i switch 
            switch (userChoiceMenu)
            {

                case 1:
                    CheckUserAccount(ref CurrentAccountIndex, ref users); //Tar oss till kolla konto 
                    break;
                case 2:
                    TransferMoney(ref CurrentAccountIndex, ref users); //Tar oss till föra över pengar 
                    break;
                case 3:
                    TakeOutMoney(ref CurrentAccountIndex, ref users);  //Tar oss till ta ut pengar
                    break;
                case 4:
                    Console.WriteLine("You are beeing logged out..... "); //Stänger programet, tillbka till logga in 
                    Console.ReadKey();

                    Console.Clear();
                    ProgramStart(ref CurrentAccountIndex, ref users);
                    break;

                default:
                    Console.WriteLine("Invalid choice"); //Om man skriver något annat än 1-4 skrivs felmeddelande ut. 
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu(ref CurrentAccountIndex, ref users);
                    break;



            }



        } //Meny med alla alternativ 

        private static void CheckUserAccount(ref int currentAccountIndex, ref string[][] users)
        {
            Console.Clear();
            Console.WriteLine("Here are your accounts ");
            Console.WriteLine("_______________________");

            for (int i = 2; i < users[currentAccountIndex].Length; i += 2) //Går igenom arrray med hjälp av currentAccountIndex för betämma var vi är 
            {
                Console.WriteLine(users[currentAccountIndex][i] + ": " + users[currentAccountIndex][i + 1] + " kr"); //Konton skrivs ut 

            }
            Console.WriteLine("Press enter to return to menu. ");
            Console.ReadKey();
            Console.Clear();
            MainMenu(ref currentAccountIndex, ref users); //Tillbka till mainmenu 


        } //Kollar användares konton





    }
}
