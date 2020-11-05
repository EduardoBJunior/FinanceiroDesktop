namespace FinanceiroDesktop
{
    partial class frmConsultarCategoria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grdCategoria = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.grdCategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.dtp_inicio);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Categorias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "TOTAL :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(585, 395);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(44, 24);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Visible = false;
            // 
            // grdCategoria
            // 
            this.grdCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategoria.Location = new System.Drawing.Point(0, 113);
            this.grdCategoria.Name = "grdCategoria";
            this.grdCategoria.Size = new System.Drawing.Size(635, 278);
            this.grdCategoria.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data Final :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data Inicial :";
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(380, 63);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(105, 24);
            this.dtp_final.TabIndex = 16;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(157, 63);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(105, 24);
            this.dtp_inicio.TabIndex = 15;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(157, 29);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(328, 24);
            this.cbCategoria.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selecione a Categoria :";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisar.Location = new System.Drawing.Point(494, 16);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 60);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // frmConsultarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarCategoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView grdCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
    }
}