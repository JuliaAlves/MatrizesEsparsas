using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatrizesEsparsas
{
    public partial class frmMatrizEsparsa : Form
    {
        ListaCruzada lista;

        public frmMatrizEsparsa()
        {
            InitializeComponent();
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (dlgAbrirArq.ShowDialog() == DialogResult.OK)
            {
                bool ehPrimeira = true;
                StreamReader fs = new StreamReader(dlgAbrirArq.FileName);
                string linha = fs.ReadLine();
                string[] partes = linha.Split(' ');
                lista = new ListaCruzada(Convert.ToInt32(partes[0]), Convert.ToInt32(partes[1]));
                while ((linha = fs.ReadLine()) != null)
                {
                    partes = linha.Split(' ');
                    lista.Inserir(new Celula(Convert.ToDouble(partes[2]), Convert.ToInt32(partes[1]), 
                                  Convert.ToInt32(partes[0]), null, null));
                }
                fs.Close();
                Listar();
            }            
        }

        private void Listar()
        {
            for (int i = 0; i < lista.QtasColunas; i++)
                dgvMatriz.Columns.Add(i.ToString(), i.ToString());

            string[] linha = new string[lista.QtasColunas];
            for (int i = 0; i < lista.QtasLinhas; i++)
            {
                for (int w = 0; w < lista.QtasColunas; w++)
                    linha[w] = lista.ValorDe(w, i).ToString();

                dgvMatriz.Rows.Add(linha);
            }
        }

        private void btnSomarK_Click(object sender, EventArgs e)
        {
            lista.somarConstante(Convert.ToInt32(txtK.Text), Convert.ToInt32(txtColuna.Text));
            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.Limpar();
            Listar();
        }
    }
}
