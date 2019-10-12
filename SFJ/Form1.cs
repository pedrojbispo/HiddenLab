using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SFJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Processo
        {
            public int id;
            public int tchegada;
            public int texecucao;
            public int estado; //0 - não iniciado 1 - em espera 2 - execução 3 - terminou
        }

        Random aleatorio = new Random();
        Processo[] vecProcessos = new Processo[200];
        int tSimulacao;
        int tempoSaidaProcessador;
        bool processadorVazio;

        Processo processoNoProcessador;

        List<Processo> filaProcessos = new List<Processo>();

        private void start_Click(object sender, EventArgs e)
        {
            tSimulacao = 0;
            timer1.Enabled = true;
            processadorVazio = true;
            for (int i = 0; i < 200; i++)
            {
                vecProcessos[i].id = i;
                vecProcessos[i].tchegada = aleatorio.Next(0, 2000);
                vecProcessos[i].texecucao = aleatorio.Next(10, 50);
                vecProcessos[i].estado = 0;
                list_S.Items.Add(vecProcessos[i].id);
                count1.Text = list_S.Items.Count.ToString();
                stop.Enabled = true;
                start.Enabled = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tSimulacao++;
            timer.Text = "" + tSimulacao;

            for (int i = 0; i < 200; i++) //verificar se chegou algum processo
            {
                if (tSimulacao == vecProcessos[i].tchegada) //coloca o processo na fila de espera
                {
                    list_W.Items.Add(vecProcessos[i].id);
                    count2.Text = list_W.Items.Count.ToString();
                    int posicaoProcessoMaisProximo = filaProcessos.FindLastIndex(x => x.texecucao <= vecProcessos[i].texecucao); // Descobrir processo com o tempo de execucao menor mais proximo
                    if(posicaoProcessoMaisProximo != -1 && filaProcessos.ElementAt(posicaoProcessoMaisProximo).texecucao == vecProcessos[i].texecucao) // Se o processo encontrado tem o mesmo texecucao
                    {
                        if(filaProcessos.ElementAt(posicaoProcessoMaisProximo).tchegada <= vecProcessos[i].tchegada) // Dos dois que tem o mesmo texecucao descobrir o que tem menor tchegada
                        {
                            filaProcessos.Insert(posicaoProcessoMaisProximo + 1, vecProcessos[i]); // Se o processo que ja esta na fila tem menor entao o novo fica na posicao seguinte
                        } else
                        {
                            filaProcessos.Insert(posicaoProcessoMaisProximo, vecProcessos[i]); // Se o processo que ja esta na fila tem maior texecucao entao o novo fica na sua posicao e o antigo anda uma para frente
                        }
                    } else
                    {
                        filaProcessos.Insert(posicaoProcessoMaisProximo + 1, vecProcessos[i]); // Adiciona novo processo no final da lista
                    }
                    vecProcessos[i].estado = 1;
                }
            }
            if (processadorVazio) //se o processador estiver vazio executa o processo
            {
                if (list_W.Items.Count != 0)
                {
                    processoNoProcessador = filaProcessos.ElementAt(0); // Descobrir o processo no topo da lista
                    filaProcessos.RemoveAt(0); // Remover o processo do topo da lsita
                    list_W.Items.Remove(processoNoProcessador.id); // Remover o id da lista de espera
                    count2.Text = list_W.Items.Count.ToString();
                    processadorVazio = false;
                    processoNoProcessador.estado = 2;
                    processoNoProcessador.estado = 2;
                    label_P.Text = processoNoProcessador.id + " ";
                    cputime.Text = processoNoProcessador.texecucao + " ms";
                    tempoSaidaProcessador = tSimulacao + processoNoProcessador.texecucao; //Somar o tempo comutacao
                }
            }
           
            if (tSimulacao == tempoSaidaProcessador) //verifica se algum processo está a sair do processador
            {
                processadorVazio = true;
                processoNoProcessador.estado = 3;
                list_E.Items.Add(processoNoProcessador.id);
                label_P.Text = "Vazio";
                count3.Text = list_E.Items.Count.ToString();
            }
            if(list_E.Items.Count == 200)
            {
                timer1.Enabled = false;
                stop.Enabled=false;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void kill_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                stop.Text = "Unpause";
            }
            else
            {
                timer1.Enabled = true;
                stop.Text = "Pause";
            }
        }

        private void list_S_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_S.SelectedIndex != -1)
            {
                changeSelectedInfo(list_S.Items[list_S.SelectedIndex].ToString());
            }
        }

        private void changeSelectedInfo(String selectedString)
        {
            int selectedInt = Convert.ToInt32(selectedString);
            Processo selected = vecProcessos[selectedInt];
            label_id.Text = selected.id+"";
            label_exec.Text = selected.texecucao+"";
            label_chegada.Text = selected.tchegada+"";
        }

        private void list_W_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_W.SelectedIndex != -1)
            {
                changeSelectedInfo(list_W.Items[list_W.SelectedIndex].ToString());
            }
        }

        private void list_E_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_E.SelectedIndex != -1)
            {
                changeSelectedInfo(list_E.Items[list_E.SelectedIndex].ToString());
            }
        }
    }
}