using System;
using System.Collections.Generic;
using System.Text;
namespace cmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Invite de commandes";

            string Input = string.Empty;
            Console.WriteLine("Microsoft Windows [version 10.0.19044.1645]");
            Console.WriteLine("(c) Microsoft Corporation. Tous droits réservés.");
            Console.WriteLine();
            Console.Write($"C:\\Users\\{Environment.UserName}>");
            while ((Input = Console.ReadLine()) != "exit")
            {
                string[] commande = Input.Split(' ');
                Console.WriteLine($"'{commande[0]}' n’est pas reconnu en tant que commande interne\r\nou externe, un programme exécutable ou un fichier de commandes.");
                Console.WriteLine();
                Console.Write($"C:\\Users\\{Environment.UserName}>");
            }

        }
    }
}
