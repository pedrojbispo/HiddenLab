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

namespace AulaHeranca
{
    public partial class FormCF : Form
    {
        int tipo; //1 Cliente 2 Funcionario
        public FormCF(int tipo)
        {
            InitializeComponent();

            this.tipo = tipo;
        }

        private void FormCF_Load(object sender, EventArgs e)
        {
            switch(tipo)
            {
                case 1:
                    this.Text = "Adicionar Cliente";
                    labelOrdenado.Visible = false;
                    textBoxOrdenado.Visible = false;
                    labelTF.Text = "Tipo:";
                    comboBoxTF.Items.Add("Normal");
                    comboBoxTF.Items.Add("Silver");
                    comboBoxTF.Items.Add("Gold");
                    break;
                case 2:
                    this.Text = "Adicionar Funcionário";
                    labelOrdenado.Visible = true;
                    textBoxOrdenado.Visible = true;
                    labelTF.Text = "Função:";
                    comboBoxTF.Items.Add("Gestor");
                    comboBoxTF.Items.Add("Operador");
                    comboBoxTF.Items.Add("Segurança");
                    comboBoxTF.Items.Add("Repositor");
                    break;
                default:
                    break;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(tipo == 1)
            {
                Cliente c = new Cliente(textBoxNome.Text, textBoxEmail.Text, textBoxCidade.Text, 
                    dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, comboBoxTF.Text);

                StreamWriter sw = new StreamWriter("Clientes.txt",true);
                sw.WriteLine(c.TextoFicheiro());
                sw.Close();
            }
            else
            {
                Funcionario f = new Funcionario(textBoxNome.Text, textBoxEmail.Text, textBoxCidade.Text, 
                    dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, 
                    comboBoxTF.Text, double.Parse(textBoxOrdenado.Text));


                StreamWriter sw = new StreamWriter("Funcionarios.txt", true);
                sw.WriteLine(f.TextoFicheiro());
                sw.Close();
            }

            this.Close();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
