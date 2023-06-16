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
 * Login do Administrador
 * Data..: 19/11/22
 * Autora: Beatriz Santos 11221103762
 */

namespace ads2b_ciadetalentos
{
    public partial class Admin : Form
    {
        //Instância
        LoginAdmin admin = new LoginAdmin();

        public Admin()
        {
            InitializeComponent();
        }

        //Abrir Form Principal do Administrador caso o login esteja correto
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (txtbox_useradmin.Text != admin.getUser() || (txtbox_senhaadmin.Text != admin.getSenha()))
            {
                MessageBox.Show("Login do administrador está incorreto!\nTente novamente.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                PrincipalAdmin admin = new PrincipalAdmin();
                admin.ShowDialog();
            }
        }
    }
}
