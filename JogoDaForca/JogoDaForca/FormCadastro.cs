using MySql.Data.MySqlClient;
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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            
            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString)) // Estabelece a conexão com o banco de dados MySQL usando a classe MySqlConnection.
            {
                string scriptSQL = "SELECT id, palavra FROM tb_palavras";

                using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao)) // cria um comando MySQL com a consulta SQL e a conexão estabelecida.
                {
                    conexao.Open();
                    

                    using (MySqlDataReader reader = command.ExecuteReader()) // Executa o comando SQL para recuperar os dados do banco de dados.
                    {
                        while (reader.Read()) // Itera sobre cada registro retornado pela consulta.
                        {
                            int id = reader.GetInt32(0); // obtém o valor do primeiro campo (ID) como um inteiro.
                            string palavra = reader.GetString(1); // obtém o valor do segundo campo (palavra) como uma string.

                            ListViewItem lista = new ListViewItem(id.ToString() + " - " + palavra); // cria um novo item do list view com o id e palavra concatenados.
                            ListViewCadastro.Items.Add(lista); //Adiciona o novo item ao LitViewCadastro
                           
                        }
                    }
                    conexao.Close(); //fecha a conexao com o banco de dados após recuperar todas as palavras.
                }
            }

        }
        private void CadastrarDados(string palavra)
        {
            
            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString)) 
                {
                    string scriptSQL = "INSERT INTO tb_palavras (palavra) VALUES (@valorPalavra)"; //Define o script de insert do banco de dados. 

                    using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao)) 
                    {
                        conexao.Open();

                        command.Parameters.AddWithValue("@valorPalavra", palavra); //Adiciona o parametro da informação ao comando SQL para eitar SQL Injection

                        int linhasAfetadas = command.ExecuteNonQuery();

                        if (linhasAfetadas > 0) //Verifica se pelo menos uma linha foi afetada, ou seja, inserida uma nova palavra com sucesso.
                        {
                            MessageBox.Show("Palavra cadastrada com sucesso");
                        }
                        
                        conexao.Close(); 
                    }
                }   
            }
            catch(Exception ex)
            {
                //Se ocorrer uma exceção durante o processo, exibe o erro na tela
                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            ListViewCadastro.View = View.Details; //define a visualização do list view em 'Deatils' que exibirá os itens em forma de tabela.
            ListViewCadastro.Columns.Add("palavras", 255); //Adiciona uma coluna ao list view com o título 'palavras' e largura de 255 pixels.

            CarregarDados();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            string palavraEscolhida = txbCadastro.Text.ToLower();
            if (palavraEscolhida.Trim() != "")
            {

                CadastrarDados(palavraEscolhida);
            }

            txbCadastro.Text = "";
            ListViewCadastro.Items.Clear();
            CarregarDados();

        }

        private void txbCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13)
            {
                btnCadastrar_Click (sender, e);
                
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";
            string id = txbRemover.Text;

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string remover = "DELETE FROM tb_palavras WHERE id=@id";

                using (MySqlCommand command = new MySqlCommand(remover, conexao)) 
                {
                    conexao.Open();

                    command.Parameters.AddWithValue("@id", id);

                    int linhasAfetadas = command.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Palavra removida!");
                    }
                   

                    conexao.Close(); 
                    ListViewCadastro.Items.Clear();
                    CarregarDados();
                    
                }
            }

        }
    }
}
