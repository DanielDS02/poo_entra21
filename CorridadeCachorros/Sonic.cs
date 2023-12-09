using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros
{
    public class Sonic : Corredor
    {

        private static readonly Random Random = new();

        public Sonic(int posicaoCorredor) : base(posicaoCorredor)
        {
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



    }
}
