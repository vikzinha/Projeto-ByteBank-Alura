using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        //método construtor -> padrão recebe o mesmo nome da classe /smp publico

        public Cliente() 
        {
            
        }

    }
}
