using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ProtecoPOO;

namespace CarreraCaballos
{
    public abstract class Caballo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PositionX { get; set; }

        protected Random random;
        public Image Icon { get; protected set; }

        public Caballo(int id, string name)
        {
            Id = id;
            Name = name;
            PositionX = 0;
            random = new Random(id + Environment.TickCount);

        }
        public void Reiniciar() => PositionX = 0;
        public abstract void Avanzar(double distanciaMeta);

    }
}