using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/* 
 * Cadastro do Candidato
 * Data..: 19/11/22
 * Autora: Beatriz Santos 11221103762
 */

namespace ads2b_ciadetalentos
{
    public partial class Cadastro : Form
    {
        //Instância
        Candidato cand = new Candidato();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Set
            cand.setNome(txtbox_nome.Text);
            cand.setEmail(txtbox_emailcdd.Text);
            cand.setSenha(txtbox_senhacdd.Text);
            cand.setCPF(txtbox_cpf.Text);
            
            //Salvar cadastro
            if ((txtbox_nome.Text == null) || (txtbox_emailcdd.Text == null) || (txtbox_senhacdd.Text == null) ||
                (txtbox_confirmar.Text != txtbox_senhacdd.Text) || (txtbox_cpf.Text == null) || (checkbox1 == null))
            {
                MessageBox.Show("Campo(s) nulo(s)!\nPreencha todos os campos para concluir o cadastro", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cia_de_talentos; password='01202328Bb!'"); // Conexão - Server: porta / DB
                                                        //INSERT into candidatos(CPF, nome, email, senha) VALUES ();
                MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO candidatos(CPF, nome, email, senha) VALUES ('"+ cand.getCPF() +"', '"+ cand.getNome() +"', '"+ cand.getEmail() +"', '"+ cand.getSenha() +"');", conexao);

                //Tentar conexão com DB
                try
                {
                    
                    conexao.Open();
                    sqlQuery.ExecuteNonQuery();
                    MessageBox.Show("Dados armazenados com sucesso!", "Salvar dados [DB] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //Fechar o Form atual automaticamente e abrir o Form de Menu
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        //Abrir o Form de Login
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
