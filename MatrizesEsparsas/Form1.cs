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
        ListaCruzada matriz1, matriz2;

        public frmMatrizEsparsa()
        {
            InitializeComponent();
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            lerArquivo(dgvMatriz,ref  matriz1);                        
        }

        public void lerArquivo(DataGridView dgvListar, ref ListaCruzada lista)
        {
            if (dlgAbrirArq.ShowDialog() == DialogResult.OK)
            {
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
                Listar(dgvListar, lista);
            }
        }

        private void Listar(DataGridView dgv, ListaCruzada matriz)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            for (int i = 0; i < matriz.QtasColunas; i++)
                dgv.Columns.Add(i.ToString(), i.ToString());

            string[] linha = new string[matriz.QtasColunas];
            for (int i = 0; i < matriz.QtasLinhas; i++)
            {
                for (int w = 0; w < matriz.QtasColunas; w++)
                    linha[w] = matriz.ValorDe(w, i).ToString();

                dgv.Rows.Add(linha);
            }
        }

        private void btnSomarK_Click(object sender, EventArgs e)
        {
            matriz1.somarConstante(Convert.ToInt32(txtK.Text), Convert.ToInt32(txtColuna.Text));
            Listar(dgvMatriz, matriz1);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            matriz1.Limpar();
            Listar(dgvMatriz, matriz1);
        }

        private void btnAbrirDois_Click(object sender, EventArgs e)
        {
            btnSomarMatriz.Enabled = true;
            btnMultiplicarMatriz.Enabled = true;
            lerArquivo(dataGridView1,ref matriz2);
        }

        private void btnSomarMatriz_Click(object sender, EventArgs e)
        {
            Listar(dataGridView2, matriz1.somar(matriz2));
        }
    }
}
