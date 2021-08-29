using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritorio_Nutricionista.Models
{
    public class Appointment
    {
        public DateTime data { get; set; }
        public double peso { get; set; }
        public double gorduraCorporal { get; set; }
        public SensacaoFisica sensacaoFisicaPaciente { get; set; }
        public string restricoesAlimentares { get; set; }
        
    }
    
}
