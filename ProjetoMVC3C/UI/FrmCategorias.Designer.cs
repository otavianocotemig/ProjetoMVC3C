namespace ProjetoMVC3C.UI
{
    partial class FrmCategorias
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
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.dgv_Categoria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Location = new System.Drawing.Point(53, 111);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(388, 20);
            this.txt_Pesquisar.TabIndex = 0;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(447, 108);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(101, 23);
            this.btn_Pesquisar.TabIndex = 1;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // dgv_Categoria
            // 
            this.dgv_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categoria.Location = new System.Drawing.Point(53, 137);
            this.dgv_Categoria.Name = "dgv_Categoria";
            this.dgv_Categoria.Size = new System.Drawing.Size(498, 189);
            this.dgv_Categoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Categoria);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_Pesquisar);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.DataGridView dgv_Categoria;
        private System.Windows.Forms.Label label1;
    }
}