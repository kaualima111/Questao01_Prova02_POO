namespace wfaCaminhão
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbOnibus = new System.Windows.Forms.RadioButton();
            this.rbCaminhao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.colPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAssentos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEixos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbImagens = new System.Windows.Forms.PictureBox();
            this.tbAssentos = new System.Windows.Forms.TextBox();
            this.tbEixos = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCaminhao = new System.Windows.Forms.Panel();
            this.pnlOnibus = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).BeginInit();
            this.pnlCaminhao.SuspendLayout();
            this.pnlOnibus.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbOnibus
            // 
            this.rbOnibus.AutoSize = true;
            this.rbOnibus.Location = new System.Drawing.Point(26, 12);
            this.rbOnibus.Name = "rbOnibus";
            this.rbOnibus.Size = new System.Drawing.Size(70, 20);
            this.rbOnibus.TabIndex = 0;
            this.rbOnibus.TabStop = true;
            this.rbOnibus.Text = "Ônibus";
            this.rbOnibus.UseVisualStyleBackColor = true;
            this.rbOnibus.CheckedChanged += new System.EventHandler(this.rbOnibus_CheckedChanged);
            // 
            // rbCaminhao
            // 
            this.rbCaminhao.AutoSize = true;
            this.rbCaminhao.Location = new System.Drawing.Point(177, 12);
            this.rbCaminhao.Name = "rbCaminhao";
            this.rbCaminhao.Size = new System.Drawing.Size(89, 20);
            this.rbCaminhao.TabIndex = 1;
            this.rbCaminhao.TabStop = true;
            this.rbCaminhao.Text = "Caminhão";
            this.rbCaminhao.UseVisualStyleBackColor = true;
            this.rbCaminhao.CheckedChanged += new System.EventHandler(this.rbCaminhao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(184, 47);
            this.mtbPlaca.Mask = "LLL-0000";
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(100, 22);
            this.mtbPlaca.TabIndex = 3;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(184, 75);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 22);
            this.tbAno.TabIndex = 4;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(21, 148);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(125, 39);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlaca,
            this.colAno,
            this.colAssentos,
            this.colEixos,
            this.colDiaria});
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(12, 193);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(559, 230);
            this.lv1.TabIndex = 6;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.SelectedIndexChanged += new System.EventHandler(this.lv1_SelectedIndexChanged);
            // 
            // colPlaca
            // 
            this.colPlaca.Text = "Placa";
            this.colPlaca.Width = 87;
            // 
            // colAno
            // 
            this.colAno.Text = "Ano";
            this.colAno.Width = 48;
            // 
            // colAssentos
            // 
            this.colAssentos.Text = "Assentos";
            this.colAssentos.Width = 72;
            // 
            // colEixos
            // 
            this.colEixos.Text = "Eixos";
            this.colEixos.Width = 51;
            // 
            // colDiaria
            // 
            this.colDiaria.Text = "Diaria";
            this.colDiaria.Width = 315;
            // 
            // pbImagens
            // 
            this.pbImagens.Image = global::wfaCaminhão.Properties.Resources.ImagemOnibus;
            this.pbImagens.Location = new System.Drawing.Point(358, 12);
            this.pbImagens.Name = "pbImagens";
            this.pbImagens.Size = new System.Drawing.Size(213, 175);
            this.pbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagens.TabIndex = 7;
            this.pbImagens.TabStop = false;
            this.pbImagens.Click += new System.EventHandler(this.pb1_Click);
            // 
            // tbAssentos
            // 
            this.tbAssentos.Location = new System.Drawing.Point(146, 3);
            this.tbAssentos.Name = "tbAssentos";
            this.tbAssentos.Size = new System.Drawing.Size(100, 22);
            this.tbAssentos.TabIndex = 8;
            // 
            // tbEixos
            // 
            this.tbEixos.Location = new System.Drawing.Point(134, 6);
            this.tbEixos.Name = "tbEixos";
            this.tbEixos.Size = new System.Drawing.Size(100, 22);
            this.tbEixos.TabIndex = 9;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(195, 148);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(125, 39);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Qtadade de Eixos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Qtdade de Assentos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ano:";
            // 
            // pnlCaminhao
            // 
            this.pnlCaminhao.Controls.Add(this.label2);
            this.pnlCaminhao.Controls.Add(this.tbEixos);
            this.pnlCaminhao.Location = new System.Drawing.Point(48, 103);
            this.pnlCaminhao.Name = "pnlCaminhao";
            this.pnlCaminhao.Size = new System.Drawing.Size(272, 29);
            this.pnlCaminhao.TabIndex = 14;
            // 
            // pnlOnibus
            // 
            this.pnlOnibus.Controls.Add(this.tbAssentos);
            this.pnlOnibus.Controls.Add(this.label3);
            this.pnlOnibus.Location = new System.Drawing.Point(36, 103);
            this.pnlOnibus.Name = "pnlOnibus";
            this.pnlOnibus.Size = new System.Drawing.Size(272, 29);
            this.pnlOnibus.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 435);
            this.Controls.Add(this.pnlOnibus);
            this.Controls.Add(this.pnlCaminhao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.pbImagens);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCaminhao);
            this.Controls.Add(this.rbOnibus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).EndInit();
            this.pnlCaminhao.ResumeLayout(false);
            this.pnlCaminhao.PerformLayout();
            this.pnlOnibus.ResumeLayout(false);
            this.pnlOnibus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOnibus;
        private System.Windows.Forms.RadioButton rbCaminhao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.PictureBox pbImagens;
        private System.Windows.Forms.TextBox tbAssentos;
        private System.Windows.Forms.TextBox tbEixos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCaminhao;
        private System.Windows.Forms.Panel pnlOnibus;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ColumnHeader colPlaca;
        private System.Windows.Forms.ColumnHeader colAno;
        private System.Windows.Forms.ColumnHeader colAssentos;
        private System.Windows.Forms.ColumnHeader colEixos;
        private System.Windows.Forms.ColumnHeader colDiaria;
    }
}

