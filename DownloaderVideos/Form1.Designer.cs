namespace DownloaderVideos
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.labelLinkVideo = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelPorcentagem = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelDestino = new System.Windows.Forms.Label();
            this.txtLocalDestino = new System.Windows.Forms.TextBox();
            this.groupBoxTitulo = new System.Windows.Forms.GroupBox();
            this.salvarArquivo = new System.Windows.Forms.FolderBrowserDialog();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.labelErro = new System.Windows.Forms.Label();
            this.labelFormato = new System.Windows.Forms.Label();
            this.cmbFormatos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBoxVideo = new System.Windows.Forms.CheckBox();
            this.chkBoxAudio = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.D = new System.Windows.Forms.Label();
            this.download = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxTitulo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLinkVideo
            // 
            this.labelLinkVideo.AutoSize = true;
            this.labelLinkVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinkVideo.Location = new System.Drawing.Point(24, 20);
            this.labelLinkVideo.Name = "labelLinkVideo";
            this.labelLinkVideo.Size = new System.Drawing.Size(147, 16);
            this.labelLinkVideo.TabIndex = 0;
            this.labelLinkVideo.Text = "Link para download:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(27, 43);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(556, 24);
            this.txtLink.TabIndex = 1;
            // 
            // btnBaixar
            // 
            this.btnBaixar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixar.ForeColor = System.Drawing.Color.White;
            this.btnBaixar.Location = new System.Drawing.Point(326, 30);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(181, 45);
            this.btnBaixar.TabIndex = 2;
            this.btnBaixar.Text = "DOWNLOAD";
            this.btnBaixar.UseVisualStyleBackColor = false;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(26, 43);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(218, 21);
            this.progresso.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.labelDestino);
            this.groupBox1.Controls.Add(this.txtLocalDestino);
            this.groupBox1.Controls.Add(this.labelLinkVideo);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelar.Location = new System.Drawing.Point(513, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 45);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelPorcentagem
            // 
            this.labelPorcentagem.AutoSize = true;
            this.labelPorcentagem.BackColor = System.Drawing.Color.Transparent;
            this.labelPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcentagem.Location = new System.Drawing.Point(248, 46);
            this.labelPorcentagem.Name = "labelPorcentagem";
            this.labelPorcentagem.Size = new System.Drawing.Size(0, 15);
            this.labelPorcentagem.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(589, 109);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 24);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar em...";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.Location = new System.Drawing.Point(24, 88);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(115, 16);
            this.labelDestino.TabIndex = 8;
            this.labelDestino.Text = "Local de saída:";
            // 
            // txtLocalDestino
            // 
            this.txtLocalDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalDestino.Location = new System.Drawing.Point(27, 109);
            this.txtLocalDestino.Name = "txtLocalDestino";
            this.txtLocalDestino.Size = new System.Drawing.Size(556, 24);
            this.txtLocalDestino.TabIndex = 7;
            // 
            // groupBoxTitulo
            // 
            this.groupBoxTitulo.Controls.Add(this.pictureBox2);
            this.groupBoxTitulo.Controls.Add(this.download);
            this.groupBoxTitulo.Controls.Add(this.D);
            this.groupBoxTitulo.Controls.Add(this.pictureBox1);
            this.groupBoxTitulo.Location = new System.Drawing.Point(13, 6);
            this.groupBoxTitulo.Name = "groupBoxTitulo";
            this.groupBoxTitulo.Size = new System.Drawing.Size(700, 80);
            this.groupBoxTitulo.TabIndex = 9;
            this.groupBoxTitulo.TabStop = false;
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.Location = new System.Drawing.Point(14, 425);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(0, 15);
            this.labelMensagem.TabIndex = 10;
            // 
            // labelErro
            // 
            this.labelErro.AutoSize = true;
            this.labelErro.ForeColor = System.Drawing.Color.Red;
            this.labelErro.Location = new System.Drawing.Point(581, 347);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(0, 13);
            this.labelErro.TabIndex = 11;
            // 
            // labelFormato
            // 
            this.labelFormato.AutoSize = true;
            this.labelFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormato.Location = new System.Drawing.Point(249, 16);
            this.labelFormato.Name = "labelFormato";
            this.labelFormato.Size = new System.Drawing.Size(69, 16);
            this.labelFormato.TabIndex = 12;
            this.labelFormato.Text = "Formato:";
            this.labelFormato.Click += new System.EventHandler(this.labelFormato_Click);
            // 
            // cmbFormatos
            // 
            this.cmbFormatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormatos.FormattingEnabled = true;
            this.cmbFormatos.Location = new System.Drawing.Point(252, 40);
            this.cmbFormatos.Name = "cmbFormatos";
            this.cmbFormatos.Size = new System.Drawing.Size(165, 26);
            this.cmbFormatos.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkBoxAudio);
            this.groupBox2.Controls.Add(this.chkBoxVideo);
            this.groupBox2.Controls.Add(this.labelFormato);
            this.groupBox2.Controls.Add(this.cmbFormatos);
            this.groupBox2.Location = new System.Drawing.Point(13, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 83);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelPorcentagem);
            this.groupBox3.Controls.Add(this.btnBaixar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.progresso);
            this.groupBox3.Location = new System.Drawing.Point(13, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // chkBoxVideo
            // 
            this.chkBoxVideo.AutoSize = true;
            this.chkBoxVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxVideo.Location = new System.Drawing.Point(26, 45);
            this.chkBoxVideo.Name = "chkBoxVideo";
            this.chkBoxVideo.Size = new System.Drawing.Size(64, 22);
            this.chkBoxVideo.TabIndex = 14;
            this.chkBoxVideo.Text = "Vídeo";
            this.chkBoxVideo.UseVisualStyleBackColor = true;
            this.chkBoxVideo.CheckedChanged += new System.EventHandler(this.chkBoxVideo_CheckedChanged);
            // 
            // chkBoxAudio
            // 
            this.chkBoxAudio.AutoSize = true;
            this.chkBoxAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxAudio.Location = new System.Drawing.Point(117, 45);
            this.chkBoxAudio.Name = "chkBoxAudio";
            this.chkBoxAudio.Size = new System.Drawing.Size(64, 22);
            this.chkBoxAudio.TabIndex = 15;
            this.chkBoxAudio.Text = "Áudio";
            this.chkBoxAudio.UseVisualStyleBackColor = true;
            this.chkBoxAudio.CheckedChanged += new System.EventHandler(this.chkBoxAudio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de arquivo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("AstoriaExtraBoldItalic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(139, 11);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(47, 42);
            this.D.TabIndex = 1;
            this.D.Text = "D";
            this.D.Visible = false;
            // 
            // download
            // 
            this.download.AutoSize = true;
            this.download.Font = new System.Drawing.Font("AstoriaExtraBoldItalic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.Location = new System.Drawing.Point(175, 25);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(120, 22);
            this.download.TabIndex = 2;
            this.download.Text = "OWNLOAD";
            this.download.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.groupBoxTitulo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download de Vídeos";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTitulo.ResumeLayout(false);
            this.groupBoxTitulo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLinkVideo;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.TextBox txtLocalDestino;
        private System.Windows.Forms.GroupBox groupBoxTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.FolderBrowserDialog salvarArquivo;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Label labelPorcentagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelErro;
        private System.Windows.Forms.ComboBox cmbFormatos;
        private System.Windows.Forms.Label labelFormato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxAudio;
        private System.Windows.Forms.CheckBox chkBoxVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label download;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

