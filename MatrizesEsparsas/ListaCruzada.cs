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
        Celula primeira, atual;

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
                return qtasLinhas;
            }
            set
            {
                qtasLinhas  = value;
            }
        }

        public ListaCruzada(int colunas, int linhas)
        {
            if (colunas < 0 || linhas < 0)
                throw new Exception("Número de linhas ou colunas não pode ser menor ou iguais que 0");

            qtasColunas = colunas;
            qtasLinhas  = linhas;

            primeira = new Celula(0, -1, -1, null, null);
            Celula aux = primeira;

            for (int j = 0; j < linhas; j++)
            {
                primeira.Abaixo = new Celula(0, j, -1, null, null);
                primeira.Abaixo.Direita = primeira.Abaixo;
                primeira = primeira.Abaixo;
            }
            primeira.Abaixo = aux;
            primeira = primeira.Abaixo;

            for (int i=0; i<colunas; i++)
            {                
                primeira.Direita = new Celula(0, -1, i, null, null);
                primeira.Direita.Abaixo = primeira.Direita;
                primeira = primeira.Direita;
            }
            primeira.Direita = aux;
            primeira = primeira.Direita;

        }

        public void Inserir(Celula aIncluir)
        {
            if (aIncluir == null)
                throw new Exception("parametro nulo");
            
            Celula aux = null;

            posicionarEm(aIncluir.Coluna, aIncluir.Linha);

            aux = atual.Abaixo;
            atual.Abaixo = aIncluir;
            aIncluir.Abaixo = aux;

            aux = atual.Direita;
            atual.Direita = aIncluir;
            aIncluir.Direita = aux;
        }
        
        public Celula ValorDe(int col, int row)
        {
            if (col < 0 || row < 0)
                throw new Exception("Valor de linha ou coluna não podem ser menores ou iguais a 0");
            if (col > qtasColunas || row > qtasLinhas)
                throw new Exception("Valor de linha ou coluna não podem ser  maiores que a Matriz");

            posicionarEm(col, row);

            return atual;
        }

        public void posicionarEm(int col, int lin)
        {
            if (col < 0 || lin < 0)
                throw new Exception("Valor de linha ou coluna não podem ser menores ou iguais a 0");
            if (col > qtasColunas || lin > qtasLinhas)
                throw new Exception("Valor de linha ou coluna não podem ser  maiores que a Matriz");

            atual = primeira;
            for (int i = 0; i < col; i++)
            {
                atual = atual.Direita;
            }

            for (int j = 0; j < lin; j++)
            {
                atual = atual.Abaixo;
            }
        }
        

        public void Limpar()
        {
            for(int i = 0; i<qtasLinhas; i++)            
                for(int j=0; j<qtasColunas; j++)
                {
                    posicionarEm(i, j);
                    atual = null;
                }
        }

        public void Remover(Celula aRemover)
        {
            if(aRemover == null)            
                throw new Exception("nulo");

            posicionarEm(aRemover.Coluna-1, aRemover.Linha-1);
            atual.Direita = atual.Direita.Direita;
            atual.Abaixo  = atual.Abaixo.Abaixo;
        }

        public void somarConstante(int k, int col)
        {
            if (col < 0 || col > qtasColunas)
                throw new Exception("coluna inválida");
            
            posicionarEm(col, -1);
            while (atual.Abaixo != atual)
            {
                atual.Abaixo.Valor += k;
            }
        }
    }
}