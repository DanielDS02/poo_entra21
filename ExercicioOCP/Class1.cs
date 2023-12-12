public class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
}
public class CalculadoraAluguel
{
    public double CalcularPrecoAluguel(Carro carro)
    {
        double preco = 0;
        if (carro.Ano >= 2020)
        {
            preco = 100;
        }
        else
        {
            preco = 50;
        }
        return preco;
    }
}
public class CarroElétrico : Carro 
{ 
    public int AutonomiaBateria { get; set; } 

    public int Bateria { get; set;}

    public CarroElétrico()
    {
        
    }
}
public class CalculadoraAluguelElétrico
{
    public double CalcularPrecoAluguel(Carro carro, CarroElétrico carroEletrico)
    {
        double preco = 0;
        if (carro.Ano >= 2020)
        { preco = 100; }
        else if (carro is CarroElétrico)
        {
            if (carroEletrico.AutonomiaBateria > 300)
            {
                preco += 50;
            }
        }
        else
        {
            preco = 50;
        }
        return preco;
    }
}
