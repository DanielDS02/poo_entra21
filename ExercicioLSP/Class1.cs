public class GuardaChuva
{
    public virtual void Abrir()
    {
        Console.WriteLine("Guarda-chuva aberto.");
    }
    public virtual void Fechar()
    {
        Console.WriteLine("Guarda-chuva fechado.");
    }
}
public class GuardaChuvaAutomatico : GuardaChuva
{
    private bool _estaAberto;
    public void NewAbrir()
    {
        Console.WriteLine("Guarda-chuva automático abrindo.");
        _estaAberto = true;
    }
    public void NewFechar()
    {
        Console.WriteLine("Guarda-chuva automático fechando.");
        _estaAberto = false;
    }
    public void Agitar()
    {
        if (_estaAberto)
        {
            Console.WriteLine("Guarda-chuva automático agitado.");
        }
        else
        {
            Console.WriteLine("Não é possível agitar um guarda-chuva fechado.");
        }
    }
}
