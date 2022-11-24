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
                    Login();
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
                    Console.WriteLine("\n\nChiusura del programma...\n\n");
                }
                else
                {
                    Console.WriteLine("\t==============================================");
                    Console.WriteLine("\n\n\t\tHai selezionato una voce non valida.\n\n");
                    Console.WriteLine("\t==============================================");
                    StartMenu();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("\t===============================================================================");
                Console.WriteLine("\n\n\t\tHai digitato un valore non valido! Puoi scegliere tra 1 e 5, riprova.\n\n");
                Console.WriteLine("\t===============================================================================");
                StartMenu();
            }
        }
        public static void Login()
        {
            Console.WriteLine("\nNome utente: ");
            string Utente = Console.ReadLine();
            Console.WriteLine("\nPassword: ");
            string Password1 = Console.ReadLine();
            Console.WriteLine("\nConferma Password ");
            string Password2 = Console.ReadLine();
            _username = Utente;
            _password = Password1;
            if (Password1 == Password2)
            {
                Console.WriteLine($"\n\tLe password inserite risultano uguali, benvenuto {Utente}.");
                StartMenu();
            }else
            {
                Console.WriteLine("\n\tLe password che hai inserito non sono uguali, riprova.");
                StartMenu();
            }
        }
        public static void Logout()
        {
            Console.WriteLine($"\nVuoi effettuare il logout {Utente.Username}? premi y/n ");
            StartMenu();
        }
    }
}
