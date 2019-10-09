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
            this.timer = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Processos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Espera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de Processos Termindados";
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPU";
            // 
            // list_E
            // 
            this.list_E.FormattingEnabled = true;
            this.list_E.Location = new System.Drawing.Point(664, 109);
            this.list_E.Margin = new System.Windows.Forms.Padding(2);
            this.list_E.Name = "list_E";
            this.list_E.Size = new System.Drawing.Size(182, 381);
            this.list_E.TabIndex = 6;
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
            this.label_P.Location = new System.Drawing.Point(473, 165);
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
            this.label5.Location = new System.Drawing.Point(22, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo->";
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timer.Location = new System.Drawing.Point(71, 53);
            this.timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(50, 15);
            this.timer.TabIndex = 10;
            this.timer.Text = "timer";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(427, 192);
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
            this.cputime.Location = new System.Drawing.Point(538, 192);
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
            this.count3.Location = new System.Drawing.Point(736, 496);
            this.count3.Name = "count3";
            this.count3.Size = new System.Drawing.Size(57, 15);
            this.count3.TabIndex = 16;
            this.count3.Text = "contador";
            this.count3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset
            // 
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(98, 11);
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
            this.kill.Location = new System.Drawing.Point(194, 11);
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
            this.richTextBox1.Location = new System.Drawing.Point(412, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 80);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 537);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kill);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.count3);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.cputime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_S);
            this.Controls.Add(this.timer);
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
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Shortest Job First - Escalonamento de Processos";
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
        private System.Windows.Forms.Label timer;
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
        private System.Windows.Forms.Label label7;
    }
}

