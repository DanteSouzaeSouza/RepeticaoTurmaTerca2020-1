using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeticaoTurmaTerca2020_1
{
    public partial class FrmNumeros : Form
    {
        public FrmNumeros()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando o ListBox
            lbNumeros.Items.Clear();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            // Limpando o ListBox
            lbNumeros.Items.Clear();
            // usando o laço for para preencher o ListBox
            for (int i = 0; i <= 100; i++)
            {
                // Checando se o índice atual é par
                if (i % 2 == 0)
                {
                    // Adicionando o Item ao ListBox
                    lbNumeros.Items.Add(i.ToString());
                }
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // Limpando o ListBox
            lbNumeros.Items.Clear();
            // Criando a variável de controle
            int i = 0;

            // Verificar com while a repetição
            while (i <= 100)
            {
                // verificar se o i é par
                if (i % 2 == 0)
                {
                    // Adicionando o Item ao ListBox
                    lbNumeros.Items.Add(i.ToString());
                }
                // incrementando a variável de controle
                i++;
            }


        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            // Limpando o ListBox
            lbNumeros.Items.Clear();
            // Criando a variável de controle
            int i = 0;

            // executando a repetição com do-while
            do
            {
                // verificar se o i é par
                if (i % 2 == 0)
                {
                    // Adicionando o Item ao ListBox
                    lbNumeros.Items.Add(i.ToString());
                }
                // incrementando a variável de controle
                i++;
            } while (i <= 100);

        }
    }
}
