using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Classe: Informações do Administrador
 * Data..: 19/11/22
 * Autora: Beatriz Santos 11221103762
 */

namespace ads2b_ciadetalentos
{
    class LoginAdmin
    {
        //Declaração de atributos
        private string user;
        private string senha;

        //Método Construtor
        public LoginAdmin()
        {
            this.user = "admin123";
            this.senha = "admin123";
        }

        public string getUser() { return user; }
        public string getSenha() { return senha; }
    }
}
