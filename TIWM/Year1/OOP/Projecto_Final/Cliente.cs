using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaHeranca
{
    class Cliente : Pessoa
    {
        private string tipo;
        private List<Produto> produtosFav;

        public Cliente()
        {
            tipo = "";
            produtosFav = new List<Produto>();
        }
        public Cliente(string nNome, string nEmail, string nCidade, int nDia, int nMes, int nAno, string nTipo)
        {
            SetNome(nNome);
            SetEmail(nEmail);
            SetCidade(nCidade);
            SetDataNasc(nDia,nMes,nAno);
            tipo = nTipo;
            produtosFav = new List<Produto>();
        }

        public void SetTipo(string nTipo)
        {
            tipo = nTipo;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public List<Produto> GetProdutosFav()
        {
            return produtosFav;
        }
        public void AdicionarProdFav(Produto p)
        {
            produtosFav.Add(p);
        }

        public string TextoFicheiro()
        {
            return GetNome() + ";" + GetEmail() + ";" + GetCidade() + ";" + GetDataNasc().GetDia().ToString() + ";" + GetDataNasc().GetMes().ToString() + ";" + GetDataNasc().GetAno().ToString() + ";" + tipo;
        }
        public override string ToString()
        {
            return GetNome() + " - " + tipo;
        }
    }
}
