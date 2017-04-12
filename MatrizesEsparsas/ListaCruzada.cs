using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizesEsparsas
{
    public class ListaCruzada
    {
        int qtasColunas, qtasLinhas;
        Celula primeira, atualLinha, atualColuna;

        /// <summary>
        /// Número de colunas da matriz
        /// </summary>
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
        /// <summary>
        /// Números de linhas da matriz
        /// </summary>
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
        /// <summary>
        /// Construtor, faz a estrutura da matriz criando os "nós cabeças"
        /// </summary>
        /// <param name="colunas">Número de colunas</param>
        /// <param name="linhas">Número de linhas</param>
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
            //primeira continua fixa
            primeira.Direita = aux;
            primeira = primeira.Direita;

        }

        public void Inserir(Celula aIncluir)
        {
            if (aIncluir.Valor == 0)
                return;

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
            while (atualColuna.Coluna < col && atualColuna.Direita.Coluna != -1)
                atualColuna = atualColuna.Direita;
            
        }

        public void posicionarEmLinha(int lin)
        {
            if (lin < -1)
                throw new Exception("Valor de linha não pode ser menor que -1");
            if (lin > qtasColunas)
                throw new Exception("linha não pode ser maior que a matriz");

            atualLinha = primeira;
            while(atualLinha.Linha < lin  && atualLinha.Abaixo.Linha != -1)            
                atualLinha = atualLinha.Abaixo;
            
        }

        public void Limpar()
        {
            posicionarEmColuna(0);
            posicionarEmLinha(0);

            while (atualColuna.Coluna != -1)
            {
                atualColuna.Abaixo = atualColuna;
                atualColuna = atualColuna.Direita;
            }

            while (atualLinha.Linha != -1)
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
            posicionarEmLinha(0);
            for(int i=0; i<QtasLinhas; i++)
            {
                if (ValorDe(col, i) == 0)
                    Inserir(new Celula(k, i, col, null, null));
                else
                    atualColuna.Valor += k;
                atualLinha = atualLinha.Abaixo;
                atualColuna = atualColuna.Abaixo;
            }
        }

        public ListaCruzada somar(ListaCruzada lista)
        {
            if (lista == null)
                throw new NullReferenceException("lista a ser somada está nula");

            ListaCruzada MaiorColuna, MaiorLinha;
            ListaCruzada MenorColuna, MenorLinha;
            int maiorColuna, maiorLinha = 0;
            if (this.qtasColunas.CompareTo(lista.qtasColunas) > 0)
            {
                maiorColuna = this.qtasColunas;
                MaiorColuna = this;
                MenorColuna = lista;
            }
            else
            {
                maiorColuna = lista.qtasColunas;
                MaiorColuna = lista;
                MenorColuna = this;
            }                
            if (this.qtasLinhas.CompareTo(lista.QtasLinhas) > 0)
            {
                maiorLinha = this.qtasLinhas;
                MaiorLinha = this;
                MenorLinha = lista;
            }                
            else
            {
                maiorLinha = lista.qtasLinhas;
                MaiorLinha = lista;
                MenorLinha = this;
            }                

            ListaCruzada ret = new ListaCruzada(maiorColuna, maiorLinha);

            int colunas, linhas = 0;
            colunas = MenorColuna.qtasColunas;
            linhas = MenorLinha.qtasLinhas;

            posicionarEmColuna(0);
            atualColuna = atualColuna.Abaixo;
            posicionarEmLinha(0);
            atualLinha = atualLinha.Direita;

            lista.posicionarEmLinha(0);
            lista.atualColuna = lista.atualColuna.Direita;
            lista.posicionarEmColuna(0);
            lista.atualLinha = lista.atualLinha.Abaixo;

            ret.posicionarEmLinha(0);
            ret.atualColuna = lista.atualColuna.Direita;
            ret.posicionarEmColuna(0);
            ret.atualLinha = lista.atualLinha.Abaixo;

            for (int i=0; i<colunas; i++)
            {                
                for(int j=0; j<linhas; j++)
                    ret.Inserir(new Celula(ValorDe(i, j) + lista.ValorDe(i, j), j, i, null, null));
                for (int k = linhas; k < maiorLinha; k++)
                    ret.Inserir(new Celula(MaiorLinha.ValorDe(i,k),k,i,null,null));
            }

            for(int w=colunas; w<maiorColuna; w++)
            {
                for (int j = 0; j < linhas; j++)
                    ret.Inserir(new Celula(ValorDe(w, j) + lista.ValorDe(w, j), j, w, null, null));
                for (int k = linhas; k < maiorLinha; k++)
                    ret.Inserir(new Celula(MaiorLinha.ValorDe(w, k), k, w, null, null));
            }
            return ret;
        }

        public ListaCruzada multiplicar(ListaCruzada outra)
        {
            if (qtasColunas != outra.qtasLinhas || outra==null)
                throw new Exception("Não pode ocorrer multiplicação");

            ListaCruzada ret = new ListaCruzada(outra.qtasColunas,qtasLinhas);

            for (int lin = 0; lin < qtasLinhas; lin++)
            {
                for (int col = 0; col < outra.qtasColunas; col++)
                {
                    double valor = 0.0;
                    for (int i = 0; i < qtasColunas; i++)
                        valor += ValorDe(i, lin) * outra.ValorDe(col, i);

                    ret.Inserir(new Celula(valor, lin, col, null, null));
                }
            }
            return ret;
        }
    }
}