using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            tSimulacao = 0;
            timer1.Enabled = true;
            processadorVazio = true;
            for (int i = 0; i < 200; i++)
            {
                vecProcessos[i].id = i;
                vecProcessos[i].tchegada = aleatorio.Next(0, 5001);
                vecProcessos[i].texecucao = aleatorio.Next(10, 50);
                vecProcessos[i].estado = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tSimulacao++;
            label2.Text = "" + tSimulacao;

            for (int i = 0; i < 200; i++) //verificar se chegou algum processo
            {
                if (tSimulacao == vecProcessos[i].tchegada) //coloca o processo na fila de espera
                {
                    label1.Text += "\nProcesso " + vecProcessos[i].id + " está em espera";
                    filaProcessos.Enqueue(vecProcessos[i]);
                    vecProcessos[i].estado = 1;
                }
            }

            if (processadorVazio) //se o processador estiver vazio executa o processo
            {
                if (filaProcessos.Count != 0)
                {
                    processoNoProcessador = filaProcessos.Dequeue();
                    processadorVazio = false;
                    processoNoProcessador.estado = 2;
                    label3.Text = "Processo no processador -> " + processoNoProcessador.id;
                    tempoSaidaProcessador = tSimulacao + processoNoProcessador.texecucao; //Somar o tempo comutacao
                }
            }

            if (tSimulacao == tempoSaidaProcessador) //verifica se algum processo está a sair do processador
            {
                processadorVazio = true;
                processoNoProcessador.estado = 3;
                label4.Text += "\n Terminou " + processoNoProcessador.id;
                label3.Text = "O processador está vazio";
            }

        }


    }
}
