using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe a distância em km entre o distribuidor e o local de entrega:");
        int distancia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o peso da encomenda em kg:");
        double peso = Convert.ToDouble(Console.ReadLine());

        // Calcular o valor do frete baseado na distância
        double valorFrete = CalcularFrete(distancia);

        // Ajustar o valor do frete com base no peso
        valorFrete = AjustarFretePorPeso(valorFrete, peso);

        Console.WriteLine($"O valor do frete é: R$ {valorFrete:F2}");
    }

    static double CalcularFrete(int distancia)
    {
        // Calcular o valor do frete com base na distância
        double valorFrete = distancia * 0.10;

        // Adicionar taxa de R$ 1,00 a cada 200 km
        valorFrete += (distancia / 200) * 1.00;

        // Adicionar taxa de R$ 10,00 a cada 1000 km
        valorFrete += (distancia / 1000) * 10.00;

        return valorFrete;
    }

    static double AjustarFretePorPeso(double valorFrete, double peso)
    {
        // Ajustar o valor do frete com base no peso
        if (peso > 5 && peso <= 25)
        {
            valorFrete *= 5;
        }
        else if (peso > 25 && peso <= 75)
        {
            valorFrete *= 3;
        }

        return valorFrete;
    }
}


