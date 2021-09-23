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
    
                for (int i = 0; i < matriz.GetUpperBound(0) ; i+=2) ////sabia que precisava usar o +=2, mas não pensei em usar aqui. fiquei bastante tempo tentando usar dentro do bloco
                {
                    Console.Write(matriz[i+1]); //
                    Console.Write(matriz[i]);   //dei uma lida na reslução e adaptei. Antes eu conseguia trocar as letras do meio, mas nunca os pares do início e do fim da palavra
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
                        break;
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

