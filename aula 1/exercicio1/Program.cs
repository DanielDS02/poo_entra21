internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Quantas vezes você quer que seja calculado o fibonacci?");
    var repeticoes = Convert.ToInt32(Console.ReadLine());

    int numeroAnterior = 0;
    int numeroAtual = 1;
    int novoNumero;
    int fibonacci;


    for (int i = 0; i < repeticoes; i++)
    {
      fibonacci = numeroAnterior + numeroAtual;
      Console.WriteLine(fibonacci);
      numeroAnterior = numeroAtual;
      numeroAtual = fibonacci;
    }
  }
}