using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio_Nutricionista.Models
{
    public class Food
    {
        public int group { get; set; }
        public string name { get; set; }
        public double calory { get; set; }

        public List<Food> StartListGroup1 ()
        {
            List<Food> group1Foods = new List<Food>
            {
                new Food
                {
                    group = 1,
                    name = "Arroz",
                    calory = 500
                },
                new Food
                {
                    group = 1,
                    name = "Macarrão",
                    calory = 1000
                },
                new Food
                {
                    group = 1,
                    name = "Pão",
                    calory = 700
                }
            };

            return group1Foods;
        }

        public List<Food> StartListGroup2()
        {
            List<Food> group2Foods = new List<Food>
            {
                new Food
                {
                    group = 2,
                    name = "Queijo",
                    calory = 500
                },
                new Food
                {
                    group = 2,
                    name = "Iorgute",
                    calory = 400
                },
                new Food
                {
                    group = 2,
                    name = "Leite",
                    calory = 200
                }
            };

            return group2Foods;
        }

        public List<Food> StartListGroup3()
        {
            List<Food> group3Foods = new List<Food>
            {
                new Food
                {
                    group = 3,
                    name = "Batata",
                    calory = 700
                },
                new Food
                {
                    group = 3,
                    name = "Carne vermelha",
                    calory = 1000
                },
                new Food
                {
                    group = 3,
                    name = "Ovo",
                    calory = 600
                }
            };

            return group3Foods;
        }
    }
}
