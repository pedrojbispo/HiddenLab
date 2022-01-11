namespace Projecto_Final
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFunc = new System.Windows.Forms.ComboBox();
            this.comboBoxClie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.listBoxCarrinho = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelCBCliente = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelCBCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarClienteToolStripMenuItem,
            this.adicionarFuncionárioToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // adicionarClienteToolStripMenuItem
            // 
            this.adicionarClienteToolStripMenuItem.Name = "adicionarClienteToolStripMenuItem";
            this.adicionarClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.adicionarClienteToolStripMenuItem.Text = "Adicionar Cliente";
            this.adicionarClienteToolStripMenuItem.Click += new System.EventHandler(this.adicionarClienteToolStripMenuItem_Click);
            // 
            // adicionarFuncionárioToolStripMenuItem
            // 
            this.adicionarFuncionárioToolStripMenuItem.Name = "adicionarFuncionárioToolStripMenuItem";
            this.adicionarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.adicionarFuncionárioToolStripMenuItem.Text = "Adicionar Funcionário";
            this.adicionarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.adicionarFuncionárioToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionário:";
            // 
            // comboBoxFunc
            // 
            this.comboBoxFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFunc.FormattingEnabled = true;
            this.comboBoxFunc.Location = new System.Drawing.Point(30, 59);
            this.comboBoxFunc.Name = "comboBoxFunc";
            this.comboBoxFunc.Size = new System.Drawing.Size(336, 28);
            this.comboBoxFunc.TabIndex = 2;
            // 
            // comboBoxClie
            // 
            this.comboBoxClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClie.FormattingEnabled = true;
            this.comboBoxClie.Location = new System.Drawing.Point(5, 7);
            this.comboBoxClie.Name = "comboBoxClie";
            this.comboBoxClie.Size = new System.Drawing.Size(336, 28);
            this.comboBoxClie.TabIndex = 4;
            this.comboBoxClie.SelectedIndexChanged += new System.EventHandler(this.comboBoxClie_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.ItemHeight = 20;
            this.listBoxProdutos.Location = new System.Drawing.Point(30, 192);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(336, 344);
            this.listBoxProdutos.TabIndex = 5;
            this.listBoxProdutos.DoubleClick += new System.EventHandler(this.listBoxProdutos_DoubleClick);
            // 
            // listBoxCarrinho
            // 
            this.listBoxCarrinho.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCarrinho.FormattingEnabled = true;
            this.listBoxCarrinho.ItemHeight = 20;
            this.listBoxCarrinho.Location = new System.Drawing.Point(397, 59);
            this.listBoxCarrinho.Name = "listBoxCarrinho";
            this.listBoxCarrinho.Size = new System.Drawing.Size(336, 444);
            this.listBoxCarrinho.TabIndex = 6;
            this.listBoxCarrinho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxCarrinho_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produtos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carrinho:";
            // 
            // labelValor
            // 
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(397, 516);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(336, 20);
            this.labelValor.TabIndex = 9;
            this.labelValor.Text = "Total:";
            this.labelValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabelHora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelCBCliente
            // 
            this.panelCBCliente.Controls.Add(this.comboBoxClie);
            this.panelCBCliente.Location = new System.Drawing.Point(25, 120);
            this.panelCBCliente.Name = "panelCBCliente";
            this.panelCBCliente.Size = new System.Drawing.Size(346, 41);
            this.panelCBCliente.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelCBCliente);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxCarrinho);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelCBCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFunc;
        private System.Windows.Forms.ComboBox comboBoxClie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.ListBox listBoxCarrinho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelCBCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
    }
}

