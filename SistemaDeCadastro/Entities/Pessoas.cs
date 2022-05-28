using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeCadastro.Entities
{
    public class Pessoas
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public string Status { get; set; }

        public string Phone { get; set; }

        public bool Veiculo { get; set; }

        public bool Casa { get; set; }
        public char Sexo { get; set; }


        public override string ToString()
        {
            return Name + ", " + Status + ", Nascimento: " + BirthDate.ToString("dd/MM/yyyy");
        }
    }
}
