using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadUnidad5II
{
    public class Equipo
    {
        private string _nombre;
        private DateTime _fechaFundacion;
        public string Nombre { get => _nombre; set => _nombre = value;  }
        private Estadisticas _estadisticas;
        public DateTime FechaFundacion { get => _fechaFundacion; set => _fechaFundacion = value; }
        public Estadisticas Estadisticas { get => _estadisticas; }
        public List<Jugador> JugadoresActuales { get; set; }
        public Equipo(string nombre, DateTime fechaFundacion, List<Jugador> jugadores)
        {
            _nombre = nombre;
            _fechaFundacion = fechaFundacion;
            _estadisticas = new Estadisticas();  
            JugadoresActuales =  jugadores ?? new List<Jugador>();  
        }
    }
}
