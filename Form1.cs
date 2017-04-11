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
                StreamReader fs = new StreamReader(dlgAbrirArq.FileName);
                string linha = "";
                while ((linha = fs.ReadLine()) != null)
                {
                    lista.QtasLinhas = lista.QtasLinhas + 1;
                    string numero = "";
                    for (int i = 0; i < linha.Length; i++)
                    {
                        if (i + 1 > lista.QtasColunas)
                            lista.QtasColunas++;

                        if (linha[i] != ' ')
                            numero += linha[i];
                        else
                        {
                            lista.Inserir(Convert.ToDouble(numero), i + 1, lista.QtasLinhas);
                            numero = "";
                        }
                    }
                }
                fs.Close();
            }
        }

        private void Listar()
        {
            for (int i = 1; i <= lista.QtasColunas; i++)
                dgvMatriz.Columns.Add(i.ToString(), i.ToString());

            string[] linha = new String[lista.QtasColunas];
            for (int i = 1; i <= lista.QtasLinhas; i++)
            {
                for (int w = 1; w <= lista.QtasColunas; i++)
                    linha[i + 1] = lista.ValorDe(w, i).ToString();

                dgvMatriz.Rows.Add(linha);
            }
        }
    }
}
