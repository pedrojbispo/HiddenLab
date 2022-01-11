using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Produtos.txt");
            string linha = sr.ReadLine();
            string[] auxLinha;
            
            while (linha != null)
            {
                auxLinha = linha.Split('|');

                listBoxProdutos.Items.Add(new Games(auxLinha[0], double.Parse(auxLinha[1])));

                linha = sr.ReadLine();
            }
            sr.Close();

            sr = new StreamReader("Clientes.txt");
            linha = sr.ReadLine();

            while (linha != null)
            {
                auxLinha = linha.Split(';');

                comboBoxClie.Items.Add(new Cliente(auxLinha[0], auxLinha[1], auxLinha[2], int.Parse(auxLinha[3]), int.Parse(auxLinha[4]), int.Parse(auxLinha[5]), auxLinha[6]));

                linha = sr.ReadLine();
            }
            sr.Close();

            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void listBoxProdutos_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxProdutos.SelectedItem != null)
            {
                Games pSelect = listBoxProdutos.SelectedItem as Games;

                listBoxCarrinho.Items.Add(pSelect);
                AtualizarValorCarrinho();
            }
        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCF fC = new FormCF(1);
            fC.Show();
        }

        private void adicionarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCF fF = new FormCF(2);
            fF.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void AtualizarValorCarrinho()
        {
            double valor = 0;
            double valorDeconto = 0;

            panelCBCliente.BackColor = Color.Transparent;

            foreach (Games p in listBoxCarrinho.Items)
            {
                valor += p.GetPreco();
            }

            string tipo = "";
            
            if(comboBoxClie.SelectedItem != null)
            {
                tipo = (comboBoxClie.SelectedItem as Cliente).GetTipo();
            }


            switch (tipo)
            {
                case "Normal":
                    labelValor.Text = "Total: " + valor + "€";
                    break;
                case "Silver":
                    valorDeconto = valor * 0.9;
                    labelValor.Text = "Total: " + valor + "€   Total c/ desconto: " + valorDeconto + "€";
                    break;
                case "Gold":
                    valorDeconto = valor * 0.85;
                    labelValor.Text = "Total: " + valor + "€   Total c/ desconto: " + valorDeconto + "€";
                    break;
                default:
                    labelValor.Text = "Inserir cliente para calcular o total.";
                    panelCBCliente.BackColor = Color.Red;
                    break;
            }
        }

        private void comboBoxClie_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValorCarrinho();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxCarrinho.Items.Clear();
            labelValor.Text = "Total: ";
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBoxCarrinho.SelectedIndex >= 0)
            {
                listBoxCarrinho.Items.RemoveAt(listBoxCarrinho.SelectedIndex);
            }
        }

        private void listBoxCarrinho_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxCarrinho.SelectedIndex = listBoxCarrinho.IndexFromPoint(e.Location);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listBoxCarrinho.SelectedIndex < 0)
            {
                e.Cancel = true;
            }
        }
    }
}
