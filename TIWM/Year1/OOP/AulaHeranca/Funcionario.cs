using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaHeranca
{
    class Funcionario : Pessoa
    {
        private string funcao;
        private double ordenado;

        public Funcionario()
        {
            funcao = "";
            ordenado = 0;
        }

        public Funcionario(string nNome, string nEmail, string nCidade, 
            int nDia, int nMes, int nAno, string nFuncao, double nOrdenado)
        {
            SetNome(nNome);
            SetEmail(nEmail);
            SetCidade(nCidade);
            SetDataNasc(nDia, nMes, nAno);
            funcao = nFuncao;
            ordenado = nOrdenado;
        }
        public void SetFuncao(string nFuncao)
        {
            funcao = nFuncao;
        }
        public string GetFuncao()
        {
            return funcao;
        }
        public void SetOrdenado(double nOrdenado)
        {
            ordenado = nOrdenado;
        }
        public void SetOrdenado(string nOrdenado)
        {
            ordenado = double.Parse(nOrdenado);
        }
        public double GetOrdenado()
        {
            return ordenado;
        }
        public string TextoFicheiro()
        {
            return GetNome() + ";" + GetEmail() + ";" + GetCidade() + ";" + GetDataNasc().GetDia().ToString() + ";" + GetDataNasc().GetMes().ToString() + ";" + GetDataNasc().GetAno().ToString() + ";" + funcao + ";" + ordenado;
        }

        public override string ToString()
        {
            return GetNome();
        }
    }
}
