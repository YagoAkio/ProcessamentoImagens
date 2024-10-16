using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    public partial class formImagem : Form
    {
        private Image image;        // Para armazenar a imagem
        private Bitmap imageBitmap; // Caso precise manipular a imagem como Bitmap

        public formImagem()
        {
            InitializeComponent();
        }

        // Método público para carregar a imagem no formulário
        public void CarregarImagem(Image img)
        {
            image = img;
            imageBitmap = new Bitmap(image); // Converte para Bitmap se necessário

            // Supondo que você tenha um PictureBox chamado pictureBox1
            pictBoxImg1.Image = imageBitmap; // Exibe a imagem no PictureBox
        }

        private void formImagem_Load(object sender, EventArgs e)
        {
            // Qualquer lógica ao carregar o formulário
        }
    }
}

