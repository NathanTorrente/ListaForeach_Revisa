using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> listastring = new List<string>();
        listastring.Add("Elias");
        listastring.Add("João"); // adiciona os valores como ultimo elementos - final da lista
        listastring.Insert(1, "João"); // Adiciona um elemento em uma posição específica da lista, voce define.




        /*O foreach percorre todos os elementos da lista, da primeira posição até a ultima
         * para cada repetição, copia o endereço da posição atual da lista ou seja, na primeira repetição
         * 
         * na segunda repetição, str o valor da posição 1 da lista (João)
         * 
         * 
         * */

            for (int i = 0; i < listastring.Count; i++) 
            {
              Console.WriteLine(listastring[i]);
            }
        foreach(string str in listastring)
            {
            Console.WriteLine(str);
            }

        //listastrin.Count ---- retorna o valor da lista
        //for (int i = 0; i < listastring.Count; i++)
       // {
       //     Console.WriteLine(listastring[i]);
       // }

        List<int> listInt = new List<int>();
        listInt.Add(1);
        listInt.Add(3);
        listInt.Insert(2,4);

        foreach(int i in listInt)
        {
            Console.WriteLine(i);
        }


    }
}