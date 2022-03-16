using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioMovelProjeto.Models
{
    public class ProfessorModel
    {
        public int ProfessorId { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Observacao { get; set; }

    }
}
