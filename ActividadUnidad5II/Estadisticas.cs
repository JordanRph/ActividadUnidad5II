using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadUnidad5II
{
    public class Estadisticas
    {
        private int _partidosGanados;
        private int _partidosPerdidos;
        public int PartidosGanados { get =>  _partidosGanados; set => _partidosGanados = value; }
        public int PartidosPerdidos {  get => _partidosPerdidos; set => _partidosPerdidos = value; }

        public void RegistrarVictoria() { }
        public void RegistrarDerrota() { }
    }
}
