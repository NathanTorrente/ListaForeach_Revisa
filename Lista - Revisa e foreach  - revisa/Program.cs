using Lista___Revisa_e_foreach____revisa;
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        ExemploLista1();
        ExemploListaObejtos();

    }
    static void ExemploLista1()
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

        bool contem = listastring.Contains("João");// Verifica se o elemento existe
        Console.WriteLine(contem);

        for (int i = 0; i < listastring.Count; i++)
        {
            Console.WriteLine(listastring[i]);
        }
        foreach (string str in listastring)
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
        listInt.Insert(0, 4);
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
    static void ExemploListaObejtos()
    {

        List<Paciente> ListaPacientes = new List<Paciente>();
        
       string nome = Console.ReadLine(); // uma forma
        Paciente p1 = new Paciente(1, nome, "5454", "Elias@gmail.com", new DateTime(1982, 07, 22));
        Paciente p2 = new Paciente(2, "Fulano", "111", "Jorge@gmail.com", new DateTime(2000, 07, 22));
        Paciente p3 = new Paciente(3, "Mario", "423", "Elias@gmail.com", new DateTime(1999, 07, 22));
        Paciente p4 = new Paciente(4, "Cabrero", "232", "Elias@gmail.com", new DateTime(2008, 07, 22));
        Paciente p5 = new Paciente(5, "Halerrandro", "053400", "Elias@gmail.com", new DateTime(1982, 07, 22));
        Paciente p6 = new Paciente(); // sem o construtor vazio da erro, faça um construtor vazio.
        p6.nome = Convert.ToString(nome);   // outra forma
        // Comando - limpar lista "Clear"
   
        ListaPacientes.Add(p1);
        ListaPacientes.Add(p2);
        ListaPacientes.Add(p3);
        ListaPacientes.Add(p4);
        ListaPacientes.Add(p5);
        ListaPacientes.Add(p6); // ADD - final da lista
        ListaPacientes.Remove(p5); 
        ListaPacientes.Insert(0, p5); // ADD no local especificado; 
                                      // ListaPacientes.Sort(); // orderna os elemtentos


        // O método ordeby ordena uma lista a partir de um determinado atributo, esse método
        // retorna uma lista ordenada (precisa armazenar esse resultado)
        // ToList() convert o resultado para uma lista
        // Caso Queira apresentar a nova lista ordenada, somente percorre-la
        // No exemplo, x.Nome especifica que irá ordenar pelo nome, pode ser qualquer atributo do objeto.


        List<Paciente> pOrdenados = ListaPacientes.OrderBy(x=> x.Id_paciente).ToList();   // Ordeby me retorna uma noiva lista ordenada, se passa o atributo, ex: .Nome, e aramazena na variavel pOrdenado
        List<Paciente> pOrdenadoss = ListaPacientes.OrderBy(x=> x.Id_paciente).ToList();   // Ordeby me retorna uma noiva lista ordenada, se passa o atributo, ex: .Nome, e aramazena na variavel pOrdenado
        

       foreach(Paciente p in pOrdenados)
       {
            Console.WriteLine($"{p.nome} {p.Cpf} {p.Email} {p.DataNac} ");
       }
        foreach(Paciente p in pOrdenadoss)
       {
            Console.WriteLine($"{p.nome} {p.Cpf} {p.Email} {p.DataNac} ");
       }
        
    }

}