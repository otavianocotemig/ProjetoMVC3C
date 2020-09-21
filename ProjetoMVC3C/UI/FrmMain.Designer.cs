﻿namespace ProjetoMVC3C.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeFonecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmailUsuarioLogado = new System.Windows.Forms.Label();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem,
            this.administraçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alterarSenhaToolStripMenuItem.Image")));
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Meu Perfil";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupBancoDeDadosToolStripMenuItem,
            this.manutençãoDeClientesToolStripMenuItem,
            this.manutençãoDeFonecedoresToolStripMenuItem,
            this.manutençãoDeProdutosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // setupBancoDeDadosToolStripMenuItem
            // 
            this.setupBancoDeDadosToolStripMenuItem.Name = "setupBancoDeDadosToolStripMenuItem";
            this.setupBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.setupBancoDeDadosToolStripMenuItem.Text = "Setup Banco de Dados";
            // 
            // manutençãoDeClientesToolStripMenuItem
            // 
            this.manutençãoDeClientesToolStripMenuItem.Name = "manutençãoDeClientesToolStripMenuItem";
            this.manutençãoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.manutençãoDeClientesToolStripMenuItem.Text = "Manutenção de Clientes";
            this.manutençãoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeClientesToolStripMenuItem_Click);
            // 
            // manutençãoDeFonecedoresToolStripMenuItem
            // 
            this.manutençãoDeFonecedoresToolStripMenuItem.Name = "manutençãoDeFonecedoresToolStripMenuItem";
            this.manutençãoDeFonecedoresToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.manutençãoDeFonecedoresToolStripMenuItem.Text = "Manutenção de Fonecedores";
            this.manutençãoDeFonecedoresToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeFonecedoresToolStripMenuItem_Click);
            // 
            // manutençãoDeProdutosToolStripMenuItem
            // 
            this.manutençãoDeProdutosToolStripMenuItem.Name = "manutençãoDeProdutosToolStripMenuItem";
            this.manutençãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.manutençãoDeProdutosToolStripMenuItem.Text = "Manutenção de Produtos";
            this.manutençãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeProdutosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblEmailUsuarioLogado
            // 
            this.lblEmailUsuarioLogado.AutoSize = true;
            this.lblEmailUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsuarioLogado.Location = new System.Drawing.Point(351, 196);
            this.lblEmailUsuarioLogado.Name = "lblEmailUsuarioLogado";
            this.lblEmailUsuarioLogado.Size = new System.Drawing.Size(41, 13);
            this.lblEmailUsuarioLogado.TabIndex = 2;
            this.lblEmailUsuarioLogado.Text = "label1";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmailUsuarioLogado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Formulário Principal - Sistema X";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lblEmailUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeFonecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
    }
}