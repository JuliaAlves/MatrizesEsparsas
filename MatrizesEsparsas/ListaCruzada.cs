using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesEsparsas
{
    class ListaCruzada
    {
        int qtasColunas, qtasLinhas;
        Celula cabecaLinha = null, cabecaColuna = null, atual;

        public int QtasColunas
        {
            get
            {
                return qtasColunas;
            }
            set
            {
                qtasColunas = value;
            }
        }

        public int QtasLinhas
        {
            get
            {
                return QtasLinhas;
            }
            set
            {
                QtasLinhas  = value;
            }
        }

        public ListaCruzada(int colunas, int linhas)
        {
            qtasColunas = colunas;
            qtasLinhas  = linhas;

            Celula coluna1 = null;
            //Coluna 1 será o primeiro nó cabeça
            for (int i=0; i<=qtasColunas; i++)
            {                
                Celula aux = null;
                if (cabecaColuna != null)
                {
                    aux = cabecaColuna;
                    cabecaColuna = cabecaColuna.Direita;
                    cabecaColuna = new Celula(0.0, 0, i, null, null);
                    aux.Direita = cabecaColuna;
                }
                else
                {
                    coluna1 = cabecaColuna = new Celula(0.0, 0, i, null, null);
                }                
            }
            cabecaColuna.Direita = coluna1;
            cabecaColuna = cabecaColuna.Direita;

            Celula linha1 = null;
            //Linha 1 será o primeiro nó cabeça
            for (int j=0; j<= qtasLinhas; j++)
            {
                Celula aux = null;
                if (cabecaLinha != null)
                {
                    aux = cabecaLinha;
                    cabecaLinha = cabecaLinha.Abaixo;
                    cabecaLinha = new Celula(0.0, j, 0, null, null);
                    aux.Abaixo = cabecaLinha;
                }
                else
                {
                    linha1 = cabecaLinha = new Celula(0.0, j, 0, null, null);
                }
            }
            cabecaLinha.Abaixo = linha1;
            cabecaLinha = cabecaLinha.Abaixo;
        }

        public void Inserir(double v, int x, int y)
        {
            if (x > qtasColunas || y > qtasLinhas)
                throw new Exception("Número de linhas ou colunas não pode ser maior que tamanho da matriz");
            if (x < 0 || y < 0)
                throw new Exception("Número de linhas ou colunas não pode ser menor que 0");

            Celula aIncluir = new Celula(v, x, y, null, null);
            Celula aux = null;

            atual = cabecaColuna;
            for (int i = 0; i < x; i++)
            {
                atual = atual.Direita;
            }
            aux = atual.Direita;
            atual.Direita = aIncluir;
            aIncluir.Direita = aux;

            atual = cabecaLinha;
            for(int j = 0; j < y; j++)
            {
                atual = atual.Abaixo;
            }
            aux = atual.Abaixo;
            atual.Abaixo = aIncluir;
            aIncluir.Abaixo = aux;
        }
        
    }
}