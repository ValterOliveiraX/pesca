using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ATIVIDADE_AVALIATIVA
{
    public partial class cadastrar : Form
    {
        private List<Pessoa> listaPessoas = new List<Pessoa>();
        public cadastrar()
        {
            InitializeComponent();
        }
        //----------------------------salvar ------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            MessageBox.Show("cadastro realizado com sucesso");



        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            string nome = textNome.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1 = new DateTimePicker(); 
        }
    }
}
