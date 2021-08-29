using Escritorio_Nutricionista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escritorio_Nutricionista.Util
{
    public class UtilConsole
    {
        public static void ShowAppointment(Appointment appointment)
        {
            Console.WriteLine($"Data: {appointment.data.Day}/{appointment.data.Month}/{appointment.data.Year}");
            Console.WriteLine($"Horário: {appointment.data.TimeOfDay}");
            Console.WriteLine($"Peso: {appointment.peso}");
            Console.WriteLine($"Gordura Corporal: {appointment.gorduraCorporal}%");
            Console.WriteLine($"Sensação física: {appointment.sensacaoFisicaPaciente}");
            Console.WriteLine($"Restrições Alimentares: {appointment.restricoesAlimentares}" + Environment.NewLine);
        }

        public static void ShowDiet(DietOptions DietOptions)
        {
            foreach (Food food in DietOptions.dietOptions)
                Console.WriteLine($"{food.name}");
        }
        public static void ShowIfSucessOrError(Client client, MessageStatus status)
        {
            if (status == MessageStatus.Sucess)
                Console.WriteLine($"Cliente {client.nome} cadastrado no sistema!");
            else
                Console.WriteLine("Erro no cadastro!");

            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void CloseAppointment()
        {
            Console.WriteLine("Pressione Enter para voltar ao menu!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
