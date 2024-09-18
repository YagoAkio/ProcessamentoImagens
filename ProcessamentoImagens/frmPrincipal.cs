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
                pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg1.Image = null;
            pictBoxImg2.Image = null;
        }

        private void btnLuminanciaSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_gray(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnLuminanciaComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.convert_to_grayDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoSemDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativo(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnNegativoComDMA_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.negativoDMA(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
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
            pictBoxImg2.Image = imgDest;
        }

        private void btnnEspelharHorizontal_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelharHorizontal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararVermelho_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarVermelho(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararAzul_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarAzul(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnSepararVerde_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.separarVerde(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnPretoEBranco_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.pretoEBranco(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnRotacionar90_click(object sender, EventArgs e)
        {
            imageBitmap = (Bitmap)image;
            Bitmap imgDest = new Bitmap(imageBitmap.Height,imageBitmap.Width);
            Filtros.rotacao(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnInverteVermelhoComAzul_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.inverteVermelhoComAzul(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnEspelharDiagonal_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.espelharDiagonal(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }

        private void btnFatiarDoMeio_click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.fatiarDoMeio(imageBitmap, imgDest);
            pictBoxImg2.Image = imgDest;
        }
    }
}
