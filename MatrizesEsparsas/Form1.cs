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
            if(dlgAbrirArq.ShowDialog() == DialogResult.OK)
            {
                StreamReader fs = new StreamReader(dlgAbrirArq.FileName);
                string linha = "";
                while((linha = fs.ReadLine()) != null)
                {
                    lista.QtasLinhas = lista.QtasLinhas + 1;
                    for(int i=0; i<linha.Length; i++)
                    {
                        if (i > lista.QtasColunas)
                            lista.QtasColunas++;
                    }
                }
            }
        }
    }
}
