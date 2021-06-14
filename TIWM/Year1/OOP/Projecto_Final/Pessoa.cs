using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaHeranca
{
    class Pessoa
    {
        private string nome;
        private string email;
        private string cidade;
        private Data dataNasc;

        public Pessoa()
        {
            nome = "";
            email = "";
            cidade = "";
            dataNasc = new Data();
        }
        public Pessoa(string nNome, string nEmail, string nCidade, Data nDataNAsc)
        {
            nome = nNome;
            email = nEmail;
            cidade = nCidade;
            dataNasc = nDataNAsc;
        }
        public Pessoa(string nNome, string nEmail, string nCidade, int nDia, int nMes, int nAno)
        {
            nome = nNome;
            email = nEmail;
            cidade = nCidade;
            dataNasc = new Data(nDia, nMes, nAno);
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nNome)
        {
            nome = nNome;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string nEmail)
        {
            email = nEmail;
        }
        public string GetCidade()
        {
            return cidade;
        }
        public void SetCidade(string nCidade)
        {
            cidade = nCidade;
        }
        public Data GetDataNasc()
        {
            return dataNasc;
        }
        public void SetDataNasc(Data nDataNasc)
        {
            dataNasc = nDataNasc;
        }
        public void SetDataNasc(int nDia, int nMes, int nAno)
        {
            dataNasc.SetDia(nDia);
            dataNasc.SetMes(nMes);
            dataNasc.SetAno(nAno);
        }

        public int GetIdade()
        {
            int idade = DateTime.Now.Year - dataNasc.GetAno();

            if (dataNasc.GetMes() > DateTime.Now.Month)
            {
                idade = idade - 1;
            }
            else if (dataNasc.GetMes() == DateTime.Now.Month)
            {
                if(dataNasc.GetDia() > DateTime.Now.Day)
                {
                    idade = idade - 1;
                }
            }

            return idade;
        }

        public string ExportarFich()
        {
            return nome + "/" + email + "/" + cidade + "/" + dataNasc;
        }

        public override string ToString()
        {
            return nome + " - " + dataNasc;
        }

    }
}
