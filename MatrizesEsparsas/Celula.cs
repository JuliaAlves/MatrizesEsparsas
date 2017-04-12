using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesEsparsas
{
    public class Celula : IComparable<Celula>
    {
        private Celula direita;
        private Celula abaixo;
        private int linha, coluna;
        private double valor;


        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="v">valor</param>
        /// <param name="l">linha</param>
        /// <param name="c">coluna</param>
        /// <param name="dir">Ponteiro para a celula a direita</param>
        /// <param name="abx">Ponteiro para a celula abaixo</param>
        public Celula(double v, int l, int c, Celula dir,Celula abx)
        {
            this.Abaixo = abx;
            this.Coluna = c;
            this.Direita = dir;
            this.Valor = v;
            this.Linha = l;
        }
        
        /// <summary>
        /// Celula a direita do this na matriz
        /// </summary>
        public Celula Direita
        {
            get { return direita; }
            set { direita = value; }
        }

        /// <summary>
        /// Celula abaixo do this na matriz
        /// </summary>
        public Celula Abaixo
        {
            get { return abaixo; }
            set { abaixo = value; }
        }

        /// <summary>
        /// linha em que o this se encontra na matriz
        /// </summary>
        public int Linha
        {
            get { return linha; }
            set { linha = value; }
        }

        /// <summary>
        /// coluna em que o this se encontra na matriz
        /// </summary>
        public int Coluna
        {
            get { return coluna; }
            set { coluna = value; }
        }

        /// <summary>
        /// número que está armazenado
        /// </summary>
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        /// <summary>
        /// Compara dois valores 
        /// </summary>
        /// <param name="outro">Valor a ser comparado</param>
        /// <returns>Devolve 1 se for maior, 0 se for igual e -1 se for menor</returns>
        public int CompareTo(Celula outro)
        {
            return this.Valor.CompareTo(outro.Valor);
        }

        /// <summary>
        /// Tranforma o objeto em string
        /// </summary>
        /// <returns>String contendo o valor do objeto</returns>
        public override String ToString()
        {
            return "" + valor;
        }

    }
}