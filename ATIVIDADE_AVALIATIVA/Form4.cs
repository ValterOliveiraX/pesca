using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_AVALIATIVA
{
    public partial class excluir : Form
    {
        public excluir()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            DialogResult result = MessageBox.Show("\nEXCLUIR\nvalter pereira oliveira\n02/09/1940\nmasculino\nSolteiro\nRua das orquideas\njardim tropical2\nSão Luís\n65110000\nMA\nvalter.oliveira@acad.ifma.edu.br\n98982370033", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Verifica qual botão foi clicado
            if (result == DialogResult.Yes)
            {
                // Ação a ser realizada se o usuário clicar em "Sim"
                //SalvarDados();
                MessageBox.Show("Dados EXCLUIDOS com sucesso!");
            }
            else if (result == DialogResult.No)
            {
                // Ação a ser realizada se o usuário clicar em "Não"
                MessageBox.Show("Operação cancelada.");
            }
        }
    }
}
