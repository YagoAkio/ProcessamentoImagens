using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    class Filtros
    {
        //sem acesso direto a memoria
        public static void convert_to_gray(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Int32 gs;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;
                    gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);

                    //nova cor
                    Color newcolor = Color.FromArgb(gs, gs, gs);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        //sem acesso direito a memoria
        public static void negativo(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;

                    //nova cor
                    Color newcolor = Color.FromArgb(255 - r, 255 - g, 255 - b);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        //com acesso direto a memória
        public static void convert_to_grayDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;
            Int32 gs;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++); //está armazenado dessa forma: b g r 
                        g = *(src++);
                        r = *(src++);
                        gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        //com acesso direito a memoria
        public static void negativoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;

            //lock dados bitmap origem 
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src1 = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src1++); //está armazenado dessa forma: b g r 
                        g = *(src1++);
                        r = *(src1++);

                        *(dst++) = (byte)(255 - b);
                        *(dst++) = (byte)(255 - g);
                        *(dst++) = (byte)(255 - r);
                    }
                    src1 += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem 
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void espelharVertical(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    // Coloca o pixel na posição espelhada na imagem de destino
                    // Inverte a posição verticalmente
                    imageBitmapDest.SetPixel(x, height - y - 1, cor);
                }
            }
        }

        public static void espelharHorizontal(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    // Coloca o pixel na posição espelhada na imagem de destino
                    // Inverte a posição verticalmente
                    imageBitmapDest.SetPixel(width - x - 1, y, cor);
                }
            }
        }

        public static void separarVermelho(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;

                    
                    Color newcolor = Color.FromArgb(r, 0, 0);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void separarVerde(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;


                    Color newcolor = Color.FromArgb(0, g, 0);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void separarAzul(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;


                    Color newcolor = Color.FromArgb(0, 0, b);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void pretoEBranco(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Color newcolor;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;


                    if ((r + g + b) < 382)
                    {
                        newcolor = Color.White;
                    }
                    else
                    {
                        newcolor = Color.Black;
                    }

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void rotacao(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    // Coloca o pixel na posição espelhada na imagem de destino
                    // Inverte a posição verticalmente
                    imageBitmapDest.SetPixel(y, width - 1 - x, cor);
                }
            }
        }

        public static void inverteVermelhoComAzul(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {

            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;


                    Color newcolor = Color.FromArgb(b, g, r);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        public static void espelharDiagonal(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    // Coloca o pixel na posição espelhada na imagem de destino
                    // Inverte a posição verticalmente
                    imageBitmapDest.SetPixel(width - x - 1, height - 1 - y, cor);
                }
            }
        }

        public static void fatiarDoMeio(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imageBitmapSrc.GetPixel(x, y);


                    if (x >= width / 2 && y >= height / 2)
                    {
                        // Quadrante inferior direito
                        imageBitmapDest.SetPixel(x - width / 2, y - height / 2, cor);
                    }
                    else if (x < width / 2 && y >= height / 2)
                    {
                        // Quadrante inferior esquerdo
                        imageBitmapDest.SetPixel(x + width / 2, y - height / 2, cor);
                    }
                    else if (x >= width / 2 && y < height / 2)
                    {
                        // Quadrante superior direito
                        imageBitmapDest.SetPixel(x - width / 2, y + height / 2, cor);
                    }
                    else if (x < width / 2 && y < height / 2)
                    {
                        // Quadrante superior esquerdo
                        imageBitmapDest.SetPixel(x + width / 2, y + height / 2, cor);
                    }

                }
            }
        }

        public static void quatro_conectada(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int[,] imgMatrix = new int[height, width];
            int[,] labels = new int[height, width];
            int label = 0;

            // Converter imagem de entrada em matriz binária
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelColor = imageBitmapSrc.GetPixel(j, i);
                    imgMatrix[i, j] = (pixelColor.R == 255) ? 0 : 1; // 1 para objeto, 0 para fundo
                }
            }

            Dictionary<int, List<Point>> segments = new Dictionary<int, List<Point>>();

            // Segmentação 4-conectada
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (imgMatrix[i, j] == 1 && labels[i, j] == 0) // Encontrar pixel não rotulado
                    {
                        label++;
                        List<Point> segment = new List<Point>();
                        Queue<Point> queue = new Queue<Point>();
                        queue.Enqueue(new Point(j, i));
                        labels[i, j] = label;

                        while (queue.Count > 0)
                        {
                            Point p = queue.Dequeue();
                            segment.Add(p);

                            // Vizinhos 4-conectados (acima, abaixo, esquerda, direita)
                            List<Point> neighbors = new List<Point>
                        {
                            new Point(p.X - 1, p.Y), // Esquerda
                            new Point(p.X + 1, p.Y), // Direita
                            new Point(p.X, p.Y - 1), // Acima
                            new Point(p.X, p.Y + 1)  // Abaixo
                        };

                            foreach (Point neighbor in neighbors)
                            {
                                if (neighbor.X >= 0 && neighbor.X < width && neighbor.Y >= 0 && neighbor.Y < height)
                                {
                                    if (imgMatrix[neighbor.Y, neighbor.X] == 1 && labels[neighbor.Y, neighbor.X] == 0)
                                    {
                                        labels[neighbor.Y, neighbor.X] = label;
                                        queue.Enqueue(neighbor);
                                    }
                                }
                            }
                        }

                        segments[label] = segment;
                    }
                }
            }

            // Colorir objetos segmentados
            ColorAndShowSegments(imageBitmapDest, segments);
        }

        // Função para segmentação 8-conectada
        public static void oito_conectada(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int[,] imgMatrix = new int[height, width];
            int[,] labels = new int[height, width];
            int label = 0;

            // Converter imagem de entrada em matriz binária
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelColor = imageBitmapSrc.GetPixel(j, i);
                    imgMatrix[i, j] = (pixelColor.R == 255) ? 0 : 1; // 1 para objeto, 0 para fundo
                }
            }

            Dictionary<int, List<Point>> segments = new Dictionary<int, List<Point>>();

            // Segmentação 8-conectada
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (imgMatrix[i, j] == 1 && labels[i, j] == 0) // Encontrar pixel não rotulado
                    {
                        label++;
                        List<Point> segment = new List<Point>();
                        Queue<Point> queue = new Queue<Point>();
                        queue.Enqueue(new Point(j, i));
                        labels[i, j] = label;

                        while (queue.Count > 0)
                        {
                            Point p = queue.Dequeue();
                            segment.Add(p);

                            // Vizinhos 8-conectados (acima, abaixo, esquerda, direita e diagonais)
                            List<Point> neighbors = new List<Point>
                        {
                            new Point(p.X - 1, p.Y),     // Esquerda
                            new Point(p.X + 1, p.Y),     // Direita
                            new Point(p.X, p.Y - 1),     // Acima
                            new Point(p.X, p.Y + 1),     // Abaixo
                            new Point(p.X - 1, p.Y - 1), // Diagonal superior esquerda
                            new Point(p.X + 1, p.Y - 1), // Diagonal superior direita
                            new Point(p.X - 1, p.Y + 1), // Diagonal inferior esquerda
                            new Point(p.X + 1, p.Y + 1)  // Diagonal inferior direita
                        };

                            foreach (Point neighbor in neighbors)
                            {
                                if (neighbor.X >= 0 && neighbor.X < width && neighbor.Y >= 0 && neighbor.Y < height)
                                {
                                    if (imgMatrix[neighbor.Y, neighbor.X] == 1 && labels[neighbor.Y, neighbor.X] == 0)
                                    {
                                        labels[neighbor.Y, neighbor.X] = label;
                                        queue.Enqueue(neighbor);
                                    }
                                }
                            }
                        }

                        segments[label] = segment;
                    }
                }
            }

            // Colorir objetos segmentados
            ColorAndShowSegments(imageBitmapDest, segments);
        }

        static void ColorAndShowSegments(Bitmap img, Dictionary<int, List<Point>> segments)
        {
            Random rand = new Random();

            foreach (var segment in segments)
            {
                Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                // Calcula a área e a dimensão de cada objeto
                int minX = img.Width, minY = img.Height, maxX = 0, maxY = 0;

                foreach (Point p in segment.Value)
                {
                    img.SetPixel(p.X, p.Y, randomColor);
                    if (p.X < minX) minX = p.X;
                    if (p.Y < minY) minY = p.Y;
                    if (p.X > maxX) maxX = p.X;
                    if (p.Y > maxY) maxY = p.Y;
                }

                int area = segment.Value.Count;
                int objWidth = maxX - minX + 1;
                int objHeight = maxY - minY + 1;

                Console.WriteLine($"Objeto {segment.Key}: Área = {area} pixels, Largura = {objWidth}, Altura = {objHeight}");
            }
        }

        public static void ReduzirResolução(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int originalWidth = imageBitmapSrc.Width;
            int originalHeight = imageBitmapSrc.Height;

            // As dimensões da nova imagem devem ser metade da original
            if (imageBitmapDest.Width != originalWidth / 2 || imageBitmapDest.Height != originalHeight / 2)
            {
                throw new ArgumentException("A imagem de destino deve ter metade da largura e altura da imagem original.");
            }

            // Percorrer a imagem em blocos de 2x2 pixels
            for (int y = 0; y < originalHeight / 2; y++)
            {
                for (int x = 0; x < originalWidth / 2; x++)
                {
                    // Pegar os 4 pixels (2x2 bloco) da imagem original
                    Color p1 = imageBitmapSrc.GetPixel(x * 2, y * 2);
                    Color p2 = imageBitmapSrc.GetPixel(x * 2 + 1, y * 2);
                    Color p3 = imageBitmapSrc.GetPixel(x * 2, y * 2 + 1);
                    Color p4 = imageBitmapSrc.GetPixel(x * 2 + 1, y * 2 + 1);

                    // Calcular a média dos valores de cinza dos 4 pixels
                    int grayValue = (p1.R + p2.R + p3.R + p4.R) / 4;

                    // Criar uma nova cor em tons de cinza a partir da média
                    Color newPixelColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    // Atribuir o novo valor à imagem de destino
                    imageBitmapDest.SetPixel(x, y, newPixelColor);
                }
            }
        }

        public static void EspelharHorizontalComDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;  // 3 bytes por pixel (RGB)

            // lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            // lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int paddingSrc = bitmapDataSrc.Stride - (width * pixelSize);
            int paddingDst = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                // Iterar sobre cada linha da imagem
                for (int y = 0; y < height; y++)
                {
                    // Apontar para o início da linha no destino, mas começando pelo final (para espelhar)
                    byte* dstLine = dst + y * bitmapDataDst.Stride;
                    byte* srcLine = src + y * bitmapDataSrc.Stride;

                    // Iterar sobre cada pixel da linha e copiar para a posição espelhada
                    for (int x = 0; x < width; x++)
                    {
                        int dstIndex = (width - x - 1) * pixelSize;  // Índice no destino, invertido
                        int srcIndex = x * pixelSize;                // Índice no origem

                        // Copiar os componentes RGB
                        dstLine[dstIndex] = srcLine[srcIndex];       // componente B
                        dstLine[dstIndex + 1] = srcLine[srcIndex + 1]; // componente G
                        dstLine[dstIndex + 2] = srcLine[srcIndex + 2]; // componente R
                    }
                }
            }

            // Unlock os bits de origem e destino
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void EspelharVerticalComDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;  // 3 bytes por pixel (RGB)

            // lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            // lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int paddingSrc = bitmapDataSrc.Stride - (width * pixelSize);
            int paddingDst = bitmapDataDst.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                // Iterar sobre cada linha da imagem
                for (int y = 0; y < height; y++)
                {
                    // Apontar para o início da linha de destino, mas começando na linha espelhada (de baixo para cima)
                    byte* dstLine = dst + (height - y - 1) * bitmapDataDst.Stride;
                    byte* srcLine = src + y * bitmapDataSrc.Stride;

                    // Copiar toda a linha da origem para o destino, sem modificar a ordem horizontal
                    for (int x = 0; x < width; x++)
                    {
                        int pixelIndex = x * pixelSize;  // Índice para os componentes RGB do pixel atual

                        // Copiar os componentes RGB da origem para o destino
                        dstLine[pixelIndex] = srcLine[pixelIndex];         // componente B
                        dstLine[pixelIndex + 1] = srcLine[pixelIndex + 1]; // componente G
                        dstLine[pixelIndex + 2] = srcLine[pixelIndex + 2]; // componente R
                    }
                }
            }

            // Unlock os bits de origem e destino
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void EscalaCinzaComN(Bitmap imageBitmapSrc, Bitmap imageBitmapDest, int resolucao)
        {
            // Garantir que a resolução está dentro de limites válidos
            if (resolucao < 2 || resolucao > 256)
            {
                throw new ArgumentException("A resolução deve estar entre 2 e 256.");
            }

            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;

            // Lock bits da imagem de origem e destino
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int pixelSize = 3;  // 3 bytes por pixel (RGB)
            int paddingSrc = bitmapDataSrc.Stride - (width * pixelSize);
            int paddingDst = bitmapDataDst.Stride - (width * pixelSize);

            // Redução de tons de cinza: calcular o fator de redução
            int step = 256 / resolucao;  // Intervalo para cada nível de cinza

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        // Pegar os componentes RGB
                        byte b = *(src++);
                        byte g = *(src++);
                        byte r = *(src++);

                        // Calcular o valor de cinza (média dos canais RGB)
                        int gray = (r + g + b) / 3;

                        // Reduzir a escala de cinza com base na nova resolução
                        gray = (gray / step) * step;

                        // Aplicar o novo valor de cinza nos canais RGB
                        *(dst++) = (byte)gray;  // Blue
                        *(dst++) = (byte)gray;  // Green
                        *(dst++) = (byte)gray;  // Red
                    }

                    // Pular padding (se houver)
                    src += paddingSrc;
                    dst += paddingDst;
                }
            }

            // Unlock bits
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void DilatacaoSemDMA(Bitmap Origem, Bitmap Destino)
        {
            int width = Origem.Width;
            int height = Origem.Height;
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = Origem.GetPixel(x, y);

                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    if (r+g+b < 382)
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
                                    Destino.SetPixel(newX, newY, Color.Red);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
