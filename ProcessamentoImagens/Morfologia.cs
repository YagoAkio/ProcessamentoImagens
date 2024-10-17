using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens
{
    class Morfologia
    {
        private int[][] ElementoEstruturante { set; get; }
        private List<int> PontoCentral {get;set;}

        public Morfologia(int [][] elementoEstruturante, List<int> pontoCentral)
        {
            this.PontoCentral = pontoCentral;
            this.ElementoEstruturante = elementoEstruturante;
        }

        public void Dilatacao(Bitmap Origem, Bitmap Destino)
        {
            int altura = Origem.Height;
            int largura = Origem.Width;
            int alturaEstruturante = ElementoEstruturante.Length;
            int larguraEstruturante = ElementoEstruturante[0].Length;

            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Color pixel = Origem.GetPixel(x, y);

                    // Se o pixel for preto, aplicamos o elemento estruturante
                    if (pixel.ToArgb() == Color.Black.ToArgb())
                    {
                        // Aplicando o elemento estruturante ao redor do pixel
                        for (int yMatriz = 0; yMatriz < alturaEstruturante; yMatriz++)
                        {
                            for (int xMatriz = 0; xMatriz < larguraEstruturante; xMatriz++)
                            {
                                // Calcular as coordenadas reais na imagem
                                int novoY = y + (yMatriz - PontoCentral[0]);
                                int novoX = x + (xMatriz - PontoCentral[1]);

                                // Verificar se estamos dentro dos limites da imagem
                                if (novoY >= 0 && novoY < altura && novoX >= 0 && novoX < largura)
                                {
                                    // Se o elemento estruturante for 1, alteramos o pixel na imagem de destino
                                    if (ElementoEstruturante[yMatriz][xMatriz] == 1)
                                    {
                                        Destino.SetPixel(novoX, novoY, Color.Black);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void DilatacaoSemDMA(Bitmap Origem, Bitmap Destino)
        {
            int width = Origem.Width;
            int height = Origem.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Destino.SetPixel(x, y, Color.White);
                }
            }
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = Origem.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    if (r + g + b < 382)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                int newX = x + dx;
                                int newY = y + dy;

                                // Verifica se o novo pixel está dentro dos limites da imagem
                                if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                                {
                                    Destino.SetPixel(newX, newY, Color.Black);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void ErosaoSemDMA(Bitmap Origem, Bitmap Destino)
        {
            int width = Origem.Width;
            int height = Origem.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Destino.SetPixel(x, y, Color.White);
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = Origem.GetPixel(x, y);

                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;

                    if (r + g + b < 382)
                    {
                        bool aprovado = true;
                        for (int dy = -1; dy <= 1 && aprovado; dy++)
                        {
                            for (int dx = -1; dx <= 1 && aprovado; dx++)
                            {
                                int newX = x + dx;
                                int newY = y + dy;
                                Color pixelAux = Origem.GetPixel(newX, newY);
                                r = pixelAux.R;
                                g = pixelAux.G;
                                b = pixelAux.B;
                                if (r + g + b > 382)
                                {
                                    aprovado = false;
                                }
                            }
                        }
                        if (aprovado)
                        {
                            Destino.SetPixel(x, y, Color.Black);
                        }
                    }
                }
            }
        }
    }
}
