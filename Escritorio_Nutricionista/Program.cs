using Escritorio_Nutricionista.Models;
using System;
using System.Collections.Generic;

namespace Escritorio_Nutricionista
{
    public class Program
    {
        static void Main(string[] args)
        {            
            List<string> optionsMenu = new List<string>();
            List<Client> clients = new Client().StartListClients();
            List<Food> group1 = new Food().StartListGroup1();
            List<Food> group2 = new Food().StartListGroup2();
            List<Food> group3 = new Food().StartListGroup3();            

            optionsMenu.Add("Cadastrar cliente");
            optionsMenu.Add("Consulta");
            optionsMenu.Add("Verificar consultas anteriores");

            int selectedMenuOption = 0;

            bool done = false;

            while (!done)
            {
                for (int i = 0; i < optionsMenu.Count; i++)
                {
                    if (selectedMenuOption == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                    Console.WriteLine(optionsMenu[i]);

                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedMenuOption = Math.Max(0, selectedMenuOption - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedMenuOption = Math.Min(optionsMenu.Count - 1, selectedMenuOption + 1);
                        break;
                    case ConsoleKey.Enter:
                        if (selectedMenuOption == 0)
                            Service.BuildClientForRegister(clients);
                        else if (selectedMenuOption == 1)
                            Service.BeginAppointment(clients,group1,group2,group3);
                        else
                            Service.ListAppointments(clients);
                        break;
                }

                if (!done)
                    Console.CursorTop = 0;
            }     
        }
    }
}
