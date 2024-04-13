using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bitebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region // Exemplos array em C#
//TestarArrayInt();

//TestarBuscarPalavra();

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestarMediada(amostra);

//int[] valores = { 10, 58, 36, 47 };
//for (int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}

void TestarMediada(Array valores)
{
    if (valores is null || valores.Length.Equals(0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])valores!.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0)
        ? numerosOrdenados[meio]
        : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

void TestarArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"O tamanho do Array é: {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        acumulador += idade;

        Console.WriteLine($"Índice [{i}]: {idade}");
    }

    int media = acumulador / idades.Length;

    Console.WriteLine($"Média de idades = {media}");
}

void TestarBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+1} Palavra: ");
        arrayDePalavras[i] = Console.ReadLine()!;
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    string busca = Console.ReadLine()!;
    Console.WriteLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra econtrada = {busca}");
            break;
        }
    }
}

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

    var contaDoEverton = new ContaCorrente(874, "123456-X");
    listaDeContas.Adicionar(contaDoEverton);
    //listaDeContas.ExibirLista();
    //Console.WriteLine("==============");
    //listaDeContas.Remover(contaDoEverton);
    //listaDeContas.ExibirLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = Conta {conta.Conta}/{conta.Numero_agencia}");
    }
}

//TestaArrayDeContasCorrentes();
#endregion
#region Exemplos de uso do List
//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Olá mundo!");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}

List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};

_listaDeContas2.AddRange(_listaDeContas3);
_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = Conta [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//range.Clear();
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = Conta [{range[i].Conta}]");
//}

bool VerificaNomes(List<string> nomesDosEscolhidos, string escolhido)
{
    return nomesDosEscolhidos.Contains(escolhido);
}

List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

//Console.WriteLine(
//    VerificaNomes(nomesDosEscolhidos, "Bob Kane")
//);
#endregion

new ByteBankAtendimento().AtendimentoCliente();