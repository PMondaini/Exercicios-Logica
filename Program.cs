using System;

namespace Laços_Condicionais__Laços_Numéricos__Vetores_e_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "";
            char [] matriz;

            Console.Write("Digite a palavra: ");
            palavra = Console.ReadLine();
            matriz = palavra.ToCharArray();
            Console.WriteLine($"A palavra escolhida é {palavra} e possui {matriz.Length} caracteres ");
            
            if (matriz.Length % 2 == 0)
            {
                string troca = ""; // 
                for (int i=0; i < palavra.Length; i+=2) //não pensei em usar o +=2. Tentei com ++
                {
                    troca += palavra[i + 1];       //
                    troca += palavra[i];           //
                    Console.Write(palavra[i+1]);   //
                    Console.Write(palavra[i]);     //precisei copiar praticamente tudo. o máximo que consegui fazendo pela matriz foi trocar as letras do meio, mas nunca os pares do começo e do fim
                }
            }    
            else
            {
                Console.Write("O inverso da palavra é: ");

                for (int j = matriz.GetUpperBound(0) ;  j>= 0 ; j--)
                {
                    Console.Write(matriz[j]);
                }
            } 

            char [] matrizInversa;
            bool comparacao = false;
            matrizInversa = palavra.ToCharArray();
            Array.Reverse(matrizInversa);          

            if (matriz.Length != matrizInversa.Length)
            {
                comparacao = false;
            }
            else
            {
                for (int l = 0 ; l <= matriz.GetUpperBound(0) ; l++ )
                {
                    if (matriz[l] != matrizInversa[l])
                    {
                        comparacao = false;
                    }
                    else
                    {
                        comparacao = true;
                    }
                }
            }
            Console.WriteLine(comparacao ? "\nÉ palíndromo" : "\nNão é palíndromo");
        
            string retorno = "";    //aqui precisei copiar tudo. TENTAR ADAPTAR
            retorno += palavra[0];
            for (int k = 0; k < palavra.Length; k++)
            {
                bool achouLetra = false;
                for (int r =0; r< retorno.Length;r++)
                {

                    if (palavra[k] == retorno[r])
                    {
                        achouLetra = true;
                        break;//break para sair do for, pois se ele ja achou a letra nao faz sentido continuar olhando
                    }
                }
                if (!achouLetra)
                {
                    retorno += palavra[k];
                }
            }
            Console.WriteLine(retorno);
        }
    }
}

