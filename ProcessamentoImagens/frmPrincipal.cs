using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class btnEspelharDiagonal : Form
    {
        private Image image;
        private Bitmap imageBitmap;

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public btnEspelharDiagonal()
        {
            InitializeComponent();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg1.Image = image;
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Zoom;
                //pictBoxImg2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg1.Image = null;
            //pictBoxImg2.Image = null;
        }

        private void btnLuminanciaSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_gray(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnLuminanciaComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_grayDMA(imageBitmap, imgDest);
            //pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativo(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativoDMA(imageBitmap, imgDest);
            //pictBoxImg2.Image = imgDest;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void btnEspelharVertical_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelharVertical(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnnEspelharHorizontal_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelharHorizontal(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnSepararVermelho_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarVermelho(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnSepararAzul_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarAzul(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnSepararVerde_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarVerde(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnPretoEBranco_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.pretoEBranco(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnRotacionar90_click(object sender, EventArgs e)
        {
            imageBitmap = (Bitmap)image;
            Bitmap imgDest = new Bitmap(imageBitmap.Height,imageBitmap.Width);
            Filtros.rotacao(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnInverteVermelhoComAzul_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.inverteVermelhoComAzul(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnEspelharDiagonal_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelharDiagonal(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btnFatiarDoMeio_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.fatiarDoMeio(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btn8Conectada_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.quatro_conectada(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
            //pictBoxImg2.Image = imgDest;
        }

        private void btn4Conectadas_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.oito_conectada(imageBitmap, imgDest);
            //pictBoxImg2.Image = imgDest;
        }

        private void btnReducao_Click(object sender, EventArgs e)
        {
            imageBitmap = (Bitmap)image;
            Bitmap imageDest = new Bitmap(imageBitmap.Width / 2, imageBitmap.Height / 2);
            Filtros.ReduzirResolução(imageBitmap, imageDest);
            //pictBoxImg2.Image = imageDest;
        }

        private void btnEspelharVerticalComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.EspelharVerticalComDMA(imageBitmap, imgDest);
            //pictBoxImg2.Image = imgDest;
        }

        private void btnEspelharHorinzontalComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.EspelharHorizontalComDMA(imageBitmap, imgDest);
            //pictBoxImg2.Image = imgDest;
        }

        private void btnEscalaCinzaResolucao_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.EscalaCinzaComN(imageBitmap, imgDest,16);
            //pictBoxImg2.Image = imgDest;
        }

        private void semDMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictBoxImg1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dilatacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.DilatacaoSemDMA(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
        }

        private void erosãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image.Width,image.Height);
            imageBitmap = (Bitmap)image;
            Filtros.ErosaoSemDMA(imageBitmap, imgDest);
            pictBoxImg1.Image = imgDest;
        }

        private void aberturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap erosao = new Bitmap(image.Width, image.Height);
            imageBitmap = (Bitmap)image;
            Filtros.ErosaoSemDMA(imageBitmap, erosao);
            Bitmap aberto = new Bitmap(image);
            Filtros.DilatacaoSemDMA(erosao, aberto);
            pictBoxImg1.Image = aberto;
        }   

        private void fechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Dilatacao = new Bitmap(image.Width, image.Height);
            imageBitmap = (Bitmap)image;
            Filtros.DilatacaoSemDMA(imageBitmap, Dilatacao);
            Bitmap fechamento = new Bitmap(image);
            Filtros.ErosaoSemDMA(Dilatacao, fechamento);
            pictBoxImg1.Image = fechamento;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictBoxImg1.Image != null) // Verifica se há uma imagem carregada
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";
                saveFileDialog.FileName = "imagem_editada"; // Nome padrão para o arquivo

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Determina o formato com base na extensão do arquivo escolhido
                    ImageFormat format = ImageFormat.Png; // Padrão: PNG
                    string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();
                    switch (extension)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                    }

                    // Salva a imagem no caminho escolhido pelo usuário
                    pictBoxImg1.Image.Save(saveFileDialog.FileName, format);
                    MessageBox.Show("Imagem salva com sucesso!", "Salvar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma imagem carregada para salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maisConfiguracaoDaImagem_RightClick(object sender, MouseEventArgs e)
        {
            //// Verifica se o botão direito do mouse foi clicado
            //if (e.Button == MouseButtons.Right)
            //{
            //    //// Cria uma instância do FormConfiguracoes
            //    //using (ModalConfig form = new ModalConfig())
            //    //{
            //    //    // Exibe o formulário como modal

            //    //    form.TopMost = true;

            //    //    form.ShowDialog();
                    
            //    //}
            //}
        }

        private void dividirATelaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirModaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Suponha que você já tenha uma imagem carregada, por exemplo:

            // Cria uma instância do modal formImagem
            formImagem form = new formImagem();

            // Passa a imagem para o modal antes de exibi-lo
            form.CarregarImagem(image);

            // Exibe o modal
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnJanelar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; // Altera o estado para janela normal
            }
            else
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Altera o estado para janela normal
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Normal)
            {
                isDragging = true; // Marca que o arrasto começou
                startPoint = new Point(e.X, e.Y); // Armazena a posição inicial do mouse
            }
        }

        // Evento MouseMove - Move a janela
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calcula a nova posição da janela com base no movimento do mouse
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        // Evento MouseUp - Encerra o arrasto
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Normal)
            {
                isDragging = false; // O arrasto terminou
            }
        }
    }
}
