using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadUnidad5II
{
    public class JugadorAmateur : Jugador
    {
        private string _centroEstudios;
        public string CentroEstudios { get => _centroEstudios; set => _centroEstudios = value; }
        public JugadorAmateur(string nombre, string alias, string nivel, string centroEstudios) : base (nombre, alias, nivel)
        {
            _centroEstudios = centroEstudios;
        }
    }
}
