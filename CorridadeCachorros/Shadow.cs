using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros
{
    public class Shadow : Corredor 
    {

        private static readonly Random Random = new();

        public Shadow(int posicaoCorredor) : base(posicaoCorredor)
        {
        }

        public void Mover()
        {
            int distanciaPercorrida = Random.Next(0, 7);

            _distanciaPercorrida += (distanciaPercorrida * 0.1);
        }

        public double DistanciaPercorrida()
        {
            return _distanciaPercorrida;
        }


    }
}
