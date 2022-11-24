using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_l4_Intro_OOP_3
{
    internal static class  Utente
    {
        private static string _username;
        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private static string _password;
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public static void StartMenu()
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("             LOGIN PAGE              ");
                Console.WriteLine("*************************************");

                Console.WriteLine("\nScegli l'operazione da effettuare:");
                Console.WriteLine("1. LOGIN");
                Console.WriteLine("2. LOGOUT");
                Console.WriteLine("3. VERIFICA ORA E DATA DI LOGIN");
                Console.WriteLine("4. LISTA DEGLI ACCESSI");
                Console.WriteLine("5. ESCI");

                int scelta = int.Parse(Console.ReadLine());



                if (scelta == 1)
                {
                    //Login();
                }
                if (scelta == 2)
                {
                    //Logout();
                }
                if (scelta == 3)
                {
                    //VerificaOra();
                }
                if (scelta == 4)
                {
                    //ListaAccessi();
                }
                if (scelta == 5)
                {
                    Console.WriteLine("Chiusura del programma...");
                }
                else
                {
                    Console.WriteLine("Hai selezionato una voce non valida");
                    StartMenu();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hai digitato un valore non valido!");
                StartMenu();
            }
        }
    }
}
