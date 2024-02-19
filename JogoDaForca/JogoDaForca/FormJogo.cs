using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }

        string letrasTentadas = "";
        string palavra_secreta = "";

        private void FormJogo_Load(object sender, EventArgs e)
        {
            palavra_secreta = SortearPalavra();
            lbPalavraSecreta.Text = VerificarPalavra(palavra_secreta.ToCharArray(), letrasTentadas.ToCharArray());
        }

        private string SortearPalavra()
        {
            // Lista de Palavras
            List<string> palavras = new List<string> { "csharp", "python", "ruby", "php", "javascript" };

            Random rnd = new Random();
            int indiceSorteado = rnd.Next(0, palavras.Count);

            //Recuperar a palavra correspondente ao índice sorteado
            string palavraSorteada = palavras[indiceSorteado];

            return palavraSorteada;
        }

        private char[] SepararLetraPalavra(string palavra)
        {
            //criando um array do tamanho da palavra que foi sorteada
            char[] letrasPalavra = new char[palavra.Length];
            letrasPalavra = palavra.ToCharArray();

            return letrasPalavra;
        }

        private string VerificarPalavra (char[] palavra, char[] letrasTentadas)
        {
            string palavra_escondida = "";

            //laço de repetição para "esconder" a palavra
            for (int i = 0; i < palavra.Length; i++)
            {
                bool letraAcertada = false;
                for (int j = 0; j < letrasTentadas.Length; j++)
                {
                    if (palavra[i] == letrasTentadas[j])
                    {
                        palavra_escondida += palavra[i];
                        letraAcertada = true;
                    }
                }

                if (!letraAcertada)
                {
                    palavra_escondida += " _";
                }
            }
            return palavra_escondida;


        }




        private void btnVerificarLetra_Click(object sender, EventArgs e)
        {
            string letra = txbTentativa.Text.ToLower();

            bool letraRepetida = false;
            for (int i = 0; i < letrasTentadas.Length; i++)
            {
                //letraRepetida = false;
                if (letrasTentadas[i].ToString() == letra)
                {
                    MessageBox.Show("Essa letra já foi jogada, tente novamente!");
                    letraRepetida = true;
                }
            }

            int verificarSeGanhou = 1;

            if (!letraRepetida)
            {
                letrasTentadas += letra;
                char[] letrasDaPalavra = SepararLetraPalavra(palavra_secreta);
                string palavra_exibicao = VerificarPalavra(letrasDaPalavra, letrasTentadas.ToCharArray());

                lbPalavraSecreta.Text = palavra_exibicao;

                verificarSeGanhou = 0;
                for (int i = 0; i < palavra_exibicao.Length; i++)
                {
                    if (palavra_exibicao[i] == '_')
                    {
                        verificarSeGanhou++;
                    }
                }
            }

            if (verificarSeGanhou == 0)
            {
                MessageBox.Show("Você Ganhou!!!");
                this.Close();
            }

            letraRepetida = false;
            txbTentativa.Text = "";
        }
    }
}
