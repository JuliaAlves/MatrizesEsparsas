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
            lista = new ListaCruzada(0, 0);
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (dlgAbrirArq.ShowDialog() == DialogResult.OK)
            {
                bool ehPrimeira = true;
                StreamReader fs = new StreamReader(dlgAbrirArq.FileName);
                string linha = "";
                int qtdNumeros = 0;
                while ((linha = fs.ReadLine()) != null)
                {
                    lista.QtasLinhas = lista.QtasLinhas + 1;
                    string numero = "";
                    for (int i = 0; i < linha.Length; i++)
                    {
                        if (linha[i] != ' ')
                            numero += linha[i];
                        else
                        {
                            if (ehPrimeira)
                                lista.QtasColunas++;
                            if (Convert.ToDouble(numero) != 0.0)
                                lista.Inserir(new Celula(Convert.ToDouble(numero), lista.QtasLinhas-1, qtdNumeros , null, null));
                            numero = "";
                        }
                    }
                    ehPrimeira = false;
                }
                fs.Close();
                Listar();
            }            
        }

        private void Listar()
        {
            for (int i = 1; i <= lista.QtasColunas; i++)
                dgvMatriz.Columns.Add(i.ToString(), i.ToString());

            string[] linha = new String[lista.QtasColunas];
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
