using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio_Nutricionista.Models
{
    public class Client 
    {        
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
        public List<Appointment> Consultas { get; set; }

        public List<Client> StartListClients ()
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    nome = "Vinicius Augusto Gomes de Resende",
                    endereco = "Rua Doutor Benjamim Moss, 211, Cidade Nova",
                    telefone = "993164744",
                    email = "viniciusgomes.resende@gmail.com",
                    dataNascimento = new DateTime(1995,11,20),
                    Consultas = new List<Appointment>
                    {
                        new Appointment
                        {
                            data = new DateTime(2021,8,28,17,11,30),
                            peso = 75.42,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Bom,
                            restricoesAlimentares = "carboidratos"
                        },
                        new Appointment
                        {
                            data = new DateTime(2021,7,25,17,11,30),
                            peso = 80,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Normal,
                            restricoesAlimentares = "carboidratos"
                        }
                    }
                },
                new Client
                {
                    nome = "Victor Henrique",
                    endereco = "Rua Doutor Benjamim Moss, 211, Cidade Nova",
                    telefone = "993164744",
                    email = "viniciusgomes.resende@gmail.com",
                    dataNascimento = new DateTime(1995,11,20),
                    Consultas = new List<Appointment>
                    {
                        new Appointment
                        {
                            data = new DateTime(2021,6,13,17,11,30),
                            peso = 75.42,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Otimo,
                            restricoesAlimentares = "carboidratos"
                        },
                        new Appointment
                        {
                            data = new DateTime(2021,5,12,17,11,30),
                            peso = 80,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Pessimo,
                            restricoesAlimentares = "carboidratos"
                        }
                    }
                },
                new Client
                {
                    nome = "Maria Aparecida",
                    endereco = "Rua Doutor Benjamim Moss, 211, Cidade Nova",
                    telefone = "993164744",
                    email = "viniciusgomes.resende@gmail.com",
                    dataNascimento = new DateTime(1995,11,20),
                    Consultas = new List<Appointment>
                    {
                        new Appointment
                        {
                            data = new DateTime(2021,4,18,17,11,30),
                            peso = 75.42,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Otimo,
                            restricoesAlimentares = "carboidratos"
                        },
                        new Appointment
                        {
                            data = new DateTime(2021,3,21,17,11,30),
                            peso = 80,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Pessimo,
                            restricoesAlimentares = "carboidratos"
                        }
                    }
                },
                new Client
                {
                    nome = "Ana Júlia",
                    endereco = "Rua Doutor Benjamim Moss, 211, Cidade Nova",
                    telefone = "993164744",
                    email = "viniciusgomes.resende@gmail.com",
                    dataNascimento = new DateTime(1995,11,20),
                    Consultas = new List<Appointment>
                    {
                        new Appointment
                        {
                            data = new DateTime(2021,3,6,17,11,30),
                            peso = 75.42,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Pessimo,
                            restricoesAlimentares = "carboidratos"
                        },
                        new Appointment
                        {
                            data = new DateTime(2021,2,4,17,11,30),
                            peso = 80,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Pessimo,
                            restricoesAlimentares = "carboidratos"
                        }
                    }
                },
                new Client
                {
                    nome = "Thiago Ramos",
                    endereco = "Rua Doutor Benjamim Moss, 211, Cidade Nova",
                    telefone = "993164744",
                    email = "viniciusgomes.resende@gmail.com",
                    dataNascimento = new DateTime(1995,11,20),
                    Consultas = new List<Appointment>
                    {
                        new Appointment
                        {
                            data = new DateTime(2021,2,13,17,11,30),
                            peso = 75.42,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Pessimo,
                            restricoesAlimentares = "carboidratos"
                        },
                        new Appointment
                        {
                            data = new DateTime(2021,1,14,17,11,30),
                            peso = 80,
                            gorduraCorporal = 35,
                            sensacaoFisicaPaciente = SensacaoFisica.Pessimo,
                            restricoesAlimentares = "carboidratos"
                        }
                    }
                }
            };

            return clients;
        }
    }
}
