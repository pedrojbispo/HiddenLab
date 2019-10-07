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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Processos -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Espera - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de Processos Termindados -";
            // 
            // list_W
            // 
            this.list_W.FormattingEnabled = true;
            this.list_W.Location = new System.Drawing.Point(215, 81);
            this.list_W.Margin = new System.Windows.Forms.Padding(2);
            this.list_W.Name = "list_W";
            this.list_W.Size = new System.Drawing.Size(169, 264);
            this.list_W.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPU->";
            // 
            // list_E
            // 
            this.list_E.FormattingEnabled = true;
            this.list_E.Location = new System.Drawing.Point(665, 94);
            this.list_E.Margin = new System.Windows.Forms.Padding(2);
            this.list_E.Name = "list_E";
            this.list_E.Size = new System.Drawing.Size(171, 303);
            this.list_E.TabIndex = 6;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(9, 384);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 42);
            this.start.TabIndex = 7;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(470, 128);
            this.label_P.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(63, 13);
            this.label_P.TabIndex = 8;
            this.label_P.Text = "processo_E";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo->";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(224, 399);
            this.timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(29, 13);
            this.timer.TabIndex = 10;
            this.timer.Text = "timer";
            // 
            // list_S
            // 
            this.list_S.FormattingEnabled = true;
            this.list_S.Location = new System.Drawing.Point(11, 58);
            this.list_S.Margin = new System.Windows.Forms.Padding(2);
            this.list_S.Name = "list_S";
            this.list_S.Size = new System.Drawing.Size(200, 290);
            this.list_S.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tempo de CPU ->";
            // 
            // cputime
            // 
            this.cputime.AutoSize = true;
            this.cputime.Location = new System.Drawing.Point(526, 152);
            this.cputime.Name = "cputime";
            this.cputime.Size = new System.Drawing.Size(44, 13);
            this.cputime.TabIndex = 13;
            this.cputime.Text = "cputime";
            // 
            // count1
            // 
            this.count1.AutoSize = true;
            this.count1.Location = new System.Drawing.Point(133, 29);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(42, 13);
            this.count1.TabIndex = 14;
            this.count1.Text = "numero";
            // 
            // count2
            // 
            this.count2.AutoSize = true;
            this.count2.Location = new System.Drawing.Point(310, 58);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(42, 13);
            this.count2.TabIndex = 15;
            this.count2.Text = "numero";
            // 
            // count3
            // 
            this.count3.AutoSize = true;
            this.count3.Location = new System.Drawing.Point(833, 71);
            this.count3.Name = "count3";
            this.count3.Size = new System.Drawing.Size(42, 13);
            this.count3.TabIndex = 16;
            this.count3.Text = "numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 445);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

