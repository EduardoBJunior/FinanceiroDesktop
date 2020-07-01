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
            this.lançarMovimentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarCategoriaToolStripMenuItem,
            this.gerenciarEmpresaToolStripMenuItem,
            this.gerenciarContaToolStripMenuItem,
            this.lançarMovimentaToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarCategoriaToolStripMenuItem
            // 
            this.gerenciarCategoriaToolStripMenuItem.Name = "gerenciarCategoriaToolStripMenuItem";
            this.gerenciarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.gerenciarCategoriaToolStripMenuItem.Text = "Gerenciar Categoria";
            this.gerenciarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarCategoriaToolStripMenuItem_Click);
            // 
            // gerenciarEmpresaToolStripMenuItem
            // 
            this.gerenciarEmpresaToolStripMenuItem.Name = "gerenciarEmpresaToolStripMenuItem";
            this.gerenciarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.gerenciarEmpresaToolStripMenuItem.Text = "Gerenciar Empresa";
            this.gerenciarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEmpresaToolStripMenuItem_Click);
            // 
            // gerenciarContaToolStripMenuItem
            // 
            this.gerenciarContaToolStripMenuItem.Name = "gerenciarContaToolStripMenuItem";
            this.gerenciarContaToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.gerenciarContaToolStripMenuItem.Text = "Gerenciar Conta";
            this.gerenciarContaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarContaToolStripMenuItem_Click);
            // 
            // lançarMovimentaToolStripMenuItem
            // 
            this.lançarMovimentaToolStripMenuItem.Name = "lançarMovimentaToolStripMenuItem";
            this.lançarMovimentaToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.lançarMovimentaToolStripMenuItem.Text = "Lançar Movimento";
            this.lançarMovimentaToolStripMenuItem.Click += new System.EventHandler(this.lançarMovimentaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porEmpresaToolStripMenuItem,
            this.porCategoriaToolStripMenuItem,
            this.porContaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // porEmpresaToolStripMenuItem
            // 
            this.porEmpresaToolStripMenuItem.Name = "porEmpresaToolStripMenuItem";
            this.porEmpresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porEmpresaToolStripMenuItem.Text = "Por Empresa";
            this.porEmpresaToolStripMenuItem.Click += new System.EventHandler(this.porEmpresaToolStripMenuItem_Click);
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porCategoriaToolStripMenuItem.Text = "Por Categoria";
            this.porCategoriaToolStripMenuItem.Click += new System.EventHandler(this.porCategoriaToolStripMenuItem_Click);
            // 
            // porContaToolStripMenuItem
            // 
            this.porContaToolStripMenuItem.Name = "porContaToolStripMenuItem";
            this.porContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porContaToolStripMenuItem.Text = "Por Conta";
            this.porContaToolStripMenuItem.Click += new System.EventHandler(this.porContaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem lançarMovimentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}