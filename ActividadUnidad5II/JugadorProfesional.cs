using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadUnidad5II
{
    public class JugadorProfesional : Jugador, IEntrevistable
    {
        private decimal _sueldo;
        private string _patrocinador;
        public decimal Sueldo { get => _sueldo; set => _sueldo = value;  }
        public string Patrocinador { get=> _patrocinador; set =>  _patrocinador = value; }
        public JugadorProfesional(string nombre, string alias, string nivel, decimal sueldo, string patrocinador) : base(nombre, alias, nivel)
        {
            _sueldo = sueldo;
            _patrocinador = patrocinador;
        }
        public void RealizarDeclaraciones(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
