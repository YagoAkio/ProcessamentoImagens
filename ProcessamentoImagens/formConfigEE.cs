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
    public partial class formConfigEE : Form
    {
        public formConfigEE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void SelecionarEE(object sender, EventArgs e)
        {
            // Verifica se os valores dos NumericUpDowns são maiores que zero
            if (numericX.Value > 0 && numericY.Value > 0)
            {
                // Limpar os controles anteriores, se necessário
                panelEE.Controls.Clear();

                // Definir o tamanho e posicionamento dos botões
                int buttonWidth = 30;
                int buttonHeight = 30;
                int padding = 5;

                for (int y = 0; y < numericY.Value; y++)
                {
                    for (int x = 0; x < numericX.Value; x++)
                    {
                        // Criar um novo botão
                        Button btn = new Button();
                        btn.Size = new Size(buttonWidth, buttonHeight);
                        btn.Location = new Point(x * (buttonWidth + padding), y * (buttonHeight + padding));

                        // Opcional: definir texto, tag ou eventos para cada botão
                        btn.Text = $"{x},{y}";
                        btn.Tag = new Point(x, y);  // Tag útil para guardar a posição
                        btn.BackColor = Color.White;
                        btn.FlatStyle = FlatStyle.Popup;

                        // Adicionar o botão a um contêiner, como um Panel
                        panelEE.Controls.Add(btn);
                    }
                }
            }
        }

    }
}
