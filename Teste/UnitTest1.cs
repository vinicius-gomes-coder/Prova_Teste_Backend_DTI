using Escritorio_Nutricionista.Models;
using Escritorio_Nutricionista;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Escritorio_Nutricionista.Util;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRegisterClient()
        {           
            List<Client> clients = new List<Client>();            

            Service.RegisterClient(clients, MockClient());

            Assert.AreEqual(MockClient().nome, clients[clients.Count - 1].nome);
            Assert.AreEqual(MockClient().endereco, clients[clients.Count - 1].endereco);
            Assert.AreEqual(MockClient().email, clients[clients.Count - 1].email);
            Assert.AreEqual(MockClient().telefone, clients[clients.Count - 1].telefone);
            Assert.AreEqual(MockClient().dataNascimento, clients[clients.Count - 1].dataNascimento);
        }

        [TestMethod]
        public void TestAppointment()
        {
            Client client = MockClient();

            Service.Appointment(MockDietOptionsList(MockAlimentoList(MockAlimento(1,"banana",600))), MockAppointment(), client);

            Assert.AreEqual(MockAppointment().data, client.Consultas[client.Consultas.Count - 1].data);
            Assert.AreEqual(MockAppointment().peso, client.Consultas[client.Consultas.Count - 1].peso);
            Assert.AreEqual(MockAppointment().gorduraCorporal, client.Consultas[client.Consultas.Count - 1].gorduraCorporal);
            Assert.AreEqual(MockAppointment().restricoesAlimentares, client.Consultas[client.Consultas.Count - 1].restricoesAlimentares);
            Assert.AreEqual(MockAppointment().sensacaoFisicaPaciente, client.Consultas[client.Consultas.Count - 1].sensacaoFisicaPaciente);
        }

        [TestMethod]
        public void FindDiet()
        {
            List<DietOptions> optionsDiet = UtilGeral.FindDiet(2000,MockFoodList(MockAlimento(1,"banana",500)), MockFoodList(MockAlimento(2, "macarrão", 500)), MockFoodList(MockAlimento(3, "leite", 500)));

            for (int i=0; i < MockDietOptionsList2().Count; i++)
            {
                DietOptions op = MockDietOptionsList2()[i];

                for (int j=0; j < op.dietOptions.Count; j++)
                {
                    Food food = op.dietOptions[j];

                    Assert.AreEqual(food.name, optionsDiet[i].dietOptions[j].name);
                    Assert.AreEqual(food.group, optionsDiet[i].dietOptions[j].group);
                    Assert.AreEqual(food.calory, optionsDiet[i].dietOptions[j].calory);
                }
            }                       
        }

        private List<DietOptions> MockDietOptionsList2()
        {
            return new List<DietOptions>
            {
                new DietOptions
                {
                    dietOptions = new List<Food>
                    {
                       new Food
                       {
                           group = 1,
                           name = "banana",
                           calory = 500
                       },
                       new Food
                       {
                           group = 2,
                           name = "macarrão",
                           calory = 500
                       },
                       new Food
                       {
                           group = 3,
                           name = "leite",
                           calory = 500
                       }
                    }
                }                
            };
        }

        private Client MockClient()
        {
            return new Client
            {
                nome = "Alexandre Carvalho",
                endereco = "Rua Nestor, 566, Centro, Ouro Branco - MG",
                telefone = "997452138",
                email = "alexandre.carvalho@gmail.com",
                dataNascimento = new DateTime(1995, 8, 14),
                Consultas = new List<Appointment>()
            };
        }

        private Appointment MockAppointment()
        {
            return new Appointment
            {
                data = new DateTime(2021,08,29,12,0,0),
                gorduraCorporal = 35,
                peso = 70,
                sensacaoFisicaPaciente = SensacaoFisica.Normal,
                restricoesAlimentares = "açúcar"
            };
        }

        private List<DietOptions> MockDietOptionsList(DietOptions foodList)
        {
            return new List<DietOptions>
            {
                foodList
            };
        }        

        private DietOptions MockAlimentoList(Food food)
        {
            return new DietOptions
            {
                dietOptions = new List<Food>
                {
                    food
                }
            };
        }

        private List<Food> MockFoodList (Food food)
        {
            return new List<Food>
            {
                food
            };
        }

        private Food MockAlimento(int group, string name, double calory)
        {
            return new Food
            {
                group = group,
                name = name,
                calory = calory
            };
        }
    }
}
