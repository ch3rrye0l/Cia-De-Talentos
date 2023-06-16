using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Funcionamento dos botões do Forms de Menu
 * Data..: 19/11/22
 * Autora: Beatriz Santos 11221103762
 */

namespace ads2b_ciadetalentos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Abrir Forms de Cadastro
        private void btt_Signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            cadastro = null;
            this.Show();
        }

        //Abrir Forms de Login
        private void btt_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            login = null;
            this.Show();
        }

        //Abrir Forms de Login do Administrador
        private void btt_LoginAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.ShowDialog();
            admin = null;
            this.Show();
        }
    }
}
