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
 * Página principal do administrador
 * Data..: 19/11/22
 * Autora: Beatriz Santos 11221103762
 */

namespace ads2b_ciadetalentos
{
    public partial class PrincipalAdmin : Form
    {
        //Instância
        Candidato cand = new Candidato();
        int qtd_registros = 0;

        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
            // Exibir ao carregar form
            dataGridView1.Rows.Clear();
            qtd_registros = 0;

            //DB
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=cia_de_talentos; password='01202328Bb!'");
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM candidatos", conexao);

            try
            {
                conexao.Open();
                MySqlDataReader datReader = sqlQuery.ExecuteReader();

                while (datReader.Read())
                {
                    object[] registro = new object[datReader.FieldCount];
                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < datReader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(datReader.GetName(i), datReader.GetName(i));
                        }
                    }
                    for (int i = 0; i < datReader.FieldCount; i++)
                    {
                        registro[i] = datReader.GetValue(i);
                    }
                    dataGridView1.Rows.Add(registro);
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conexao.Close(); }
        }
    }
}
