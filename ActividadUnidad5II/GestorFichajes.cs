using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadUnidad5II
{
    public class GestorFichajes
    {
        public List<Jugador> Jugadores {  get; set; }
        public List<Equipo> Equipos { get; set; }
        public GestorFichajes()
        {
            Jugadores = new List<Jugador>();
            Equipos = new List<Equipo>();
        }
        public void TramitarBajas (Equipo e, Jugador j) { }
        public void TramitarAltas(Equipo e, Jugador j) { }
    }
}
