using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros
{
    public class Tails : Corredor
    {
        public Tails(int posicaoCorredor) : base(posicaoCorredor)
        {
        }

        private static readonly Random Random = new();

        public void Mover()
        {
            int distanciaPercorrida = Random.Next(2, 4);

            _distanciaPercorrida += (distanciaPercorrida * 0.1);
        }

        public double DistanciaPercorrida()
        {
            return _distanciaPercorrida;
        }


    }
}
