namespace SFJ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_W = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.list_E = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.label_P = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_timer1 = new System.Windows.Forms.Label();
            this.list_S = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cputime = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.Label();
            this.count2 = new System.Windows.Forms.Label();
            this.count3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.kill = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.stop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_exec = new System.Windows.Forms.Label();
            this.label_chegada = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_threads = new System.Windows.Forms.Label();
            this.thread = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label_buffer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label_timer2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_timer3 = new System.Windows.Forms.Label();
            this.bufferbar = new System.Windows.Forms.ProgressBar();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.debug_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Processos - Estado 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Espera - Estado 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de Processos Termindados - Estado 3";
            // 
            // list_W
            // 
            this.list_W.Cursor = System.Windows.Forms.Cursors.No;
            this.list_W.FormattingEnabled = true;
            this.list_W.Location = new System.Drawing.Point(215, 109);
            this.list_W.Margin = new System.Windows.Forms.Padding(2);
            this.list_W.Name = "list_W";
            this.list_W.Size = new System.Drawing.Size(169, 368);
            this.list_W.TabIndex = 4;
            this.list_W.SelectedIndexChanged += new System.EventHandler(this.list_W_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPU - Estado 2";
            // 
            // list_E
            // 
            this.list_E.FormattingEnabled = true;
            this.list_E.Location = new System.Drawing.Point(673, 109);
            this.list_E.Margin = new System.Windows.Forms.Padding(2);
            this.list_E.Name = "list_E";
            this.list_E.Size = new System.Drawing.Size(218, 381);
            this.list_E.TabIndex = 6;
            this.list_E.SelectedIndexChanged += new System.EventHandler(this.list_E_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Control;
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Location = new System.Drawing.Point(11, 11);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(82, 29);
            this.start.TabIndex = 7;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label_P
            // 
            this.label_P.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_P.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_P.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_P.Location = new System.Drawing.Point(488, 145);
            this.label_P.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(65, 15);
            this.label_P.TabIndex = 8;
            this.label_P.Text = "processo_E";
            this.label_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo dos Processsos->";
            // 
            // label_timer1
            // 
            this.label_timer1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_timer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_timer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_timer1.Location = new System.Drawing.Point(59, 57);
            this.label_timer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_timer1.Name = "label_timer1";
            this.label_timer1.Size = new System.Drawing.Size(50, 15);
            this.label_timer1.TabIndex = 10;
            this.label_timer1.Text = "timer1";
            this.label_timer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_S
            // 
            this.list_S.BackColor = System.Drawing.SystemColors.Window;
            this.list_S.Cursor = System.Windows.Forms.Cursors.No;
            this.list_S.FormattingEnabled = true;
            this.list_S.Location = new System.Drawing.Point(11, 100);
            this.list_S.Margin = new System.Windows.Forms.Padding(2);
            this.list_S.Name = "list_S";
            this.list_S.Size = new System.Drawing.Size(200, 381);
            this.list_S.TabIndex = 11;
            this.list_S.SelectedIndexChanged += new System.EventHandler(this.list_S_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(442, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tempo do Processo ->";
            // 
            // cputime
            // 
            this.cputime.AutoSize = true;
            this.cputime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cputime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cputime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cputime.Location = new System.Drawing.Point(555, 172);
            this.cputime.Name = "cputime";
            this.cputime.Size = new System.Drawing.Size(46, 15);
            this.cputime.TabIndex = 13;
            this.cputime.Text = "cputime";
            this.cputime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count1
            // 
            this.count1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.count1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.count1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.count1.Location = new System.Drawing.Point(77, 486);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(63, 15);
            this.count1.TabIndex = 14;
            this.count1.Text = "contador";
            this.count1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count2
            // 
            this.count2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.count2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.count2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.count2.Location = new System.Drawing.Point(273, 482);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(57, 15);
            this.count2.TabIndex = 15;
            this.count2.Text = "contador";
            this.count2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count3
            // 
            this.count3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.count3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.count3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.count3.Location = new System.Drawing.Point(755, 496);
            this.count3.Name = "count3";
            this.count3.Size = new System.Drawing.Size(57, 15);
            this.count3.TabIndex = 16;
            this.count3.Text = "contador";
            this.count3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset
            // 
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(194, 11);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(90, 29);
            this.reset.TabIndex = 17;
            this.reset.Text = "Restart";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // kill
            // 
            this.kill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kill.Location = new System.Drawing.Point(290, 11);
            this.kill.Name = "kill";
            this.kill.Size = new System.Drawing.Size(81, 29);
            this.kill.TabIndex = 18;
            this.kill.Text = "Kill";
            this.kill.UseVisualStyleBackColor = true;
            this.kill.Click += new System.EventHandler(this.kill_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTextBox1.Location = new System.Drawing.Point(426, 129);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(202, 87);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.Control;
            this.stop.Enabled = false;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop.Location = new System.Drawing.Point(98, 11);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(90, 29);
            this.stop.TabIndex = 21;
            this.stop.Text = "Pause";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(403, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID ->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(403, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tempo de Execução ->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(403, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Tempo de Chegada ->";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.richTextBox2.DetectUrls = false;
            this.richTextBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTextBox2.Location = new System.Drawing.Point(397, 370);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.ShortcutsEnabled = false;
            this.richTextBox2.Size = new System.Drawing.Size(256, 105);
            this.richTextBox2.TabIndex = 28;
            this.richTextBox2.Text = "";
            this.richTextBox2.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(583, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(578, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "ms";
            // 
            // label_exec
            // 
            this.label_exec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_exec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_exec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_exec.Location = new System.Drawing.Point(519, 406);
            this.label_exec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_exec.Name = "label_exec";
            this.label_exec.Size = new System.Drawing.Size(65, 15);
            this.label_exec.TabIndex = 31;
            this.label_exec.Text = "texecuçao";
            this.label_exec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_chegada
            // 
            this.label_chegada.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_chegada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_chegada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_chegada.Location = new System.Drawing.Point(514, 433);
            this.label_chegada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_chegada.Name = "label_chegada";
            this.label_chegada.Size = new System.Drawing.Size(65, 15);
            this.label_chegada.TabIndex = 32;
            this.label_chegada.Text = "tchegada";
            this.label_chegada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_id
            // 
            this.label_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_id.Location = new System.Drawing.Point(431, 381);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(65, 15);
            this.label_id.TabIndex = 33;
            this.label_id.Text = "id";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(461, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Informação do Processo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(404, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Threads ->";
            // 
            // label_threads
            // 
            this.label_threads.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_threads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_threads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_threads.Location = new System.Drawing.Point(460, 455);
            this.label_threads.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_threads.Name = "label_threads";
            this.label_threads.Size = new System.Drawing.Size(65, 15);
            this.label_threads.TabIndex = 36;
            this.label_threads.Text = "threads";
            this.label_threads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thread
            // 
            this.thread.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thread.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thread.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thread.Location = new System.Drawing.Point(545, 194);
            this.thread.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thread.Name = "thread";
            this.thread.Size = new System.Drawing.Size(65, 15);
            this.thread.TabIndex = 37;
            this.thread.Text = "threads";
            this.thread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Info;
            this.label15.Location = new System.Drawing.Point(432, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Numero de Threads ->";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.richTextBox3.DetectUrls = false;
            this.richTextBox3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTextBox3.Location = new System.Drawing.Point(426, 228);
            this.richTextBox3.Multiline = false;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.ShortcutsEnabled = false;
            this.richTextBox3.Size = new System.Drawing.Size(203, 89);
            this.richTextBox3.TabIndex = 43;
            this.richTextBox3.Text = "";
            this.richTextBox3.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Buffer";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.richTextBox4.DetectUrls = false;
            this.richTextBox4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTextBox4.Location = new System.Drawing.Point(416, 109);
            this.richTextBox4.Multiline = false;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox4.ShortcutsEnabled = false;
            this.richTextBox4.Size = new System.Drawing.Size(228, 218);
            this.richTextBox4.TabIndex = 45;
            this.richTextBox4.Text = "";
            this.richTextBox4.WordWrap = false;
            // 
            // label_buffer
            // 
            this.label_buffer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_buffer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_buffer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_buffer.Location = new System.Drawing.Point(494, 246);
            this.label_buffer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_buffer.Name = "label_buffer";
            this.label_buffer.Size = new System.Drawing.Size(65, 15);
            this.label_buffer.TabIndex = 46;
            this.label_buffer.Text = "buffer";
            this.label_buffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Tempo ->";
            // 
            // label_timer2
            // 
            this.label_timer2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_timer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_timer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_timer2.Location = new System.Drawing.Point(237, 57);
            this.label_timer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_timer2.Name = "label_timer2";
            this.label_timer2.Size = new System.Drawing.Size(50, 15);
            this.label_timer2.TabIndex = 48;
            this.label_timer2.Text = "timer2";
            this.label_timer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Info;
            this.label18.Location = new System.Drawing.Point(454, 296);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Tempo do Buffer ->";
            // 
            // label_timer3
            // 
            this.label_timer3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_timer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_timer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_timer3.Location = new System.Drawing.Point(551, 296);
            this.label_timer3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_timer3.Name = "label_timer3";
            this.label_timer3.Size = new System.Drawing.Size(50, 15);
            this.label_timer3.TabIndex = 50;
            this.label_timer3.Text = "timer3";
            this.label_timer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bufferbar
            // 
            this.bufferbar.Location = new System.Drawing.Point(445, 264);
            this.bufferbar.Name = "bufferbar";
            this.bufferbar.Size = new System.Drawing.Size(165, 23);
            this.bufferbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bufferbar.TabIndex = 51;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.richTextBox5.DetectUrls = false;
            this.richTextBox5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTextBox5.Location = new System.Drawing.Point(12, 518);
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.ShortcutsEnabled = false;
            this.richTextBox5.Size = new System.Drawing.Size(1532, 326);
            this.richTextBox5.TabIndex = 52;
            this.richTextBox5.Text = "";
            this.richTextBox5.WordWrap = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 513);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "Debug Logs - Event Log";
            // 
            // debug_log
            // 
            this.debug_log.Location = new System.Drawing.Point(26, 543);
            this.debug_log.Multiline = true;
            this.debug_log.Name = "debug_log";
            this.debug_log.ReadOnly = true;
            this.debug_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debug_log.Size = new System.Drawing.Size(1498, 287);
            this.debug_log.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 856);
            this.Controls.Add(this.debug_log);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.bufferbar);
            this.Controls.Add(this.label_timer3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label_timer2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_buffer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.thread);
            this.Controls.Add(this.label_threads);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_chegada);
            this.Controls.Add(this.label_exec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.kill);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.count3);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.cputime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_S);
            this.Controls.Add(this.label_timer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_P);
            this.Controls.Add(this.start);
            this.Controls.Add(this.list_E);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_W);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox4);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Shortest Job First - Escalonamento de Processos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_W;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_E;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_timer1;
        private System.Windows.Forms.ListBox list_S;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cputime;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.Label count2;
        private System.Windows.Forms.Label count3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button kill;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_exec;
        private System.Windows.Forms.Label label_chegada;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_threads;
        private System.Windows.Forms.Label thread;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label_buffer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_timer2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_timer3;
        private System.Windows.Forms.ProgressBar bufferbar;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox debug_log;
    }
}

