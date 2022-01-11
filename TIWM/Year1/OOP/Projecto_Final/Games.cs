using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Final
{
    class Games
    {
        private string nome;
        private double preco;

        public Games()
        {
            nome = "";
            preco = 0;
        }
        public Games(string nNome, double nPreco)
        {
            nome = nNome;
            preco = nPreco;
        }

        public void SetNome(string nNome)
        {
            nome = nNome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetPreco(double nPreco)
        {
            preco = nPreco;
        }
        public void SetPreco(string nPreco)
        {
            preco = double.Parse(nPreco);
        }
        public double GetPreco()
        {
            return preco;
        }

        public override string ToString()
        {
            return nome + " - " + preco + " €";
        }
    }
}
