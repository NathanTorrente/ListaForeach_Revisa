using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> listastring = new List<string>();
        listastring.Add("Elias");
        listastring.Add("João"); // adiciona os valores como ultimo elementos - final da lista
        listastring.Insert(1, "João"); // insert pega adiciona e coloca o elemento aonde voce quiser

            for (int i = 0; i < listastring.Count; i++) 
            {
              Console.WriteLine(listastring[i]);
            }
        foreach(string str in listastring)
            {
            Console.WriteLine(str);
            }
        //listastrin.Count ---- retorna o valor da lista
    }
}