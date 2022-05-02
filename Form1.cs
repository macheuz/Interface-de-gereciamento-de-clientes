
using System;
using System.IO;

namespace interface_de_cadastro_de_usuarios_em_txt
{
    public partial class Form1 : Form
    {
        private string[,] usuarios;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.usuarios = TransformandoTXT();
            for (int x = 0; x < this.usuarios.GetLength(0); x++)
            {
                comboBox1.Items.Add(usuarios[x, 0]);
            }

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
            string bus = textBuscarUsuario.Text;
            bus = bus.ToUpper();
            for(int x=0; x<this.usuarios.GetLength(0); x++)
            {
                    if (this.usuarios[x, 0] == bus)
                    {
                    textNome.Text = this.usuarios[x, 0];
                    textDatadeNascimento.Text = this.usuarios[x, 1];
                    textNumerotelefone.Text = this.usuarios[x, 2];
                    textRua.Text = this.usuarios[x, 3];
                    textNumero.Text = this.usuarios[x, 4];
                    textBairro.Text = this.usuarios[x, 5];
                    textCidade.Text = this.usuarios[x, 6];
                    textEstado.Text = this.usuarios[x, 7];

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
            formularioNovosUsuarios formulario = new formularioNovosUsuarios(this);
            formulario.Owner = this;
            formulario.Show();
            TransformandoTXT();
        }


        private void BotaoBuscarSelecionado(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboBox1.Text);
            textNome.Text = this. usuarios[indice, 0];
            textDatadeNascimento.Text = this.usuarios[indice, 1];
            textNumerotelefone.Text = this.usuarios[indice, 2];
            textRua.Text = this.usuarios[indice, 3];
            textNumero.Text = this.usuarios[indice, 4];
            textBairro.Text = this.usuarios[indice, 5];
            textCidade.Text = this.usuarios[indice, 6];
            textEstado.Text = this.usuarios[indice, 7];
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            textNome.Text = this.usuarios[indice, 0];
            textDatadeNascimento.Text = this.usuarios[indice, 1];
            textNumerotelefone.Text = this.usuarios[indice, 2];
            textRua.Text = this.usuarios[indice, 3];
            textNumero.Text = this.usuarios[indice, 4];
            textBairro.Text = this.usuarios[indice, 5];
            textCidade.Text = this.usuarios[indice, 6];
            textEstado.Text = this.usuarios[indice, 7];

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}