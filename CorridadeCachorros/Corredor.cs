namespace CorridaDeCachorros;

public class Corredor : BaseModel
{
  

    public double _distanciaPercorrida { get; set; }
    public Posicoes Posicao { get; set; }

    public Corredor(int posicaoCorredor) : base()
    {
        Nome = $"Corredor-{posicaoCorredor}";
        _distanciaPercorrida = 0.0;
        Posicao = Posicoes.NaoGanho;
    }

}




