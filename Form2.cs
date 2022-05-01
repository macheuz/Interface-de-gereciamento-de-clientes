using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;

namespace interface_de_cadastro_de_usuarios_em_txt
{
    public partial class formularioNovosUsuarios : Form
    {
        private Usuario novo;
        public formularioNovosUsuarios()
        {
            InitializeComponent();
        }
        private Endereco retornaEndereco()
        {
            Endereco endereco = new Endereco();
            endereco.Rua = textRua1.Text;
            endereco.Rua = endereco.Rua.ToUpper();
            endereco.Bairro = textBairro1.Text;
            endereco.Bairro = endereco.Bairro.ToUpper();
            endereco.Cidade = textCidade1.Text;
            endereco.Cidade = endereco.Cidade.ToUpper();
            endereco.Estado = textEstado1.Text;
            endereco.Estado = endereco.Estado.ToUpper();
            endereco.Numero = Convert.ToInt32(textNumero1.Text);
            return endereco;
        }

        private bool EscreveContas(Usuario novo)
        {
            string dirArquivo = @"C:\Users\Matheus\Documents\Users Registration\programa de cadastro de usuarios\interface de cadastro de usuarios em txt\TextFile1.txt";
            using (StreamWriter writer = new StreamWriter(@dirArquivo, true))
            {
                writer.WriteLine();
                    writer.Write("{0};",novo.Nome);
                    writer.Write("{0};",novo.Data);
                    writer.Write("{0};",novo.Telefone);
                    writer.Write("{0};",novo.Endereco.Rua);
                    writer.Write("{0};",novo.Endereco.Numero);
                    writer.Write("{0};",novo.Endereco.Bairro);
                    writer.Write("{0};",novo.Endereco.Cidade);
                    writer.Write("{0}",novo.Endereco.Estado);
                return true;
            }
            return false;
        }

        private void formularioNovosUsuarios_Load(object sender, EventArgs e)
        {
            this.novo = new Usuario();
            
        }

        private void BotaoCadastrar_Click(object sender, EventArgs e)
        {
            this.novo.Telefone = textNumerotelefone1.Text;
            this.novo.Nome = textNome1.Text;
            this.novo.Nome = novo.Nome.ToUpper();
            this.novo.Data = textDatadeNascimento1.Text;
            this.novo.Endereco = retornaEndereco();
            bool x = EscreveContas(this.novo);
            if (x)
            {
               MessageBox.Show("Cadastro com Sucesso");
            }
            else
            {
                MessageBox.Show("Cadastro invalido");
            }
            
        }
    }
}
