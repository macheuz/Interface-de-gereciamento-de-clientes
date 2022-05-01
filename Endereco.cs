using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_de_cadastro_de_usuarios_em_txt
{
    public class Endereco
    {
        private int numero = 0;
        private string rua  = "rua";
        private string bairro = "bairro";
        private string cidade = "cidade";
        private string estado = "estado";

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
