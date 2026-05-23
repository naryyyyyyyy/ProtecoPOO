using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bj
{
    public class Usuario
    {
        string Nombre {  get; set; }
        int Id { get; set; }
        private string Contrasena { get; set; }
        decimal Saldo { get; set; }
        public Usuario(string nombre, int id, string contrasena, decimal saldo)
        {
            Nombre = nombre;
            Id = id;
            Contrasena = contrasena;
            Saldo = saldo;
        }
    }
}
