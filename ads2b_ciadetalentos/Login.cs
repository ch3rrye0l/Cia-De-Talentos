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
 * Login do Candidato
 * Data..: 19/11/22
 * Autora: Beatriz Santos 11221103762
 */

namespace ads2b_ciadetalentos
{
    public partial class Login : Form
    {
        //Instância
        Candidato cand = new Candidato();

        public Login()
        {
            InitializeComponent();
        }

        //Abrir Form Principal do Candidato caso log in esteja correto
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if ((txtbox_email.Text != cand.getEmail()) || (txtbox_senha.Text != cand.getSenha()))
            {
                this.Hide();
                PrincipalCdd principal = new PrincipalCdd();
                principal.ShowDialog();
            }

            else
            {
                MessageBox.Show("Dados incorretos, tente novamente.", "Cadastro incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
