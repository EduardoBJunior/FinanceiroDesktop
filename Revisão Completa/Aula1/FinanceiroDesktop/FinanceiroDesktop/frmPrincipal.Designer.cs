namespace FinanceiroDesktop
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarMovimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarCategoriaToolStripMenuItem,
            this.gerenciarEmpresaToolStripMenuItem,
            this.gerenciarContaToolStripMenuItem,
            this.lançarMovimentaçãoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gerenciarCategoriaToolStripMenuItem
            // 
            this.gerenciarCategoriaToolStripMenuItem.Name = "gerenciarCategoriaToolStripMenuItem";
            this.gerenciarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gerenciarCategoriaToolStripMenuItem.Text = "Gerenciar  Categoria";
            this.gerenciarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarCategoriaToolStripMenuItem_Click);
            // 
            // gerenciarEmpresaToolStripMenuItem
            // 
            this.gerenciarEmpresaToolStripMenuItem.Name = "gerenciarEmpresaToolStripMenuItem";
            this.gerenciarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.gerenciarEmpresaToolStripMenuItem.Text = "Gerenciar Empresa";
            this.gerenciarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEmpresaToolStripMenuItem_Click);
            // 
            // gerenciarContaToolStripMenuItem
            // 
            this.gerenciarContaToolStripMenuItem.Name = "gerenciarContaToolStripMenuItem";
            this.gerenciarContaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gerenciarContaToolStripMenuItem.Text = "Gerenciar Conta";
            this.gerenciarContaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarContaToolStripMenuItem_Click);
            // 
            // lançarMovimentaçãoToolStripMenuItem
            // 
            this.lançarMovimentaçãoToolStripMenuItem.Name = "lançarMovimentaçãoToolStripMenuItem";
            this.lançarMovimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.lançarMovimentaçãoToolStripMenuItem.Text = "Lançar Movimentação";
            this.lançarMovimentaçãoToolStripMenuItem.Click += new System.EventHandler(this.lançarMovimentaçãoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.contaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.empresaToolStripMenuItem.Text = "Empresa ";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.contaToolStripMenuItem.Text = "Conta";
            this.contaToolStripMenuItem.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Financeira";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarMovimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
    }
}