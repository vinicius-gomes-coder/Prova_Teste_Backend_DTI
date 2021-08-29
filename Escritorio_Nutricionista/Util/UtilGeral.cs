using Escritorio_Nutricionista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escritorio_Nutricionista.Util
{
    public class UtilGeral
    {
        public static bool CheckYesNo(string checkString)
        {
            string typed = "";
            while (typed != "s" && typed != "S" && typed != "n" && typed != "N")
            {
                Console.WriteLine(checkString);
                typed = Console.ReadLine();
            }

            if (typed == "s" || typed == "S")
                return true;
            else
                return false;
        }

        public static Client SearchClient(List<Client> clients)
        {
            string nameClient;

            Console.WriteLine("Nome completo do paciente da consulta:");
            nameClient = Console.ReadLine();

            foreach (Client v_client in clients)
            {
                if (v_client.nome == nameClient)
                {
                    return v_client;
                }
            }

            return null;
        }

        public static List<DietOptions> FindDiet(double goalCalory, List<Food> group1, List<Food> group2, List<Food> group3)
        {
            Food food1;
            Food food2;
            Food food3;

            List<DietOptions> foodsForDiet = new List<DietOptions>();

            for (int i = 0; i < group1.Count; i++)
            {
                food1 = group1[i];

                for (int j = 0; j < group2.Count; j++)
                {
                    food2 = group2[j];

                    for (int k = 0; k < group3.Count; k++)
                    {
                        food3 = group3[k];

                        if (food1.calory + food2.calory + food3.calory <= goalCalory)
                            foodsForDiet.Add(new DietOptions
                            {
                                dietOptions = new List<Food>
                                    {
                                        food1,
                                        food2,
                                        food3
                                    }
                            });
                    }
                }
            }

            return foodsForDiet;
        }
    }
}