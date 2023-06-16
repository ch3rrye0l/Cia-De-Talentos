using System;

/* 
 * Classe: Informações do Candidato
 * Data..: 19/11/22
 * Autora: Beatriz Santos 11221103762
 */

namespace ads2b_ciadetalentos
{
    class Candidato
    {
        //Declaração de atributos
        private string nome;
        private string email;
        private string senha;
        private string CPF;

        //Método construtor
        public Candidato()
        {
            this.nome = "";
            this.email = "";
            this.senha = "";
            this.CPF = "";
        }

        //GetSet
        public void setNome (string p_nome) { this.nome = p_nome; }
        public string getNome() { return nome; }

        public void setEmail (string p_email) { this.email = p_email; }
        public string getEmail() { return email; }

        public void setSenha(string p_senha) { this.senha = p_senha; }
        public string getSenha() { return senha; }

        public void setCPF(string p_cpf) { this.CPF = p_cpf; }
        public string getCPF() { return CPF; }
    }
}
