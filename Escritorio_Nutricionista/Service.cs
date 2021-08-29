using Escritorio_Nutricionista.Models;
using Escritorio_Nutricionista.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Escritorio_Nutricionista
{
    public class Service
    {
        public static void BuildClientForRegister(List<Client> clients)
        {
            Client client = new Client();

            Console.Clear();

            Console.WriteLine("Cadastro do cliente");
            Console.WriteLine("Nome:");
            client.nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            client.endereco = Console.ReadLine();
            Console.WriteLine("Telefone:");
            client.telefone = Console.ReadLine();
            Console.WriteLine("E-mail:");
            client.email = Console.ReadLine();
            Console.WriteLine("Data de nascimento:");
            client.dataNascimento = Convert.ToDateTime(Console.ReadLine());

            try
            {
                RegisterClient(clients, client);
                UtilConsole.ShowIfSucessOrError(client, MessageStatus.Sucess);
            }
            catch (Exception exception)
            {
                UtilConsole.ShowIfSucessOrError(client, MessageStatus.Error);
            }
        }

        public static void RegisterClient(List<Client> clients, Client client)
        {           
            clients.Add(client);
        }        

        public static void BeginAppointment(List<Client> clients, List<Food> group1, List<Food> group2, List<Food> group3)
        {
            Client client;

            Console.Clear();

            bool checkClient = true;

            while (checkClient)
            {
                client = UtilGeral.SearchClient(clients);

                if (client == null)
                {
                    Console.WriteLine("Cliente não cadastrado no sistema!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }

                checkClient = UtilGeral.CheckYesNo($"{client.nome} é o paciente da consulta? s/n");
                if (checkClient)
                {
                    BuildAppointment(client,group1,group2,group3);
                    checkClient = false;
                }
                else
                {
                    Console.Clear();
                    checkClient = true;
                }
            }
        }

        public static void Appointment(List<DietOptions> DietOptions, Appointment appointment, Client client)
        {            
            foreach (DietOptions option in DietOptions)
            {
                UtilConsole.ShowDiet(option);
                Console.WriteLine("");
            }

            if (client.Consultas == null)
                client.Consultas = new List<Appointment>();

            client.Consultas.Add(appointment);            
        }        

        public static void BuildAppointment(Client client, List<Food> group1, List<Food> group2, List<Food> group3)
        {
            double goalCalory;
            Appointment appointment = new Appointment();
            int appointments = client.Consultas != null ? client.Consultas.Count + 1 : 1;

            Console.Clear();
            Console.WriteLine($"{appointments}º consulta de {client.nome}");
            appointment.data = DateTime.Now;
            Console.WriteLine("Peso do paciente:");
            appointment.peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Percentual de gordura corporal:");
            appointment.gorduraCorporal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sensação física do paciente:");
            appointment.sensacaoFisicaPaciente = (SensacaoFisica)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Restrições Alimentares");
            appointment.restricoesAlimentares = Console.ReadLine();
            Console.WriteLine("Informe a meta de consumo calórico:");
            goalCalory = Convert.ToDouble(Console.ReadLine());
            List<DietOptions> DietOptions = UtilGeral.FindDiet(goalCalory, group1, group2, group3);
            Console.WriteLine("");
            Console.WriteLine("Opções de dieta para a meta de consumo calórico:");

            try
            {
                Appointment(DietOptions, appointment, client);
                UtilConsole.CloseAppointment();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erro ao salvar a consulta!");
                UtilConsole.CloseAppointment();
            }
        }

        public static void ListAppointments(List<Client> clients)
        {
            Console.Clear();

            Client client = UtilGeral.SearchClient(clients);

            LogAppointments(client);

            UtilConsole.CloseAppointment();
        }

        public static void LogAppointments(Client client)
        {
            if (client == null)
            {
                Console.WriteLine("Cliente não cadastrado no sistema!");
            }
            else if (client.Consultas == null)
                Console.WriteLine("Cliente sem histórico de consultas");
            else
            {
                foreach (Appointment appointment in client.Consultas)
                {
                    UtilConsole.ShowAppointment(appointment);
                }
            }
        }
    }
}
