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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.list_S = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Processos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Espera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de Processos Termindados";
            // 
            // list_W
            // 
            this.list_W.FormattingEnabled = true;
            this.list_W.ItemHeight = 16;
            this.list_W.Location = new System.Drawing.Point(305, 116);
            this.list_W.Name = "list_W";
            this.list_W.Size = new System.Drawing.Size(154, 244);
            this.list_W.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPU->";
            // 
            // list_E
            // 
            this.list_E.FormattingEnabled = true;
            this.list_E.ItemHeight = 16;
            this.list_E.Location = new System.Drawing.Point(781, 116);
            this.list_E.Name = "list_E";
            this.list_E.Size = new System.Drawing.Size(138, 244);
            this.list_E.TabIndex = 6;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 472);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(140, 52);
            this.start.TabIndex = 7;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(554, 146);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(67, 17);
            this.label_P.TabIndex = 8;
            this.label_P.Text = "Processo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tempo->";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(305, 409);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(39, 17);
            this.timer.TabIndex = 10;
            this.timer.Text = "timer";
            // 
            // list_S
            // 
            this.list_S.FormattingEnabled = true;
            this.list_S.ItemHeight = 16;
            this.list_S.Location = new System.Drawing.Point(46, 71);
            this.list_S.Name = "list_S";
            this.list_S.Size = new System.Drawing.Size(139, 356);
            this.list_S.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 536);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.ListBox list_S;
    }
}

