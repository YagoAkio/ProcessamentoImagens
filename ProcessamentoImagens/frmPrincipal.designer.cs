namespace ProcessamentoImagens
{
    partial class btnEspelharDiagonal
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
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.pictBoxImg2 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLuminanciaSemDMA = new System.Windows.Forms.Button();
            this.btnLuminanciaComDMA = new System.Windows.Forms.Button();
            this.btnNegativoComDMA = new System.Windows.Forms.Button();
            this.btnNegativoSemDMA = new System.Windows.Forms.Button();
            this.btnEspelharVertical = new System.Windows.Forms.Button();
            this.btnEspelharHorinzontal = new System.Windows.Forms.Button();
            this.btnSepararVermelho = new System.Windows.Forms.Button();
            this.btnSepararVerde = new System.Windows.Forms.Button();
            this.btnSepararAzul = new System.Windows.Forms.Button();
            this.btnPretoEBranco = new System.Windows.Forms.Button();
            this.btnRotacionar90 = new System.Windows.Forms.Button();
            this.btnInverteVermelhoComAzul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFatiarDoMeio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(5, 6);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            this.pictBoxImg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg2.Location = new System.Drawing.Point(611, 6);
            this.pictBoxImg2.Name = "pictBoxImg2";
            this.pictBoxImg2.Size = new System.Drawing.Size(600, 500);
            this.pictBoxImg2.TabIndex = 105;
            this.pictBoxImg2.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(5, 512);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(101, 23);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(112, 512);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 23);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // btnLuminanciaSemDMA
            // 
            this.btnLuminanciaSemDMA.Location = new System.Drawing.Point(219, 512);
            this.btnLuminanciaSemDMA.Name = "btnLuminanciaSemDMA";
            this.btnLuminanciaSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnLuminanciaSemDMA.TabIndex = 108;
            this.btnLuminanciaSemDMA.Text = "Luminância sem DMA";
            this.btnLuminanciaSemDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaSemDMA.Click += new System.EventHandler(this.btnLuminanciaSemDMA_Click);
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(219, 541);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnLuminanciaComDMA.TabIndex = 109;
            this.btnLuminanciaComDMA.Text = "Luminância com DMA";
            this.btnLuminanciaComDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaComDMA.Click += new System.EventHandler(this.btnLuminanciaComDMA_Click);
            // 
            // btnNegativoComDMA
            // 
            this.btnNegativoComDMA.Location = new System.Drawing.Point(433, 541);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(208, 23);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = true;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // btnNegativoSemDMA
            // 
            this.btnNegativoSemDMA.Location = new System.Drawing.Point(433, 512);
            this.btnNegativoSemDMA.Name = "btnNegativoSemDMA";
            this.btnNegativoSemDMA.Size = new System.Drawing.Size(208, 23);
            this.btnNegativoSemDMA.TabIndex = 110;
            this.btnNegativoSemDMA.Text = "Negativo sem DMA";
            this.btnNegativoSemDMA.UseVisualStyleBackColor = true;
            this.btnNegativoSemDMA.Click += new System.EventHandler(this.btnNegativoSemDMA_Click);
            // 
            // btnEspelharVertical
            // 
            this.btnEspelharVertical.Location = new System.Drawing.Point(647, 512);
            this.btnEspelharVertical.Name = "btnEspelharVertical";
            this.btnEspelharVertical.Size = new System.Drawing.Size(208, 23);
            this.btnEspelharVertical.TabIndex = 112;
            this.btnEspelharVertical.Text = "Espelhar vertical\r\n";
            this.btnEspelharVertical.UseVisualStyleBackColor = true;
            this.btnEspelharVertical.Click += new System.EventHandler(this.btnEspelharVertical_Click);
            // 
            // btnEspelharHorinzontal
            // 
            this.btnEspelharHorinzontal.Location = new System.Drawing.Point(647, 541);
            this.btnEspelharHorinzontal.Name = "btnEspelharHorinzontal";
            this.btnEspelharHorinzontal.Size = new System.Drawing.Size(208, 23);
            this.btnEspelharHorinzontal.TabIndex = 113;
            this.btnEspelharHorinzontal.Text = "Espelhar Horizontal";
            this.btnEspelharHorinzontal.UseVisualStyleBackColor = true;
            this.btnEspelharHorinzontal.Click += new System.EventHandler(this.btnnEspelharHorizontal_click);
            // 
            // btnSepararVermelho
            // 
            this.btnSepararVermelho.Location = new System.Drawing.Point(861, 512);
            this.btnSepararVermelho.Name = "btnSepararVermelho";
            this.btnSepararVermelho.Size = new System.Drawing.Size(208, 23);
            this.btnSepararVermelho.TabIndex = 114;
            this.btnSepararVermelho.Text = "Separar vermelho";
            this.btnSepararVermelho.UseVisualStyleBackColor = true;
            this.btnSepararVermelho.Click += new System.EventHandler(this.btnSepararVermelho_click);
            // 
            // btnSepararVerde
            // 
            this.btnSepararVerde.Location = new System.Drawing.Point(861, 541);
            this.btnSepararVerde.Name = "btnSepararVerde";
            this.btnSepararVerde.Size = new System.Drawing.Size(208, 23);
            this.btnSepararVerde.TabIndex = 115;
            this.btnSepararVerde.Text = "Separar verde";
            this.btnSepararVerde.UseVisualStyleBackColor = true;
            this.btnSepararVerde.Click += new System.EventHandler(this.btnSepararVerde_click);
            // 
            // btnSepararAzul
            // 
            this.btnSepararAzul.Location = new System.Drawing.Point(861, 570);
            this.btnSepararAzul.Name = "btnSepararAzul";
            this.btnSepararAzul.Size = new System.Drawing.Size(208, 23);
            this.btnSepararAzul.TabIndex = 116;
            this.btnSepararAzul.Text = "Separar azul";
            this.btnSepararAzul.UseVisualStyleBackColor = true;
            this.btnSepararAzul.Click += new System.EventHandler(this.btnSepararAzul_click);
            // 
            // btnPretoEBranco
            // 
            this.btnPretoEBranco.Location = new System.Drawing.Point(861, 628);
            this.btnPretoEBranco.Name = "btnPretoEBranco";
            this.btnPretoEBranco.Size = new System.Drawing.Size(208, 23);
            this.btnPretoEBranco.TabIndex = 118;
            this.btnPretoEBranco.Text = "Preto e branco";
            this.btnPretoEBranco.UseVisualStyleBackColor = true;
            this.btnPretoEBranco.Click += new System.EventHandler(this.btnPretoEBranco_click);
            // 
            // btnRotacionar90
            // 
            this.btnRotacionar90.Location = new System.Drawing.Point(647, 628);
            this.btnRotacionar90.Name = "btnRotacionar90";
            this.btnRotacionar90.Size = new System.Drawing.Size(208, 23);
            this.btnRotacionar90.TabIndex = 119;
            this.btnRotacionar90.Text = "Rotacionar 90°";
            this.btnRotacionar90.UseVisualStyleBackColor = true;
            this.btnRotacionar90.Click += new System.EventHandler(this.btnRotacionar90_click);
            // 
            // btnInverteVermelhoComAzul
            // 
            this.btnInverteVermelhoComAzul.Location = new System.Drawing.Point(433, 628);
            this.btnInverteVermelhoComAzul.Name = "btnInverteVermelhoComAzul";
            this.btnInverteVermelhoComAzul.Size = new System.Drawing.Size(208, 23);
            this.btnInverteVermelhoComAzul.TabIndex = 120;
            this.btnInverteVermelhoComAzul.Text = "Inverte Vermelho com Azul";
            this.btnInverteVermelhoComAzul.UseVisualStyleBackColor = true;
            this.btnInverteVermelhoComAzul.Click += new System.EventHandler(this.btnInverteVermelhoComAzul_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 121;
            this.button1.Text = "Espelhar diagonal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEspelharDiagonal_Click);
            // 
            // btnFatiarDoMeio
            // 
            this.btnFatiarDoMeio.Location = new System.Drawing.Point(5, 628);
            this.btnFatiarDoMeio.Name = "btnFatiarDoMeio";
            this.btnFatiarDoMeio.Size = new System.Drawing.Size(208, 23);
            this.btnFatiarDoMeio.TabIndex = 122;
            this.btnFatiarDoMeio.Text = "Fatiar do meio";
            this.btnFatiarDoMeio.UseVisualStyleBackColor = true;
            this.btnFatiarDoMeio.Click += new System.EventHandler(this.btnFatiarDoMeio_click);
            // 
            // btnEspelharDiagonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 673);
            this.Controls.Add(this.btnFatiarDoMeio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInverteVermelhoComAzul);
            this.Controls.Add(this.btnRotacionar90);
            this.Controls.Add(this.btnPretoEBranco);
            this.Controls.Add(this.btnSepararAzul);
            this.Controls.Add(this.btnSepararVerde);
            this.Controls.Add(this.btnSepararVermelho);
            this.Controls.Add(this.btnEspelharHorinzontal);
            this.Controls.Add(this.btnEspelharVertical);
            this.Controls.Add(this.btnNegativoComDMA);
            this.Controls.Add(this.btnNegativoSemDMA);
            this.Controls.Add(this.btnLuminanciaComDMA);
            this.Controls.Add(this.btnLuminanciaSemDMA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg2);
            this.Controls.Add(this.pictBoxImg1);
            this.Name = "btnEspelharDiagonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLuminanciaSemDMA;
        private System.Windows.Forms.Button btnLuminanciaComDMA;
        private System.Windows.Forms.Button btnNegativoComDMA;
        private System.Windows.Forms.Button btnNegativoSemDMA;
        private System.Windows.Forms.Button btnEspelharVertical;
        private System.Windows.Forms.Button btnEspelharHorinzontal;
        private System.Windows.Forms.Button btnSepararVermelho;
        private System.Windows.Forms.Button btnSepararVerde;
        private System.Windows.Forms.Button btnSepararAzul;
        private System.Windows.Forms.Button btnPretoEBranco;
        private System.Windows.Forms.Button btnRotacionar90;
        private System.Windows.Forms.Button btnInverteVermelhoComAzul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFatiarDoMeio;
    }
}

