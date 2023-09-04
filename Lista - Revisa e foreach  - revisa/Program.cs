using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> listastring = new List<string>();
        listastring.Add("Elias");
        listastring.Add("Júlia"); // adiciona os valores como ultimo elementos - final da lista
        listastring.Insert(1, "João"); // Adiciona um elemento em uma posição específica da lista, voce define.
                                       // listastring.RemoveAt(1);
                                       // listastring.Remove("João");
        listastring.Add("Ana Maria");
      

        listastring.Sort(); //Comando responsável por ordenar a lista em ordem alfabética.
        /*O foreach percorre todos os elementos da lista, da primeira posição até a ultima
         * para cada repetição, copia o endereço da posição atual da lista ou seja, na primeira repetição
         * a variavel str recebe o valor da posição 0 da lista (Elias)
         * na segunda repetição, str o valor da posição 1 da lista (João)
       
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
        listInt.Insert(0,4);
        //List<int> list2 = listInt.OrderByDescending().ToList();

        //foreach(int i in list2)
       // {
       //     Console.WriteLine(i);
       // }
        //liststring.Count retorna o tamanho da lista 

        //  for (int i = 0;i < listInt.Count;i++)
        // {

        //  }
        List<double> listadouble = new List<double> { 2.5, 3, 8.2 };
        listadouble.Add(1);

    }
}