using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATIVIDADE_AVALIATIVA
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            string nome = textBox1.Text;
            if (nome == "valter pereira oliveira")
                MessageBox.Show("valter pereira oliveira\n02/09/1940\nmasculino\nSolteiro\nRua das orquideas\njardim tropical2\nSão Luís\n65110000\nMA\nvalter.oliveira@acad.ifma.edu.br\n98982370033");

        }
    }
}
