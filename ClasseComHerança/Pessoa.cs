using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseComHerança
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;

        // Método construtor sem parâmetro
        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
        }

        // Construtor com parâmetro

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        // Propriedades dos atributos para acesso

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        // Método da classe ImprimeDados
        // public abstract String ImprimeDados();

    }   
        
}
