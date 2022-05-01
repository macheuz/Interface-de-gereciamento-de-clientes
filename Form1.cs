
using System;
using System.IO;

namespace interface_de_cadastro_de_usuarios_em_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string [,] TransformandoTXT()
        {
            string[,] usuariosTxt;
            int cont = 0;
            string dirArquivo = @"C:\Users\Matheus\Documents\Users Registration\programa de cadastro de usuarios\interface de cadastro de usuarios em txt\TextFile1.txt";
            using (StreamReader leitor = new StreamReader(dirArquivo))
            {
                string linh;
                while ((linh = leitor.ReadLine()) != null)
                {
                    cont = cont + 1;
                }

                usuariosTxt = new string[cont, 8];
                var texto = File.ReadAllText(dirArquivo);

                int i = 0, j = 0;
                foreach (var linha in texto.Split('\n'))
                {
                    foreach (var letra in linha.Split(';'))
                    {
                        usuariosTxt[i, j] = letra;
                        j++;
                    }
                    i++;
                    j = 0;
                }
            }
            return usuariosTxt;
            
            
            
        }

        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            bool valida = false;
            string[,] usuariosTxt = TransformandoTXT();
            string bus = textBuscarUsuario.Text;
            bus = bus.ToUpper();
            for(int x=0; x<usuariosTxt.GetLength(0); x++)
            {
                    if (usuariosTxt[x, 0] == bus)
                    {
                    textNome.Text = usuariosTxt[x, 0];
                    textDatadeNascimento.Text = usuariosTxt[x, 1];
                    textNumerotelefone.Text = usuariosTxt[x, 2];
                    textRua.Text = usuariosTxt[x, 3];
                    textNumero.Text = usuariosTxt[x, 4];
                    textBairro.Text = usuariosTxt[x, 5];
                    textCidade.Text = usuariosTxt[x, 6];
                    textEstado.Text = usuariosTxt[x, 7];

                    valida = true;
                    }

            }
            if (valida)
            {
                MessageBox.Show("Usuario Encontrado!");
            }
            else
            {
                MessageBox.Show("Usuario nao encontrado!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BotaoCadastrar_Click(object sender, EventArgs e)
        {
            formularioNovosUsuarios formulario = new formularioNovosUsuarios();
            formulario.ShowDialog();
        }
    }
}