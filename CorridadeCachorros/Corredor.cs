namespace CorridaDeCachorros;

public class Corredor : BaseModel
{
    private static readonly Random Random = new();

    private double _distanciaPercorrida { get; set; }
    public Posicoes Posicao { get; set; }

    public Corredor(int posicaoCorredor) : base()
    {
        Nome = $"Corredor-{posicaoCorredor}";
        _distanciaPercorrida = 0.0;
        Posicao = Posicoes.NaoGanho;
    }

    public void Mover()
    {
        int distanciaPercorrida = Random.Next(1, 6);

        _distanciaPercorrida += (distanciaPercorrida * 0.1);
    }

    public double DistanciaPercorrida()
    {
        return _distanciaPercorrida;
    }

    public enum  TiposCachorros
    {
        Tipo1 = 1,
        Tipo2 = 2, 
        Tipo3 = 3,

    }

    //eu tenho que criar mais tipos de cachorros 
    // assim usando o metódo random para delimitar as suas corridas
    //
}




