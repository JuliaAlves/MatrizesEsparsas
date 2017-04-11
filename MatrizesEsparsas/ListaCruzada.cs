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
        Celula primeira, atualLinha, atualColuna;

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

            posicionarEmColuna(aIncluir.Coluna);
            posicionarEmLinha(aIncluir.Linha);

            while(atualColuna.Abaixo.Linha< atualLinha.Linha && atualColuna.Abaixo.Linha!=-1)
                atualColuna = atualColuna.Abaixo;

            aux=atualColuna.Abaixo;
            atualColuna.Abaixo = aIncluir;
            aIncluir.Abaixo = aux;

            while (atualLinha.Direita.Coluna < atualColuna.Coluna && atualLinha.Direita.Coluna != -1)
                atualLinha = atualLinha.Direita;

            aux = atualLinha.Direita;
            atualLinha.Direita = aIncluir;
            aIncluir.Direita = aux;

        }
        
        public double ValorDe(int col, int row)
        {
            if (col < 0 || row < 0)
                throw new Exception("Valor de linha ou coluna não podem ser menores ou iguais a 0");
            if (col > qtasColunas || row > qtasLinhas)
                throw new Exception("Valor de linha ou coluna não podem ser  maiores que a Matriz");

            posicionarEmColuna(col);

            while (atualColuna.Linha < row && atualColuna.Abaixo.Linha != -1)
                atualColuna = atualColuna.Abaixo;

            if (atualColuna.Linha==row&&atualColuna.Coluna==col)            
                return atualColuna.Valor;

            return 0;
        }

        public void posicionarEmColuna(int col)
        {
            if (col < -1 )
                throw new Exception("Valor de linha ou coluna não podem ser menores ou iguais a -1");
            if (col > qtasColunas )
                throw new Exception("Valor de linha ou coluna não podem ser  maiores que a Matriz");

            atualColuna = primeira;
            for (int i = 0; i < col; i++)
            {
                atualColuna = atualColuna.Direita;
            }
        }

        public void posicionarEmLinha(int lin)
        {
            if (lin < -1)
                throw new Exception("Valor de linha não pode ser menor que -1");
            if (lin > qtasColunas)
                throw new Exception("linha não pode ser maior que a matriz");

            atualLinha = primeira;
            for (int j = 0; j < lin; j++)
            {
                atualLinha = atualLinha.Abaixo;
            }
        }

        public void Limpar()
        {
            posicionarEmColuna(0);
            posicionarEmLinha(0);

            while (atualColuna.Direita.Coluna != -1)
            {
                atualColuna.Abaixo = atualColuna;
                atualColuna = atualColuna.Direita;
            }

            while (atualLinha.Abaixo.Linha != -1)
            {
                atualLinha.Direita = atualLinha;
                atualLinha = atualLinha.Abaixo;
            }

        }

        public void Remover(Celula aRemover)
        {
            if(aRemover == null)            
                throw new Exception("nulo");

            posicionarEmLinha(aRemover.Linha);
            posicionarEmColuna(aRemover.Coluna);


            while (atualColuna.Abaixo.Linha < atualLinha.Linha && atualColuna.Abaixo.Linha != -1)
                atualColuna = atualColuna.Abaixo;

            while (atualLinha.Direita.Coluna < atualColuna.Coluna && atualLinha.Direita.Coluna != -1)
                atualLinha = atualLinha.Direita;

            atualColuna.Abaixo = aRemover.Abaixo;
            atualLinha.Direita = aRemover.Direita;
        }

        public void somarConstante(int k, int col)
        {
            if (col < 0 || col > qtasColunas)
                throw new Exception("coluna inválida");
            
            posicionarEmColuna(col);
            while (atualColuna.Abaixo.Linha != -1)
            {
                atualColuna.Abaixo.Valor += k;
                atualColuna = atualColuna.Abaixo;
            }
        }
    }
}