using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draftosaurus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Log(string titulo, string conteudo)
        {
            textBoxLog.AppendText("=====================================================" + Environment.NewLine);
            textBoxLog.AppendText(titulo + Environment.NewLine);
            textBoxLog.AppendText("======================================================" + Environment.NewLine);
            textBoxLog.AppendText(conteudo + Environment.NewLine);
            textBoxLog.AppendText(Environment.NewLine);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string retorno = Jogo.ListarPartidas("");
                Log("Jogo.ListarPartidas(\"A\")", retorno);

            }
            catch (Exception ex)
            {
                Log("ERRO em listarPartidas", ex.Message);


            }
        }
    }
}
