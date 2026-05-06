using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadUnidad5II
{
    public abstract class Jugador
    {
        private string _nombre;
        private string _alias;
        private string _nivel;
        public string Nombre { get => _nombre; set => _nombre = value;  }
        public string Alias { get => _alias; set => _alias = value; }
        public string Nivel { get => _nivel; set => _nivel = value; }
        public Equipo EquipoActual { get; set;}

        public Jugador(string nombre, string alias, string nivel)
        {
            _nombre = nombre;
            _alias = alias;
            _nivel = nivel;
        }
    }
}
