
// Exercício: Gerenciamento de Lista de Convidados para Eventos
using System;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("##  Gerenciamento de Lista de Convidados para Eventos  ##");
Console.ResetColor();


var eventoA = new HashSet<string>() { "Alice", "Bruno", "Carlos", "Diana" };
var eventoB = new HashSet<string>() { "Carlos", "Diana", "Eduardo", "Fernanda" };
var eventoC = new HashSet<string>() { "Fernanda", "Gustavo", "Helena", "Alice" };


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n# Evento A #");
Console.ResetColor();
ExibirColecao(eventoA);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n# Evento B #");
Console.ResetColor();
ExibirColecao(eventoB);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n# Evento C #");
Console.ResetColor();
ExibirColecao(eventoC);


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-Todos os Convidados do Evento A também estão no Evento B ?");
Console.ResetColor();
Console.WriteLine(eventoA.IsSubsetOf(eventoB));


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-Isabel e João estão na lista do Evento C ?");
Console.ResetColor();
if (!eventoC.Contains("Isabel") && !eventoC.Contains("João"))
{
    Console.WriteLine("Não");
    eventoC.Add("Isabel");
    eventoC.Add("Joao");
}
else
{
    Console.WriteLine("Essas pessoas existem na lista");
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-Lista do Evento C com João e Isabel adicionados :");
Console.ResetColor();
ExibirColecao(eventoC);


eventoA.IntersectWith(eventoC);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-Convidados que estão presente no Evento A e Evento C: ");
Console.ResetColor();
ExibirColecao(eventoA);


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-Removendo os convidados do Evento B que estão no Evento C:");
Console.ResetColor();
eventoB.ExceptWith(eventoC);
ExibirColecao(eventoB);


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-Combinando as Listas de convidados do Evento A, B e C:");
Console.ResetColor();
eventoA.UnionWith(eventoB);
eventoB.UnionWith(eventoC);
ExibirColecao(eventoB);


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-Lista do Evento Final com todos os convidados de forma ordenada:");
Console.ResetColor();
var eventoFinal = new SortedSet<string>(eventoB);
ExibirColecao(eventoFinal);

// Limpeando todas as listas de convidados dos Eventos A, B, e C.
eventoA.Clear();
eventoB.Clear();
eventoC.Clear();
// Confirmando que todas as listas foram esvaziadas
Console.WriteLine();
ExibirColecao(eventoA);
ExibirColecao(eventoB);
ExibirColecao(eventoC);

Console.ReadKey();
// Criando uma função para Exibir a coleção
static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    if (!colecao.Any())
    {
        Console.WriteLine("Lista vazia.");
        return;
    }
    foreach (var item in colecao)
    {
        Console.WriteLine($"{item} ");
    }
}