namespace Programs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.death_from_above_XD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.list_S = new System.Windows.Forms.ListBox();
            this.list_W = new System.Windows.Forms.ListBox();
            this.list_E = new System.Windows.Forms.ListBox();
            this.count1 = new System.Windows.Forms.Label();
            this.debug_log = new System.Windows.Forms.TextBox();
            this.label_buffer = new System.Windows.Forms.Label();
            this.label_timer1 = new System.Windows.Forms.Label();
            this.label_timer2 = new System.Windows.Forms.Label();
            this.label_timer3 = new System.Windows.Forms.Label();
            this.cputime = new System.Windows.Forms.Label();
            this.label_P = new System.Windows.Forms.Label();
            this.thread = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_exec = new System.Windows.Forms.Label();
            this.label_chegada = new System.Windows.Forms.Label();
            this.label_threads = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.count2 = new System.Windows.Forms.Label();
            this.count3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(95, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(177, 12);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 2;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // death_from_above_XD
            // 
            this.death_from_above_XD.Location = new System.Drawing.Point(259, 12);
            this.death_from_above_XD.Name = "death_from_above_XD";
            this.death_from_above_XD.Size = new System.Drawing.Size(75, 23);
            this.death_from_above_XD.TabIndex = 3;
            this.death_from_above_XD.Text = "Kill";
            this.death_from_above_XD.UseVisualStyleBackColor = true;
            this.death_from_above_XD.Click += new System.EventHandler(this.death_from_above_XD_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // list_S
            // 
            this.list_S.FormattingEnabled = true;
            this.list_S.Location = new System.Drawing.Point(35, 117);
            this.list_S.Name = "list_S";
            this.list_S.Size = new System.Drawing.Size(163, 316);
            this.list_S.TabIndex = 4;
            // 
            // list_W
            // 
            this.list_W.FormattingEnabled = true;
            this.list_W.Location = new System.Drawing.Point(259, 117);
            this.list_W.Name = "list_W";
            this.list_W.Size = new System.Drawing.Size(158, 355);
            this.list_W.TabIndex = 5;
            // 
            // list_E
            // 
            this.list_E.FormattingEnabled = true;
            this.list_E.Location = new System.Drawing.Point(880, 117);
            this.list_E.Name = "list_E";
            this.list_E.Size = new System.Drawing.Size(180, 420);
            this.list_E.TabIndex = 7;
            // 
            // count1
            // 
            this.count1.BackColor = System.Drawing.Color.DarkGray;
            this.count1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.count1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count1.Location = new System.Drawing.Point(83, 436);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(58, 16);
            this.count1.TabIndex = 8;
            this.count1.Text = "Contador";
            this.count1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debug_log
            // 
            this.debug_log.Location = new System.Drawing.Point(22, 641);
            this.debug_log.Multiline = true;
            this.debug_log.Name = "debug_log";
            this.debug_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debug_log.Size = new System.Drawing.Size(1224, 162);
            this.debug_log.TabIndex = 12;
            // 
            // label_buffer
            // 
            this.label_buffer.AutoSize = true;
            this.label_buffer.BackColor = System.Drawing.SystemColors.Info;
            this.label_buffer.Location = new System.Drawing.Point(624, 253);
            this.label_buffer.Name = "label_buffer";
            this.label_buffer.Size = new System.Drawing.Size(34, 13);
            this.label_buffer.TabIndex = 13;
            this.label_buffer.Text = "buffer";
            // 
            // label_timer1
            // 
            this.label_timer1.AutoSize = true;
            this.label_timer1.Location = new System.Drawing.Point(135, 61);
            this.label_timer1.Name = "label_timer1";
            this.label_timer1.Size = new System.Drawing.Size(63, 13);
            this.label_timer1.TabIndex = 14;
            this.label_timer1.Text = "label_timer1";
            // 
            // label_timer2
            // 
            this.label_timer2.AutoSize = true;
            this.label_timer2.Location = new System.Drawing.Point(327, 62);
            this.label_timer2.Name = "label_timer2";
            this.label_timer2.Size = new System.Drawing.Size(63, 13);
            this.label_timer2.TabIndex = 15;
            this.label_timer2.Text = "label_timer2";
            // 
            // label_timer3
            // 
            this.label_timer3.AutoSize = true;
            this.label_timer3.BackColor = System.Drawing.SystemColors.Info;
            this.label_timer3.Location = new System.Drawing.Point(643, 278);
            this.label_timer3.Name = "label_timer3";
            this.label_timer3.Size = new System.Drawing.Size(63, 13);
            this.label_timer3.TabIndex = 16;
            this.label_timer3.Text = "label_timer3";
            // 
            // cputime
            // 
            this.cputime.AutoSize = true;
            this.cputime.BackColor = System.Drawing.SystemColors.Info;
            this.cputime.Location = new System.Drawing.Point(666, 184);
            this.cputime.Name = "cputime";
            this.cputime.Size = new System.Drawing.Size(44, 13);
            this.cputime.TabIndex = 17;
            this.cputime.Text = "cputime";
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.BackColor = System.Drawing.SystemColors.Info;
            this.label_P.Location = new System.Drawing.Point(620, 161);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(42, 13);
            this.label_P.TabIndex = 18;
            this.label_P.Text = "label_P";
            // 
            // thread
            // 
            this.thread.AutoSize = true;
            this.thread.BackColor = System.Drawing.SystemColors.Info;
            this.thread.Location = new System.Drawing.Point(661, 208);
            this.thread.Name = "thread";
            this.thread.Size = new System.Drawing.Size(37, 13);
            this.thread.TabIndex = 19;
            this.thread.Text = "thread";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.Info;
            this.label_id.Location = new System.Drawing.Point(572, 384);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(43, 13);
            this.label_id.TabIndex = 21;
            this.label_id.Text = "label_id";
            // 
            // label_exec
            // 
            this.label_exec.AutoSize = true;
            this.label_exec.BackColor = System.Drawing.SystemColors.Info;
            this.label_exec.Location = new System.Drawing.Point(654, 436);
            this.label_exec.Name = "label_exec";
            this.label_exec.Size = new System.Drawing.Size(58, 13);
            this.label_exec.TabIndex = 22;
            this.label_exec.Text = "label_exec";
            // 
            // label_chegada
            // 
            this.label_chegada.AutoSize = true;
            this.label_chegada.BackColor = System.Drawing.SystemColors.Info;
            this.label_chegada.Location = new System.Drawing.Point(649, 410);
            this.label_chegada.Name = "label_chegada";
            this.label_chegada.Size = new System.Drawing.Size(77, 13);
            this.label_chegada.TabIndex = 23;
            this.label_chegada.Text = "label_chegada";
            // 
            // label_threads
            // 
            this.label_threads.AutoSize = true;
            this.label_threads.BackColor = System.Drawing.SystemColors.Info;
            this.label_threads.Location = new System.Drawing.Point(648, 461);
            this.label_threads.Name = "label_threads";
            this.label_threads.Size = new System.Drawing.Size(70, 13);
            this.label_threads.TabIndex = 24;
            this.label_threads.Text = "label_threads";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(585, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(542, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tempo de Execução->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(547, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Numero de Threads->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(542, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tempo do Buffer->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tempo de  Simulação->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tempo do Processo->";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "CPU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(541, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID ->";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(541, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tempo de Chegada->";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(541, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Tempo de Execução->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(541, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Numero de Threads->";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(490, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(283, 215);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Location = new System.Drawing.Point(532, 368);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(206, 119);
            this.richTextBox2.TabIndex = 39;
            this.richTextBox2.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(578, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Informação do Processo";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox3.Location = new System.Drawing.Point(519, 146);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(230, 87);
            this.richTextBox3.TabIndex = 41;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox4.Location = new System.Drawing.Point(519, 240);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(230, 65);
            this.richTextBox4.TabIndex = 42;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox5.Location = new System.Drawing.Point(11, 623);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(1248, 190);
            this.richTextBox5.TabIndex = 43;
            this.richTextBox5.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 619);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Event Log- Debug";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(572, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Buffer ->";
            // 
            // count2
            // 
            this.count2.BackColor = System.Drawing.Color.DarkGray;
            this.count2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.count2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count2.Location = new System.Drawing.Point(309, 478);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(57, 17);
            this.count2.TabIndex = 46;
            this.count2.Text = "Contador";
            this.count2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count3
            // 
            this.count3.BackColor = System.Drawing.Color.DarkGray;
            this.count3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.count3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count3.Location = new System.Drawing.Point(949, 543);
            this.count3.Name = "count3";
            this.count3.Size = new System.Drawing.Size(60, 16);
            this.count3.TabIndex = 47;
            this.count3.Text = "Contador";
            this.count3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(92, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Estado 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 829);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.count3);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_threads);
            this.Controls.Add(this.label_chegada);
            this.Controls.Add(this.label_exec);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.thread);
            this.Controls.Add(this.label_P);
            this.Controls.Add(this.cputime);
            this.Controls.Add(this.label_timer3);
            this.Controls.Add(this.label_timer2);
            this.Controls.Add(this.label_timer1);
            this.Controls.Add(this.label_buffer);
            this.Controls.Add(this.debug_log);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.list_E);
            this.Controls.Add(this.list_W);
            this.Controls.Add(this.list_S);
            this.Controls.Add(this.death_from_above_XD);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button death_from_above_XD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ListBox list_S;
        private System.Windows.Forms.ListBox list_W;
        private System.Windows.Forms.ListBox list_E;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.TextBox debug_log;
        private System.Windows.Forms.Label label_buffer;
        private System.Windows.Forms.Label label_timer1;
        private System.Windows.Forms.Label label_timer2;
        private System.Windows.Forms.Label label_timer3;
        private System.Windows.Forms.Label cputime;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label thread;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_exec;
        private System.Windows.Forms.Label label_chegada;
        private System.Windows.Forms.Label label_threads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label count2;
        private System.Windows.Forms.Label count3;
        private System.Windows.Forms.Label label17;
    }
}

