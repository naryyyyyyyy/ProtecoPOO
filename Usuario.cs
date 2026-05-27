using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        private string Contrasena { get; set; }
        private int Personajeid {  get; set; }
        public decimal Saldo { get; set; }
        public Usuario(string nombre, int id,int personajeid, string contrasena, decimal saldo)
        {
            Personajeid = personajeid;
            Nombre = nombre;
            Id = id;
            Contrasena = contrasena;
            Saldo = saldo;
        }
    }
}
