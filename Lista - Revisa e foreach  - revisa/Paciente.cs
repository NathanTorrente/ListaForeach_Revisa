using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista___Revisa_e_foreach____revisa
{
    public class Paciente
    {

        public int Id_paciente { get; set; }
        public string nome { get; set; }    
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataNac { get; set; }

        public Paciente(int id_paciente, string nome, string cpf, string email, DateTime dataNac)
        {
            Id_paciente = id_paciente;
            this.nome = nome;
            Cpf = cpf;
            Email = email;
            DataNac = dataNac;
        }
    }
}
