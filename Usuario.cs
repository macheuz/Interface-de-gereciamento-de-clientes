using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_de_cadastro_de_usuarios_em_txt
{
    public class Usuario
    {
        private string nome = "nome";
        private string data  = "data";
        private string telefone = "telefone";
        private Endereco endereco;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
