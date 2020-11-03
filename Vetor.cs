using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_memoria
{
    class Vetor
    {
        //criei um vetor para na hora de sortear, nao repetir os numeros
        private string[] vet_Img;
        private int qtosElementosTemNoVetor;
        private int limiteLogico;
        private int[] numerosQueJaForam ;
        private int qtdNumerosJaForam = 0;
        public Vetor(int qtde, int limite)
        {
            vet_Img = new string[limite];
            qtosElementosTemNoVetor = qtde;
            limiteLogico = limite;
            numerosQueJaForam = new int[limite];

        }
        public bool estaCheio()
        {
            return (qtosElementosTemNoVetor == limiteLogico);
        }
        public void insereDadoNoVetor(int posicao, string nomeArq)
        {
            if (!estaCheio())
            {
                qtosElementosTemNoVetor++;
                vet_Img[posicao] = nomeArq;
            }
        }
        public string RetornaConteudoDoVetorPosicaoEspecifica(int posicao)
        {
            return vet_Img[posicao];
        }                            


        public bool verificar(string nomeArq1, string nomeArq2)
        {          

            bool certo = false;                      
                if (nomeArq1 == nomeArq2)
            { 
                    certo = true;                
            }

            if (certo)
                return true;
            else
                return false;
        }
        



        public int sortearNumero()
        {
            //tive problemas com o ZERO, então fiz começar com 1
            int numero = 0;
            Random random = new Random();               
            bool sorteia = true;

            while (sorteia)
            {
                int indice = 0;
                numero = random.Next(0, 9);

                while (indice <= qtdNumerosJaForam)
                {
                    if (numerosQueJaForam[indice] != numero)
                    {
                        sorteia = false;
                    }
                    else
                    {
                        indice = numerosQueJaForam.Length - 1;
                        sorteia = true;                        
                    }
                    indice++;
                }                   
            }
            numerosQueJaForam[qtdNumerosJaForam] = numero;
            qtdNumerosJaForam++;
            return numero ;

        }

            
        




    }
    
}
